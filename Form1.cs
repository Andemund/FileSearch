/*
 * This program is used for searching a key word in a selected txt file
 * Case-insensitive, key word part contained count(like search "good" also can get "goodness")
 * 
 * Using step: 
 * 1. Click "Browse" button to select a txt file; 
 * 2. input a key word; 
 * 3. If "Search" button is clickable, clikc it to start searching; 
 * 4. Searching result will be showed in below list view.
 * 5. If "Search" button is not clickable, please check whether file path is valid and key word is not empty
 * 6. "Search" will turn to "Cancel" once searching process begin, click "Cancel" the searching process will stop at once
 *
 * The process bar will give users a approximate sence of how long they still have to wait
 * The status bar will show program's status and how many result already found
 * ListView show the result with result line number and content, and will focus on the newest line
 */

using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace SearchFile
{
    
    public partial class TextSearch : Form
    {
        private BackgroundWorker myBackgroundWorker = new BackgroundWorker();
        private String FileName;
        private String KeyWord;
        private int findNumber = 0;
        private int count = 0;
        private int LineNumber = 0;
        private Boolean Cancelled = false;
        private int totalline = 20000; // hard code the total task amount to avoid read the file twice, may not precise especially for small files

        private void BrowseOnClick(object sender, EventArgs e)
        {
            // Show the open file dialog
            // Save th eseelcted file's path as FileName and show it in the textbox
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                FileNameTextBox.Text = FileName;
            }
        }

        // once the text in filename textbox or keyword textbox is changed, check validation
        // make "Search" button not clickable if file not exist or key word is empty
        private void SetSearchButtonEnable(object sender, EventArgs e)
        {
            KeyWord = SearchforTextBox.Text;           
            if (KeyWord == "" || KeyWord == null || !File.Exists(FileNameTextBox.Text))
            {
                SearchButton.Enabled = false;
            }
            else
            {
                SearchButton.Enabled = true;
            }
        }

        // "Search" button, also "Cancel" button, change when it is clicked
        // program status and Cancelled status also changed when this button is clicked
        private void SearchOnClick(object sender, EventArgs e)
        {
            KeyWord = SearchforTextBox.Text;
            if (SearchButton.Text == "Cancel")
            {
                FileNameTextBox.ReadOnly = false;
                SearchforTextBox.ReadOnly = false;
                toolStripStatusLabel.Text = "Searching precess is cancellend.";
                StatusBar.Refresh();
                SearchButton.Text = "Search";
                Cancelled = true;
            }
            else if(SearchButton.Text == "Search")
            {
                FileNameTextBox.ReadOnly = true;
                SearchforTextBox.ReadOnly = true;
                toolStripStatusLabel.Text = "Searching precess start.";
                StatusBar.Refresh();
                ResultListView.Items.Clear();
                ResultListView.Update();
                ResultListView.Refresh();
                ProgressBar.Value = 0;
                SearchButton.Text = "Cancel";
                Cancelled = false;
            }
            
            if(!Cancelled)
            {
                myBackgroundWorker.RunWorkerAsync();
            }
            else
            {
                myBackgroundWorker.CancelAsync();
            }          
        }

        // init backgroundworker functions and attritibutes and other program status
        public TextSearch()
        {
            InitializeComponent();
            myBackgroundWorker.DoWork += new DoWorkEventHandler(myBackgroundWorker_DoWork);
            myBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myBackgroundWorker_RunWorkerCompleted);
            myBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(myBackgroundWorker_ProgressChanged);
            myBackgroundWorker.WorkerReportsProgress = true;
            myBackgroundWorker.WorkerSupportsCancellation = true;
            SearchButton.Enabled = false;
            FCStatusLabel.Text = "Ready.";
        }

        private void TextSearch_Load(object sender, EventArgs e)
        {

        }

        // DoWork: read target file line by line and find out whether this line contains key word
        // if it contains, send this line/s information to ReportProgress
        protected void myBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        { 
            String line;
            StreamReader file = new StreamReader(FileName);
            // continue reading while thie file is not finished
            while ((line = file.ReadLine()) != null)
            {
                Thread.Sleep(1); // sleep 1 millisecond every time the program read a line
                if (myBackgroundWorker.CancellationPending) // if it got a canael singal
                {
                    Cancelled = true;
                    e.Cancel = true;
                    break;
                }
                else if (line.ToLower().Contains(KeyWord.ToLower())) // case-insensitive, contains target key word
                {
                    findNumber++; // totally find findNumber lines
                    LineNumber = count + 1; // target line number in real world
                    myBackgroundWorker.ReportProgress(count, line); // send  line number and line context to ReportProgress
                    Thread.Sleep(50); // sleep 50 millisecond after show one target line to make it looks better especially when there's lots of target lin ein one search
                }
                else
                {
                    myBackgroundWorker.ReportProgress(count);
                }
                count++;
            }
        }

        //RunWorkerCompleted: reset parameters and progress bar
        protected void myBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // when the progerss is completed, set pregress bar depends on whether it's cancelled or finidhed
            if(e.Cancelled)
            {
                FCStatusLabel.Text = "Cancelled.";
                ProgressBar.Value = 0;
            }
            else
            {
                FCStatusLabel.Text = "Finished.";
                ProgressBar.Value = totalline;
            }
            // reset counting paramaters
            SearchButton.Text = "Search";
            FileNameTextBox.ReadOnly = false;
            SearchforTextBox.ReadOnly = false;
            count = 0;
            LineNumber = 0;
            findNumber = 0;
        }


        // ProgressChanged: show the result on the interface
        protected void myBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string f = e.UserState as String;
            if (f == "" || f == null)
            {

            }
            else
            {
                String[] row = { findNumber.ToString(), LineNumber.ToString(), f }; // result number, line number in txt file, line context
                ListViewItem item = new ListViewItem(row);
                ResultListView.Items.Add(item); // add this line's information to the list view
                ResultListView.Items[ResultListView.Items.Count - 1].EnsureVisible(); // focus on the newest line
            }            
            ProgressBar.Maximum = totalline;
            ProgressBar.Value = count;
            FCStatusLabel.Text = "Searching..."; // program status is "Searching"
            toolStripStatusLabel.Text = "Find " + (findNumber).ToString() + " lines contains target key word."; // show how many lines already found on status bar
            StatusBar.Refresh();
        }
    }
}

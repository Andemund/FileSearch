namespace SearchFile
{
    partial class TextSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileNameLable = new System.Windows.Forms.Label();
            this.SearchforLable = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchforTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.LineNoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FCStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ResultNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameLable
            // 
            this.FileNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLable.AutoSize = true;
            this.FileNameLable.Location = new System.Drawing.Point(25, 19);
            this.FileNameLable.Name = "FileNameLable";
            this.FileNameLable.Size = new System.Drawing.Size(54, 13);
            this.FileNameLable.TabIndex = 0;
            this.FileNameLable.Text = "File Name";
            // 
            // SearchforLable
            // 
            this.SearchforLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchforLable.AutoSize = true;
            this.SearchforLable.Location = new System.Drawing.Point(25, 51);
            this.SearchforLable.Name = "SearchforLable";
            this.SearchforLable.Size = new System.Drawing.Size(56, 13);
            this.SearchforLable.TabIndex = 1;
            this.SearchforLable.Text = "Search for";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameTextBox.Location = new System.Drawing.Point(88, 19);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(537, 20);
            this.FileNameTextBox.TabIndex = 2;
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.SetSearchButtonEnable);
            // 
            // SearchforTextBox
            // 
            this.SearchforTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchforTextBox.Location = new System.Drawing.Point(88, 51);
            this.SearchforTextBox.Name = "SearchforTextBox";
            this.SearchforTextBox.Size = new System.Drawing.Size(537, 20);
            this.SearchforTextBox.TabIndex = 3;
            this.SearchforTextBox.TextChanged += new System.EventHandler(this.SetSearchButtonEnable);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(661, 15);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseOnClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(661, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchOnClick);
            // 
            // ResultListView
            // 
            this.ResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ResultNumber,
            this.LineNoColumn,
            this.TextColumn});
            this.ResultListView.HideSelection = false;
            this.ResultListView.Location = new System.Drawing.Point(28, 91);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(708, 291);
            this.ResultListView.TabIndex = 6;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // LineNoColumn
            // 
            this.LineNoColumn.Text = "Line NO.";
            // 
            // TextColumn
            // 
            this.TextColumn.Text = "Text";
            this.TextColumn.Width = 550;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.FCStatusLabel,
            this.toolStripStatusLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 439);
            this.StatusBar.MinimumSize = new System.Drawing.Size(800, 0);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(800, 22);
            this.StatusBar.TabIndex = 7;
            this.StatusBar.Text = "statusStrip";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(45, 17);
            this.StatusLabel.Text = "Status: ";
            // 
            // FCStatusLabel
            // 
            this.FCStatusLabel.Name = "FCStatusLabel";
            this.FCStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.FCStatusLabel.Text = "Ready.";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(28, 398);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(708, 23);
            this.ProgressBar.TabIndex = 8;
            // 
            // ResultNumber
            // 
            this.ResultNumber.Text = "Result NO.";
            this.ResultNumber.Width = 70;
            // 
            // TextSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.SearchforTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.SearchforLable);
            this.Controls.Add(this.FileNameLable);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "TextSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Search";
            this.Load += new System.EventHandler(this.TextSearch_Load);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileNameLable;
        private System.Windows.Forms.Label SearchforLable;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.TextBox SearchforTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.ColumnHeader LineNoColumn;
        private System.Windows.Forms.ColumnHeader TextColumn;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel FCStatusLabel;
        private System.Windows.Forms.ColumnHeader ResultNumber;
    }
}


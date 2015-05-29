namespace getUserContent
{
    partial class MainDialog
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UserDataList = new System.Windows.Forms.CheckedListBox();
            this.SelectNone = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadPath = new System.Windows.Forms.TextBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.getUserData = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.UserDataList);
            this.splitContainer1.Panel1.Controls.Add(this.SelectNone);
            this.splitContainer1.Panel1.Controls.Add(this.SelectAll);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(527, 166);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 1;
            // 
            // UserDataList
            // 
            this.UserDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDataList.FormattingEnabled = true;
            this.UserDataList.Location = new System.Drawing.Point(0, 0);
            this.UserDataList.Name = "UserDataList";
            this.UserDataList.Size = new System.Drawing.Size(293, 120);
            this.UserDataList.TabIndex = 2;
            // 
            // SelectNone
            // 
            this.SelectNone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectNone.Location = new System.Drawing.Point(0, 120);
            this.SelectNone.Name = "SelectNone";
            this.SelectNone.Size = new System.Drawing.Size(293, 23);
            this.SelectNone.TabIndex = 1;
            this.SelectNone.Text = "None";
            this.SelectNone.UseVisualStyleBackColor = true;
            this.SelectNone.Click += new System.EventHandler(this.SelectNone_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectAll.Location = new System.Drawing.Point(0, 143);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(293, 23);
            this.SelectAll.TabIndex = 0;
            this.SelectAll.Text = "All";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProgressBar);
            this.panel1.Controls.Add(this.DownloadPath);
            this.panel1.Controls.Add(this.DownloadButton);
            this.panel1.Controls.Add(this.getUserData);
            this.panel1.Controls.Add(this.username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 166);
            this.panel1.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(3, 114);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(224, 23);
            this.ProgressBar.TabIndex = 6;
            // 
            // DownloadPath
            // 
            this.DownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadPath.Location = new System.Drawing.Point(2, 73);
            this.DownloadPath.Multiline = true;
            this.DownloadPath.Name = "DownloadPath";
            this.DownloadPath.ReadOnly = true;
            this.DownloadPath.Size = new System.Drawing.Size(225, 20);
            this.DownloadPath.TabIndex = 4;
            this.DownloadPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DownloadPath_MouseClick);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.Enabled = false;
            this.DownloadButton.Location = new System.Drawing.Point(2, 139);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(225, 23);
            this.DownloadButton.TabIndex = 3;
            this.DownloadButton.Text = "Start Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // getUserData
            // 
            this.getUserData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getUserData.Location = new System.Drawing.Point(2, 29);
            this.getUserData.Name = "getUserData";
            this.getUserData.Size = new System.Drawing.Size(225, 23);
            this.getUserData.TabIndex = 1;
            this.getUserData.Text = "Fetch Data (will hang for a while)";
            this.getUserData.UseVisualStyleBackColor = true;
            this.getUserData.Click += new System.EventHandler(this.getUserData_Click);
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username.Location = new System.Drawing.Point(2, 3);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(225, 20);
            this.username.TabIndex = 0;
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 166);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(543, 204);
            this.Name = "MainDialog";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox UserDataList;
        private System.Windows.Forms.Button SelectNone;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.TextBox DownloadPath;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button getUserData;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

    }
}


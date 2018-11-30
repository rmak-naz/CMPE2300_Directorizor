namespace Lab2_Directorizor
{
    partial class Lab2_Directorizor
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
            this.LV_Directory = new System.Windows.Forms.ListView();
            this.LV_col_fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_col_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_col_Modified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_col_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.B_Directory = new System.Windows.Forms.Button();
            this.DirectoryInfo = new System.Windows.Forms.StatusStrip();
            this.status_directorypath = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_numfiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_dirsize = new System.Windows.Forms.ToolStripStatusLabel();
            this.FBD_Directory = new System.Windows.Forms.FolderBrowserDialog();
            this.DirectoryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Directory
            // 
            this.LV_Directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Directory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LV_col_fileName,
            this.LV_col_Size,
            this.LV_col_Modified,
            this.LV_col_Path});
            this.LV_Directory.FullRowSelect = true;
            this.LV_Directory.GridLines = true;
            this.LV_Directory.HideSelection = false;
            this.LV_Directory.Location = new System.Drawing.Point(13, 13);
            this.LV_Directory.MultiSelect = false;
            this.LV_Directory.Name = "LV_Directory";
            this.LV_Directory.Size = new System.Drawing.Size(651, 379);
            this.LV_Directory.TabIndex = 0;
            this.LV_Directory.UseCompatibleStateImageBehavior = false;
            this.LV_Directory.View = System.Windows.Forms.View.Details;
            this.LV_Directory.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LV_Directory_ColumnClick);
            this.LV_Directory.SelectedIndexChanged += new System.EventHandler(this.LV_Directory_SelectedIndexChanged);
            this.LV_Directory.SizeChanged += new System.EventHandler(this.LV_Directory_SizeChanged);
            // 
            // LV_col_fileName
            // 
            this.LV_col_fileName.Text = "File Name";
            this.LV_col_fileName.Width = 114;
            // 
            // LV_col_Size
            // 
            this.LV_col_Size.Text = "Size (bytes)";
            this.LV_col_Size.Width = 71;
            // 
            // LV_col_Modified
            // 
            this.LV_col_Modified.Text = "Last Modified";
            this.LV_col_Modified.Width = 127;
            // 
            // LV_col_Path
            // 
            this.LV_col_Path.Text = "Path";
            this.LV_col_Path.Width = 335;
            // 
            // B_Directory
            // 
            this.B_Directory.Location = new System.Drawing.Point(13, 399);
            this.B_Directory.Name = "B_Directory";
            this.B_Directory.Size = new System.Drawing.Size(174, 23);
            this.B_Directory.TabIndex = 1;
            this.B_Directory.Text = "Select Directory";
            this.B_Directory.UseVisualStyleBackColor = true;
            this.B_Directory.Click += new System.EventHandler(this.B_Directory_Click);
            // 
            // DirectoryInfo
            // 
            this.DirectoryInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_directorypath,
            this.status_numfiles,
            this.status_dirsize});
            this.DirectoryInfo.Location = new System.Drawing.Point(0, 434);
            this.DirectoryInfo.Name = "DirectoryInfo";
            this.DirectoryInfo.Size = new System.Drawing.Size(676, 22);
            this.DirectoryInfo.TabIndex = 2;
            this.DirectoryInfo.Text = "DirectoryInfo";
            // 
            // status_directorypath
            // 
            this.status_directorypath.Name = "status_directorypath";
            this.status_directorypath.Size = new System.Drawing.Size(425, 17);
            this.status_directorypath.Spring = true;
            this.status_directorypath.Text = "toolStripStatusLabel1";
            // 
            // status_numfiles
            // 
            this.status_numfiles.Name = "status_numfiles";
            this.status_numfiles.Size = new System.Drawing.Size(118, 17);
            this.status_numfiles.Text = "toolStripStatusLabel2";
            // 
            // status_dirsize
            // 
            this.status_dirsize.Name = "status_dirsize";
            this.status_dirsize.Size = new System.Drawing.Size(118, 17);
            this.status_dirsize.Text = "toolStripStatusLabel3";
            // 
            // Lab2_Directorizor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 456);
            this.Controls.Add(this.DirectoryInfo);
            this.Controls.Add(this.B_Directory);
            this.Controls.Add(this.LV_Directory);
            this.Name = "Lab2_Directorizor";
            this.Text = "Directorizor";
            this.DirectoryInfo.ResumeLayout(false);
            this.DirectoryInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_Directory;
        private System.Windows.Forms.Button B_Directory;
        private System.Windows.Forms.StatusStrip DirectoryInfo;
        private System.Windows.Forms.ToolStripStatusLabel status_directorypath;
        private System.Windows.Forms.ToolStripStatusLabel status_numfiles;
        private System.Windows.Forms.ToolStripStatusLabel status_dirsize;
        private System.Windows.Forms.ColumnHeader LV_col_fileName;
        private System.Windows.Forms.ColumnHeader LV_col_Size;
        private System.Windows.Forms.ColumnHeader LV_col_Modified;
        private System.Windows.Forms.ColumnHeader LV_col_Path;
        private System.Windows.Forms.FolderBrowserDialog FBD_Directory;
    }
}


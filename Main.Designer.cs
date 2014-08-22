namespace MusicTagManager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.gbxTag = new System.Windows.Forms.GroupBox();
            this.chkChangeTittle = new System.Windows.Forms.CheckBox();
            this.chkChangeCover = new System.Windows.Forms.CheckBox();
            this.chkChangeAlbumYear = new System.Windows.Forms.CheckBox();
            this.chkChangeAlbumTittle = new System.Windows.Forms.CheckBox();
            this.chkChangeContribArtist = new System.Windows.Forms.CheckBox();
            this.chkChangeArtist = new System.Windows.Forms.CheckBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtContribArtist = new System.Windows.Forms.TextBox();
            this.lblContributingArtist = new System.Windows.Forms.Label();
            this.chkChangeFilename = new System.Windows.Forms.CheckBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblAlbumYear = new System.Windows.Forms.Label();
            this.lblAlbumCover = new System.Windows.Forms.Label();
            this.lblAlbumTittle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fdgPicture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.gbxTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(13, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(361, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(380, 11);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Location = new System.Drawing.Point(4, 39);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(451, 537);
            this.dgvFiles.TabIndex = 8;
            this.dgvFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFiles_KeyDown);
            // 
            // gbxTag
            // 
            this.gbxTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTag.Controls.Add(this.chkChangeTittle);
            this.gbxTag.Controls.Add(this.chkChangeCover);
            this.gbxTag.Controls.Add(this.chkChangeAlbumYear);
            this.gbxTag.Controls.Add(this.chkChangeAlbumTittle);
            this.gbxTag.Controls.Add(this.chkChangeContribArtist);
            this.gbxTag.Controls.Add(this.chkChangeArtist);
            this.gbxTag.Controls.Add(this.lblTip);
            this.gbxTag.Controls.Add(this.txtContribArtist);
            this.gbxTag.Controls.Add(this.lblContributingArtist);
            this.gbxTag.Controls.Add(this.chkChangeFilename);
            this.gbxTag.Controls.Add(this.picCover);
            this.gbxTag.Controls.Add(this.txtYear);
            this.gbxTag.Controls.Add(this.txtAlbum);
            this.gbxTag.Controls.Add(this.txtArtist);
            this.gbxTag.Controls.Add(this.lblAlbumYear);
            this.gbxTag.Controls.Add(this.lblAlbumCover);
            this.gbxTag.Controls.Add(this.lblAlbumTittle);
            this.gbxTag.Controls.Add(this.lblArtist);
            this.gbxTag.Location = new System.Drawing.Point(476, 13);
            this.gbxTag.Name = "gbxTag";
            this.gbxTag.Size = new System.Drawing.Size(242, 568);
            this.gbxTag.TabIndex = 3;
            this.gbxTag.TabStop = false;
            this.gbxTag.Text = "Tags";
            // 
            // chkChangeTittle
            // 
            this.chkChangeTittle.AutoSize = true;
            this.chkChangeTittle.Location = new System.Drawing.Point(19, 435);
            this.chkChangeTittle.Name = "chkChangeTittle";
            this.chkChangeTittle.Size = new System.Drawing.Size(164, 17);
            this.chkChangeTittle.TabIndex = 17;
            this.chkChangeTittle.Text = "Change tittle TAG to filename";
            this.chkChangeTittle.UseVisualStyleBackColor = true;
            // 
            // chkChangeCover
            // 
            this.chkChangeCover.AutoSize = true;
            this.chkChangeCover.Checked = true;
            this.chkChangeCover.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChangeCover.Location = new System.Drawing.Point(90, 146);
            this.chkChangeCover.Name = "chkChangeCover";
            this.chkChangeCover.Size = new System.Drawing.Size(15, 14);
            this.chkChangeCover.TabIndex = 16;
            this.chkChangeCover.UseVisualStyleBackColor = true;
            // 
            // chkChangeAlbumYear
            // 
            this.chkChangeAlbumYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChangeAlbumYear.AutoSize = true;
            this.chkChangeAlbumYear.Checked = true;
            this.chkChangeAlbumYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChangeAlbumYear.Location = new System.Drawing.Point(221, 108);
            this.chkChangeAlbumYear.Name = "chkChangeAlbumYear";
            this.chkChangeAlbumYear.Size = new System.Drawing.Size(15, 14);
            this.chkChangeAlbumYear.TabIndex = 15;
            this.chkChangeAlbumYear.UseVisualStyleBackColor = true;
            // 
            // chkChangeAlbumTittle
            // 
            this.chkChangeAlbumTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChangeAlbumTittle.AutoSize = true;
            this.chkChangeAlbumTittle.Checked = true;
            this.chkChangeAlbumTittle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChangeAlbumTittle.Location = new System.Drawing.Point(221, 83);
            this.chkChangeAlbumTittle.Name = "chkChangeAlbumTittle";
            this.chkChangeAlbumTittle.Size = new System.Drawing.Size(15, 14);
            this.chkChangeAlbumTittle.TabIndex = 14;
            this.chkChangeAlbumTittle.UseVisualStyleBackColor = true;
            // 
            // chkChangeContribArtist
            // 
            this.chkChangeContribArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChangeContribArtist.AutoSize = true;
            this.chkChangeContribArtist.Checked = true;
            this.chkChangeContribArtist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChangeContribArtist.Location = new System.Drawing.Point(221, 57);
            this.chkChangeContribArtist.Name = "chkChangeContribArtist";
            this.chkChangeContribArtist.Size = new System.Drawing.Size(15, 14);
            this.chkChangeContribArtist.TabIndex = 13;
            this.chkChangeContribArtist.UseVisualStyleBackColor = true;
            // 
            // chkChangeArtist
            // 
            this.chkChangeArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChangeArtist.AutoSize = true;
            this.chkChangeArtist.Checked = true;
            this.chkChangeArtist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChangeArtist.Location = new System.Drawing.Point(221, 31);
            this.chkChangeArtist.Name = "chkChangeArtist";
            this.chkChangeArtist.Size = new System.Drawing.Size(15, 14);
            this.chkChangeArtist.TabIndex = 12;
            this.chkChangeArtist.UseVisualStyleBackColor = true;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTip.Location = new System.Drawing.Point(16, 540);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(198, 13);
            this.lblTip.TabIndex = 11;
            this.lblTip.Text = "TIP: You can edit track number and tittle";
            // 
            // txtContribArtist
            // 
            this.txtContribArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContribArtist.Location = new System.Drawing.Point(84, 54);
            this.txtContribArtist.Name = "txtContribArtist";
            this.txtContribArtist.Size = new System.Drawing.Size(131, 20);
            this.txtContribArtist.TabIndex = 2;
            // 
            // lblContributingArtist
            // 
            this.lblContributingArtist.AutoSize = true;
            this.lblContributingArtist.Location = new System.Drawing.Point(16, 57);
            this.lblContributingArtist.Name = "lblContributingArtist";
            this.lblContributingArtist.Size = new System.Drawing.Size(69, 13);
            this.lblContributingArtist.TabIndex = 9;
            this.lblContributingArtist.Text = "Contrib. Artist";
            // 
            // chkChangeFilename
            // 
            this.chkChangeFilename.AutoSize = true;
            this.chkChangeFilename.Location = new System.Drawing.Point(19, 412);
            this.chkChangeFilename.Name = "chkChangeFilename";
            this.chkChangeFilename.Size = new System.Drawing.Size(164, 17);
            this.chkChangeFilename.TabIndex = 5;
            this.chkChangeFilename.Text = "Change filename to tittle TAG";
            this.chkChangeFilename.UseVisualStyleBackColor = true;
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(17, 162);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(206, 231);
            this.picCover.TabIndex = 7;
            this.picCover.TabStop = false;
            this.picCover.Click += new System.EventHandler(this.picCover_Click);
            // 
            // txtYear
            // 
            this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYear.Location = new System.Drawing.Point(84, 105);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(131, 20);
            this.txtYear.TabIndex = 4;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlbum.Location = new System.Drawing.Point(84, 80);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(131, 20);
            this.txtAlbum.TabIndex = 3;
            // 
            // txtArtist
            // 
            this.txtArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtist.Location = new System.Drawing.Point(52, 28);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(163, 20);
            this.txtArtist.TabIndex = 1;
            // 
            // lblAlbumYear
            // 
            this.lblAlbumYear.AutoSize = true;
            this.lblAlbumYear.Location = new System.Drawing.Point(17, 108);
            this.lblAlbumYear.Name = "lblAlbumYear";
            this.lblAlbumYear.Size = new System.Drawing.Size(61, 13);
            this.lblAlbumYear.TabIndex = 3;
            this.lblAlbumYear.Text = "Album Year";
            // 
            // lblAlbumCover
            // 
            this.lblAlbumCover.AutoSize = true;
            this.lblAlbumCover.Location = new System.Drawing.Point(17, 146);
            this.lblAlbumCover.Name = "lblAlbumCover";
            this.lblAlbumCover.Size = new System.Drawing.Size(67, 13);
            this.lblAlbumCover.TabIndex = 2;
            this.lblAlbumCover.Text = "Album Cover";
            // 
            // lblAlbumTittle
            // 
            this.lblAlbumTittle.AutoSize = true;
            this.lblAlbumTittle.Location = new System.Drawing.Point(16, 83);
            this.lblAlbumTittle.Name = "lblAlbumTittle";
            this.lblAlbumTittle.Size = new System.Drawing.Size(62, 13);
            this.lblAlbumTittle.TabIndex = 1;
            this.lblAlbumTittle.Text = "Album Tittle";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(16, 31);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(30, 13);
            this.lblArtist.TabIndex = 0;
            this.lblArtist.Text = "Artist";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(567, 593);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(648, 593);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 621);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbxTag);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(746, 660);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Tag Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.gbxTag.ResumeLayout(false);
            this.gbxTag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.GroupBox gbxTag;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAlbumTittle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbumYear;
        private System.Windows.Forms.Label lblAlbumCover;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.OpenFileDialog fdgPicture;
        private System.Windows.Forms.CheckBox chkChangeFilename;
        private System.Windows.Forms.TextBox txtContribArtist;
        private System.Windows.Forms.Label lblContributingArtist;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.CheckBox chkChangeAlbumYear;
        private System.Windows.Forms.CheckBox chkChangeAlbumTittle;
        private System.Windows.Forms.CheckBox chkChangeContribArtist;
        private System.Windows.Forms.CheckBox chkChangeArtist;
        private System.Windows.Forms.CheckBox chkChangeCover;
        private System.Windows.Forms.CheckBox chkChangeTittle;
    }
}


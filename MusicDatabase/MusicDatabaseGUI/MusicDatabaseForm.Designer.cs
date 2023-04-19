namespace MusicDatabaseGUI
{
    partial class MusicDatabaseForm
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
            this.uxSongsList = new System.Windows.Forms.ListBox();
            this.uxAddSongButton = new System.Windows.Forms.Button();
            this.uxSongsLabel = new System.Windows.Forms.Label();
            this.uxSongTextBox = new System.Windows.Forms.TextBox();
            this.uxArtistsLabel = new System.Windows.Forms.Label();
            this.uxAlbumsLabel = new System.Windows.Forms.Label();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxEditArtistButton = new System.Windows.Forms.Button();
            this.uxSearchSongButton = new System.Windows.Forms.Button();
            this.uxAddAlbumButton = new System.Windows.Forms.Button();
            this.uxAlbumList = new System.Windows.Forms.ComboBox();
            this.uxArtistList = new System.Windows.Forms.ComboBox();
            this.uxGenreList = new System.Windows.Forms.ComboBox();
            this.uxAddArtistButton = new System.Windows.Forms.Button();
            this.uxDisplayOptions = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uxDisplayOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSongsList
            // 
            this.uxSongsList.FormattingEnabled = true;
            this.uxSongsList.ItemHeight = 16;
            this.uxSongsList.Location = new System.Drawing.Point(12, 85);
            this.uxSongsList.Name = "uxSongsList";
            this.uxSongsList.Size = new System.Drawing.Size(200, 356);
            this.uxSongsList.TabIndex = 0;
            // 
            // uxAddSongButton
            // 
            this.uxAddSongButton.Location = new System.Drawing.Point(117, 53);
            this.uxAddSongButton.Name = "uxAddSongButton";
            this.uxAddSongButton.Size = new System.Drawing.Size(95, 29);
            this.uxAddSongButton.TabIndex = 1;
            this.uxAddSongButton.Text = "Add Song";
            this.uxAddSongButton.UseVisualStyleBackColor = true;
            this.uxAddSongButton.Click += new System.EventHandler(this.AddItem);
            // 
            // uxSongsLabel
            // 
            this.uxSongsLabel.AutoSize = true;
            this.uxSongsLabel.Location = new System.Drawing.Point(12, 9);
            this.uxSongsLabel.Name = "uxSongsLabel";
            this.uxSongsLabel.Size = new System.Drawing.Size(46, 16);
            this.uxSongsLabel.TabIndex = 2;
            this.uxSongsLabel.Text = "Songs";
            // 
            // uxSongTextBox
            // 
            this.uxSongTextBox.Location = new System.Drawing.Point(12, 28);
            this.uxSongTextBox.Name = "uxSongTextBox";
            this.uxSongTextBox.Size = new System.Drawing.Size(200, 22);
            this.uxSongTextBox.TabIndex = 7;
            // 
            // uxArtistsLabel
            // 
            this.uxArtistsLabel.AutoSize = true;
            this.uxArtistsLabel.Location = new System.Drawing.Point(6, 73);
            this.uxArtistsLabel.Name = "uxArtistsLabel";
            this.uxArtistsLabel.Size = new System.Drawing.Size(36, 16);
            this.uxArtistsLabel.TabIndex = 8;
            this.uxArtistsLabel.Text = "Artist";
            // 
            // uxAlbumsLabel
            // 
            this.uxAlbumsLabel.AutoSize = true;
            this.uxAlbumsLabel.Location = new System.Drawing.Point(6, 22);
            this.uxAlbumsLabel.Name = "uxAlbumsLabel";
            this.uxAlbumsLabel.Size = new System.Drawing.Size(45, 16);
            this.uxAlbumsLabel.TabIndex = 9;
            this.uxAlbumsLabel.Text = "Album";
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Location = new System.Drawing.Point(6, 124);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(44, 16);
            this.uxGenreLabel.TabIndex = 10;
            this.uxGenreLabel.Text = "Genre";
            // 
            // uxEditArtistButton
            // 
            this.uxEditArtistButton.Location = new System.Drawing.Point(107, 92);
            this.uxEditArtistButton.Name = "uxEditArtistButton";
            this.uxEditArtistButton.Size = new System.Drawing.Size(95, 26);
            this.uxEditArtistButton.TabIndex = 15;
            this.uxEditArtistButton.Text = "Edit Artist";
            this.uxEditArtistButton.UseVisualStyleBackColor = true;
            // 
            // uxSearchSongButton
            // 
            this.uxSearchSongButton.Location = new System.Drawing.Point(11, 53);
            this.uxSearchSongButton.Name = "uxSearchSongButton";
            this.uxSearchSongButton.Size = new System.Drawing.Size(95, 29);
            this.uxSearchSongButton.TabIndex = 16;
            this.uxSearchSongButton.Text = "Search";
            this.uxSearchSongButton.UseVisualStyleBackColor = true;
            this.uxSearchSongButton.Click += new System.EventHandler(this.uxSearchSongButton_Click);
            // 
            // uxAddAlbumButton
            // 
            this.uxAddAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddAlbumButton.Location = new System.Drawing.Point(6, 41);
            this.uxAddAlbumButton.Name = "uxAddAlbumButton";
            this.uxAddAlbumButton.Size = new System.Drawing.Size(95, 26);
            this.uxAddAlbumButton.TabIndex = 18;
            this.uxAddAlbumButton.Text = "Add Album";
            this.uxAddAlbumButton.UseVisualStyleBackColor = true;
            this.uxAddAlbumButton.Click += new System.EventHandler(this.AddItem);
            // 
            // uxAlbumList
            // 
            this.uxAlbumList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxAlbumList.FormattingEnabled = true;
            this.uxAlbumList.Location = new System.Drawing.Point(6, 41);
            this.uxAlbumList.Name = "uxAlbumList";
            this.uxAlbumList.Size = new System.Drawing.Size(121, 24);
            this.uxAlbumList.TabIndex = 22;
            // 
            // uxArtistList
            // 
            this.uxArtistList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxArtistList.FormattingEnabled = true;
            this.uxArtistList.Location = new System.Drawing.Point(6, 92);
            this.uxArtistList.Name = "uxArtistList";
            this.uxArtistList.Size = new System.Drawing.Size(121, 24);
            this.uxArtistList.TabIndex = 23;
            // 
            // uxGenreList
            // 
            this.uxGenreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGenreList.FormattingEnabled = true;
            this.uxGenreList.Location = new System.Drawing.Point(6, 143);
            this.uxGenreList.Name = "uxGenreList";
            this.uxGenreList.Size = new System.Drawing.Size(121, 24);
            this.uxGenreList.TabIndex = 24;
            // 
            // uxAddArtistButton
            // 
            this.uxAddArtistButton.Location = new System.Drawing.Point(6, 92);
            this.uxAddArtistButton.Name = "uxAddArtistButton";
            this.uxAddArtistButton.Size = new System.Drawing.Size(95, 26);
            this.uxAddArtistButton.TabIndex = 25;
            this.uxAddArtistButton.Text = "Add Artist";
            this.uxAddArtistButton.UseVisualStyleBackColor = true;
            this.uxAddArtistButton.Click += new System.EventHandler(this.AddItem);
            // 
            // uxDisplayOptions
            // 
            this.uxDisplayOptions.Controls.Add(this.uxAlbumList);
            this.uxDisplayOptions.Controls.Add(this.uxAlbumsLabel);
            this.uxDisplayOptions.Controls.Add(this.uxGenreList);
            this.uxDisplayOptions.Controls.Add(this.uxArtistsLabel);
            this.uxDisplayOptions.Controls.Add(this.uxArtistList);
            this.uxDisplayOptions.Controls.Add(this.uxGenreLabel);
            this.uxDisplayOptions.Location = new System.Drawing.Point(218, 12);
            this.uxDisplayOptions.Name = "uxDisplayOptions";
            this.uxDisplayOptions.Size = new System.Drawing.Size(237, 188);
            this.uxDisplayOptions.TabIndex = 26;
            this.uxDisplayOptions.TabStop = false;
            this.uxDisplayOptions.Text = "Song Display Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uxAddAlbumButton);
            this.groupBox2.Controls.Add(this.uxAddArtistButton);
            this.groupBox2.Controls.Add(this.uxEditArtistButton);
            this.groupBox2.Location = new System.Drawing.Point(461, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 188);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add / Edit Other Items";
            // 
            // MusicDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.uxDisplayOptions);
            this.Controls.Add(this.uxSearchSongButton);
            this.Controls.Add(this.uxSongTextBox);
            this.Controls.Add(this.uxSongsLabel);
            this.Controls.Add(this.uxAddSongButton);
            this.Controls.Add(this.uxSongsList);
            this.Name = "MusicDatabaseForm";
            this.Text = "Music Database";
            this.uxDisplayOptions.ResumeLayout(false);
            this.uxDisplayOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxSongsList;
        private System.Windows.Forms.Button uxAddSongButton;
        private System.Windows.Forms.Label uxSongsLabel;
        private System.Windows.Forms.TextBox uxSongTextBox;
        private System.Windows.Forms.Label uxArtistsLabel;
        private System.Windows.Forms.Label uxAlbumsLabel;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.Button uxEditArtistButton;
        private System.Windows.Forms.Button uxSearchSongButton;
        private System.Windows.Forms.Button uxAddAlbumButton;
        private System.Windows.Forms.ComboBox uxAlbumList;
        private System.Windows.Forms.ComboBox uxArtistList;
        private System.Windows.Forms.ComboBox uxGenreList;
        private System.Windows.Forms.Button uxAddArtistButton;
        private System.Windows.Forms.GroupBox uxDisplayOptions;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


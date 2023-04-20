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
            this.uxSearchSongButton = new System.Windows.Forms.Button();
            this.uxAddAlbumButton = new System.Windows.Forms.Button();
            this.uxAlbumList = new System.Windows.Forms.ComboBox();
            this.uxArtistList = new System.Windows.Forms.ComboBox();
            this.uxGenreList = new System.Windows.Forms.ComboBox();
            this.uxAddArtistButton = new System.Windows.Forms.Button();
            this.uxDisplayOptions = new System.Windows.Forms.GroupBox();
            this.uxAddEditButtons = new System.Windows.Forms.GroupBox();
            this.uxSearchOptions = new System.Windows.Forms.GroupBox();
            this.uxSpotifyListensOutput = new System.Windows.Forms.TextBox();
            this.uxSongInfo = new System.Windows.Forms.GroupBox();
            this.uxSpotifyListensLabel = new System.Windows.Forms.Label();
            this.uxSongArtistLabel = new System.Windows.Forms.Label();
            this.uxSongArtistOutput = new System.Windows.Forms.TextBox();
            this.uxSongAlbumLabel = new System.Windows.Forms.Label();
            this.uxSongAlbumOutput = new System.Windows.Forms.TextBox();
            this.uxSongGenreLabel = new System.Windows.Forms.Label();
            this.uxSongGenreOutput = new System.Windows.Forms.TextBox();
            this.uxSpotifyListensInputLabel = new System.Windows.Forms.Label();
            this.uxBillboardWeeksInputLabel = new System.Windows.Forms.Label();
            this.uxAlbumBillboardOutput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxReleaseDateInputLabel = new System.Windows.Forms.Label();
            this.uxReleaseDateInput = new System.Windows.Forms.DateTimePicker();
            this.uxSearchListensButton = new System.Windows.Forms.Button();
            this.uxSpotifyListensInput = new System.Windows.Forms.NumericUpDown();
            this.uxBillboardWeeksInput = new System.Windows.Forms.NumericUpDown();
            this.uxSearchWeeksButton = new System.Windows.Forms.Button();
            this.uxSearchDateButton = new System.Windows.Forms.Button();
            this.uxDisplayOptions.SuspendLayout();
            this.uxAddEditButtons.SuspendLayout();
            this.uxSearchOptions.SuspendLayout();
            this.uxSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSpotifyListensInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBillboardWeeksInput)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSongsList
            // 
            this.uxSongsList.FormattingEnabled = true;
            this.uxSongsList.ItemHeight = 16;
            this.uxSongsList.Location = new System.Drawing.Point(12, 85);
            this.uxSongsList.Name = "uxSongsList";
            this.uxSongsList.Size = new System.Drawing.Size(200, 372);
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
            this.uxAlbumList.SelectedIndexChanged += new System.EventHandler(this.uxAlbumList_SelectedIndexChanged);
            // 
            // uxArtistList
            // 
            this.uxArtistList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxArtistList.FormattingEnabled = true;
            this.uxArtistList.Location = new System.Drawing.Point(6, 92);
            this.uxArtistList.Name = "uxArtistList";
            this.uxArtistList.Size = new System.Drawing.Size(121, 24);
            this.uxArtistList.TabIndex = 23;
            this.uxArtistList.SelectedIndexChanged += new System.EventHandler(this.uxArtistList_SelectedIndexChanged);
            // 
            // uxGenreList
            // 
            this.uxGenreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGenreList.FormattingEnabled = true;
            this.uxGenreList.Location = new System.Drawing.Point(6, 143);
            this.uxGenreList.Name = "uxGenreList";
            this.uxGenreList.Size = new System.Drawing.Size(121, 24);
            this.uxGenreList.TabIndex = 24;
            this.uxGenreList.SelectedIndexChanged += new System.EventHandler(this.uxGenreList_SelectedIndexChanged);
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
            // uxAddEditButtons
            // 
            this.uxAddEditButtons.Controls.Add(this.uxAddAlbumButton);
            this.uxAddEditButtons.Controls.Add(this.uxAddArtistButton);
            this.uxAddEditButtons.Location = new System.Drawing.Point(461, 12);
            this.uxAddEditButtons.Name = "uxAddEditButtons";
            this.uxAddEditButtons.Size = new System.Drawing.Size(209, 188);
            this.uxAddEditButtons.TabIndex = 27;
            this.uxAddEditButtons.TabStop = false;
            this.uxAddEditButtons.Text = "Add / Edit Items";
            // 
            // uxSearchOptions
            // 
            this.uxSearchOptions.Controls.Add(this.uxSearchDateButton);
            this.uxSearchOptions.Controls.Add(this.uxSearchWeeksButton);
            this.uxSearchOptions.Controls.Add(this.uxBillboardWeeksInput);
            this.uxSearchOptions.Controls.Add(this.uxSpotifyListensInput);
            this.uxSearchOptions.Controls.Add(this.uxSearchListensButton);
            this.uxSearchOptions.Controls.Add(this.uxReleaseDateInput);
            this.uxSearchOptions.Controls.Add(this.uxReleaseDateInputLabel);
            this.uxSearchOptions.Controls.Add(this.uxBillboardWeeksInputLabel);
            this.uxSearchOptions.Controls.Add(this.uxSpotifyListensInputLabel);
            this.uxSearchOptions.Location = new System.Drawing.Point(461, 206);
            this.uxSearchOptions.Name = "uxSearchOptions";
            this.uxSearchOptions.Size = new System.Drawing.Size(209, 251);
            this.uxSearchOptions.TabIndex = 28;
            this.uxSearchOptions.TabStop = false;
            this.uxSearchOptions.Text = "Other Search Types";
            // 
            // uxSpotifyListensOutput
            // 
            this.uxSpotifyListensOutput.Enabled = false;
            this.uxSpotifyListensOutput.Location = new System.Drawing.Point(9, 41);
            this.uxSpotifyListensOutput.Name = "uxSpotifyListensOutput";
            this.uxSpotifyListensOutput.Size = new System.Drawing.Size(208, 22);
            this.uxSpotifyListensOutput.TabIndex = 29;
            // 
            // uxSongInfo
            // 
            this.uxSongInfo.Controls.Add(this.uxAlbumBillboardOutput);
            this.uxSongInfo.Controls.Add(this.textBox1);
            this.uxSongInfo.Controls.Add(this.uxSongGenreLabel);
            this.uxSongInfo.Controls.Add(this.uxSongGenreOutput);
            this.uxSongInfo.Controls.Add(this.uxSongAlbumLabel);
            this.uxSongInfo.Controls.Add(this.uxSongAlbumOutput);
            this.uxSongInfo.Controls.Add(this.uxSongArtistLabel);
            this.uxSongInfo.Controls.Add(this.uxSongArtistOutput);
            this.uxSongInfo.Controls.Add(this.uxSpotifyListensLabel);
            this.uxSongInfo.Controls.Add(this.uxSpotifyListensOutput);
            this.uxSongInfo.Location = new System.Drawing.Point(218, 206);
            this.uxSongInfo.Name = "uxSongInfo";
            this.uxSongInfo.Size = new System.Drawing.Size(237, 251);
            this.uxSongInfo.TabIndex = 30;
            this.uxSongInfo.TabStop = false;
            this.uxSongInfo.Text = "Song Info";
            // 
            // uxSpotifyListensLabel
            // 
            this.uxSpotifyListensLabel.AutoSize = true;
            this.uxSpotifyListensLabel.Location = new System.Drawing.Point(6, 22);
            this.uxSpotifyListensLabel.Name = "uxSpotifyListensLabel";
            this.uxSpotifyListensLabel.Size = new System.Drawing.Size(93, 16);
            this.uxSpotifyListensLabel.TabIndex = 30;
            this.uxSpotifyListensLabel.Text = "Spotify Listens";
            // 
            // uxSongArtistLabel
            // 
            this.uxSongArtistLabel.AutoSize = true;
            this.uxSongArtistLabel.Location = new System.Drawing.Point(6, 65);
            this.uxSongArtistLabel.Name = "uxSongArtistLabel";
            this.uxSongArtistLabel.Size = new System.Drawing.Size(36, 16);
            this.uxSongArtistLabel.TabIndex = 32;
            this.uxSongArtistLabel.Text = "Artist";
            // 
            // uxSongArtistOutput
            // 
            this.uxSongArtistOutput.Enabled = false;
            this.uxSongArtistOutput.Location = new System.Drawing.Point(9, 84);
            this.uxSongArtistOutput.Name = "uxSongArtistOutput";
            this.uxSongArtistOutput.Size = new System.Drawing.Size(208, 22);
            this.uxSongArtistOutput.TabIndex = 31;
            // 
            // uxSongAlbumLabel
            // 
            this.uxSongAlbumLabel.AutoSize = true;
            this.uxSongAlbumLabel.Location = new System.Drawing.Point(6, 112);
            this.uxSongAlbumLabel.Name = "uxSongAlbumLabel";
            this.uxSongAlbumLabel.Size = new System.Drawing.Size(45, 16);
            this.uxSongAlbumLabel.TabIndex = 34;
            this.uxSongAlbumLabel.Text = "Album";
            // 
            // uxSongAlbumOutput
            // 
            this.uxSongAlbumOutput.Enabled = false;
            this.uxSongAlbumOutput.Location = new System.Drawing.Point(9, 131);
            this.uxSongAlbumOutput.Name = "uxSongAlbumOutput";
            this.uxSongAlbumOutput.Size = new System.Drawing.Size(208, 22);
            this.uxSongAlbumOutput.TabIndex = 33;
            // 
            // uxSongGenreLabel
            // 
            this.uxSongGenreLabel.AutoSize = true;
            this.uxSongGenreLabel.Location = new System.Drawing.Point(6, 157);
            this.uxSongGenreLabel.Name = "uxSongGenreLabel";
            this.uxSongGenreLabel.Size = new System.Drawing.Size(44, 16);
            this.uxSongGenreLabel.TabIndex = 36;
            this.uxSongGenreLabel.Text = "Genre";
            // 
            // uxSongGenreOutput
            // 
            this.uxSongGenreOutput.Enabled = false;
            this.uxSongGenreOutput.Location = new System.Drawing.Point(9, 176);
            this.uxSongGenreOutput.Name = "uxSongGenreOutput";
            this.uxSongGenreOutput.Size = new System.Drawing.Size(208, 22);
            this.uxSongGenreOutput.TabIndex = 35;
            // 
            // uxSpotifyListensInputLabel
            // 
            this.uxSpotifyListensInputLabel.AutoSize = true;
            this.uxSpotifyListensInputLabel.Location = new System.Drawing.Point(6, 22);
            this.uxSpotifyListensInputLabel.Name = "uxSpotifyListensInputLabel";
            this.uxSpotifyListensInputLabel.Size = new System.Drawing.Size(167, 16);
            this.uxSpotifyListensInputLabel.TabIndex = 0;
            this.uxSpotifyListensInputLabel.Text = "Search by # Spotify Listens";
            // 
            // uxBillboardWeeksInputLabel
            // 
            this.uxBillboardWeeksInputLabel.AutoSize = true;
            this.uxBillboardWeeksInputLabel.Location = new System.Drawing.Point(6, 66);
            this.uxBillboardWeeksInputLabel.Name = "uxBillboardWeeksInputLabel";
            this.uxBillboardWeeksInputLabel.Size = new System.Drawing.Size(182, 16);
            this.uxBillboardWeeksInputLabel.TabIndex = 1;
            this.uxBillboardWeeksInputLabel.Text = "Search By # Billboard Weeks";
            // 
            // uxAlbumBillboardOutput
            // 
            this.uxAlbumBillboardOutput.AutoSize = true;
            this.uxAlbumBillboardOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlbumBillboardOutput.Location = new System.Drawing.Point(6, 203);
            this.uxAlbumBillboardOutput.Name = "uxAlbumBillboardOutput";
            this.uxAlbumBillboardOutput.Size = new System.Drawing.Size(224, 16);
            this.uxAlbumBillboardOutput.TabIndex = 38;
            this.uxAlbumBillboardOutput.Text = "Billboard Longest Consecutive Weeks";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(9, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 37;
            // 
            // uxReleaseDateInputLabel
            // 
            this.uxReleaseDateInputLabel.AutoSize = true;
            this.uxReleaseDateInputLabel.Location = new System.Drawing.Point(6, 157);
            this.uxReleaseDateInputLabel.Name = "uxReleaseDateInputLabel";
            this.uxReleaseDateInputLabel.Size = new System.Drawing.Size(155, 16);
            this.uxReleaseDateInputLabel.TabIndex = 2;
            this.uxReleaseDateInputLabel.Text = "Search by Release Date";
            // 
            // uxReleaseDateInput
            // 
            this.uxReleaseDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uxReleaseDateInput.Location = new System.Drawing.Point(9, 176);
            this.uxReleaseDateInput.Name = "uxReleaseDateInput";
            this.uxReleaseDateInput.Size = new System.Drawing.Size(191, 22);
            this.uxReleaseDateInput.TabIndex = 5;
            // 
            // uxSearchListensButton
            // 
            this.uxSearchListensButton.Location = new System.Drawing.Point(135, 40);
            this.uxSearchListensButton.Name = "uxSearchListensButton";
            this.uxSearchListensButton.Size = new System.Drawing.Size(67, 23);
            this.uxSearchListensButton.TabIndex = 6;
            this.uxSearchListensButton.Text = "Search";
            this.uxSearchListensButton.UseVisualStyleBackColor = true;
            this.uxSearchListensButton.Click += new System.EventHandler(this.uxSearchByButton_Click);
            // 
            // uxSpotifyListensInput
            // 
            this.uxSpotifyListensInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uxSpotifyListensInput.Location = new System.Drawing.Point(9, 41);
            this.uxSpotifyListensInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.uxSpotifyListensInput.Name = "uxSpotifyListensInput";
            this.uxSpotifyListensInput.Size = new System.Drawing.Size(120, 22);
            this.uxSpotifyListensInput.TabIndex = 7;
            // 
            // uxBillboardWeeksInput
            // 
            this.uxBillboardWeeksInput.Location = new System.Drawing.Point(9, 87);
            this.uxBillboardWeeksInput.Name = "uxBillboardWeeksInput";
            this.uxBillboardWeeksInput.Size = new System.Drawing.Size(120, 22);
            this.uxBillboardWeeksInput.TabIndex = 8;
            // 
            // uxSearchWeeksButton
            // 
            this.uxSearchWeeksButton.Location = new System.Drawing.Point(135, 86);
            this.uxSearchWeeksButton.Name = "uxSearchWeeksButton";
            this.uxSearchWeeksButton.Size = new System.Drawing.Size(67, 23);
            this.uxSearchWeeksButton.TabIndex = 9;
            this.uxSearchWeeksButton.Text = "Search";
            this.uxSearchWeeksButton.UseVisualStyleBackColor = true;
            this.uxSearchWeeksButton.Click += new System.EventHandler(this.uxSearchWeeksButton_Click);
            // 
            // uxSearchDateButton
            // 
            this.uxSearchDateButton.Location = new System.Drawing.Point(9, 199);
            this.uxSearchDateButton.Name = "uxSearchDateButton";
            this.uxSearchDateButton.Size = new System.Drawing.Size(191, 23);
            this.uxSearchDateButton.TabIndex = 10;
            this.uxSearchDateButton.Text = "Search";
            this.uxSearchDateButton.UseVisualStyleBackColor = true;
            this.uxSearchDateButton.Click += new System.EventHandler(this.uxSearchDateButton_Click);
            // 
            // MusicDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 465);
            this.Controls.Add(this.uxSongInfo);
            this.Controls.Add(this.uxSearchOptions);
            this.Controls.Add(this.uxAddEditButtons);
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
            this.uxAddEditButtons.ResumeLayout(false);
            this.uxSearchOptions.ResumeLayout(false);
            this.uxSearchOptions.PerformLayout();
            this.uxSongInfo.ResumeLayout(false);
            this.uxSongInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSpotifyListensInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBillboardWeeksInput)).EndInit();
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
        private System.Windows.Forms.Button uxSearchSongButton;
        private System.Windows.Forms.Button uxAddAlbumButton;
        private System.Windows.Forms.ComboBox uxAlbumList;
        private System.Windows.Forms.ComboBox uxArtistList;
        private System.Windows.Forms.ComboBox uxGenreList;
        private System.Windows.Forms.Button uxAddArtistButton;
        private System.Windows.Forms.GroupBox uxDisplayOptions;
        private System.Windows.Forms.GroupBox uxAddEditButtons;
        private System.Windows.Forms.GroupBox uxSearchOptions;
        private System.Windows.Forms.TextBox uxSpotifyListensOutput;
        private System.Windows.Forms.GroupBox uxSongInfo;
        private System.Windows.Forms.Label uxSpotifyListensLabel;
        private System.Windows.Forms.Label uxSongArtistLabel;
        private System.Windows.Forms.TextBox uxSongArtistOutput;
        private System.Windows.Forms.Label uxSongAlbumLabel;
        private System.Windows.Forms.TextBox uxSongAlbumOutput;
        private System.Windows.Forms.Label uxSongGenreLabel;
        private System.Windows.Forms.TextBox uxSongGenreOutput;
        private System.Windows.Forms.Label uxBillboardWeeksInputLabel;
        private System.Windows.Forms.Label uxSpotifyListensInputLabel;
        private System.Windows.Forms.Label uxAlbumBillboardOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker uxReleaseDateInput;
        private System.Windows.Forms.Label uxReleaseDateInputLabel;
        private System.Windows.Forms.Button uxSearchListensButton;
        private System.Windows.Forms.NumericUpDown uxSpotifyListensInput;
        private System.Windows.Forms.NumericUpDown uxBillboardWeeksInput;
        private System.Windows.Forms.Button uxSearchWeeksButton;
        private System.Windows.Forms.Button uxSearchDateButton;
    }
}


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
            this.uxClearSearchSongButton = new System.Windows.Forms.Button();
            this.uxAddAlbumButton = new System.Windows.Forms.Button();
            this.uxAlbumList = new System.Windows.Forms.ComboBox();
            this.uxArtistList = new System.Windows.Forms.ComboBox();
            this.uxGenreList = new System.Windows.Forms.ComboBox();
            this.uxAddArtistButton = new System.Windows.Forms.Button();
            this.uxDisplayOptions = new System.Windows.Forms.GroupBox();
            this.uxAddEditButtons = new System.Windows.Forms.GroupBox();
            this.uxSearchOptions = new System.Windows.Forms.GroupBox();
            this.uxSearchDateButton = new System.Windows.Forms.Button();
            this.uxSearchWeeksButton = new System.Windows.Forms.Button();
            this.uxBillboardWeeksInput = new System.Windows.Forms.NumericUpDown();
            this.uxSpotifyListensInput = new System.Windows.Forms.NumericUpDown();
            this.uxSearchListensButton = new System.Windows.Forms.Button();
            this.uxReleaseDateInput = new System.Windows.Forms.DateTimePicker();
            this.uxReleaseDateInputLabel = new System.Windows.Forms.Label();
            this.uxBillboardWeeksInputLabel = new System.Windows.Forms.Label();
            this.uxSpotifyListensInputLabel = new System.Windows.Forms.Label();
            this.uxSpotifyListensOutput = new System.Windows.Forms.TextBox();
            this.uxSongInfo = new System.Windows.Forms.GroupBox();
            this.uxAlbumBillboardOutput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxSongGenreLabel = new System.Windows.Forms.Label();
            this.uxSongGenreOutput = new System.Windows.Forms.TextBox();
            this.uxSongAlbumLabel = new System.Windows.Forms.Label();
            this.uxSongAlbumOutput = new System.Windows.Forms.TextBox();
            this.uxSongArtistLabel = new System.Windows.Forms.Label();
            this.uxSongArtistOutput = new System.Windows.Forms.TextBox();
            this.uxSpotifyListensLabel = new System.Windows.Forms.Label();
            this.uxAlbumYearInput = new System.Windows.Forms.DateTimePicker();
            this.uxSearchByItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxUseDateCheckBox = new System.Windows.Forms.CheckBox();
            this.uxDisplayOptions.SuspendLayout();
            this.uxAddEditButtons.SuspendLayout();
            this.uxSearchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxBillboardWeeksInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSpotifyListensInput)).BeginInit();
            this.uxSongInfo.SuspendLayout();
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
            this.uxSongsList.SelectedIndexChanged += new System.EventHandler(this.uxSongsList_SelectedIndexChanged);
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
            this.uxSongTextBox.TextChanged += new System.EventHandler(this.uxSongTextBox_TextChanged);
            // 
            // uxArtistsLabel
            // 
            this.uxArtistsLabel.AutoSize = true;
            this.uxArtistsLabel.Location = new System.Drawing.Point(6, 73);
            this.uxArtistsLabel.Name = "uxArtistsLabel";
            this.uxArtistsLabel.Size = new System.Drawing.Size(55, 16);
            this.uxArtistsLabel.TabIndex = 8;
            this.uxArtistsLabel.Text = "By Artist";
            // 
            // uxAlbumsLabel
            // 
            this.uxAlbumsLabel.AutoSize = true;
            this.uxAlbumsLabel.Location = new System.Drawing.Point(6, 22);
            this.uxAlbumsLabel.Name = "uxAlbumsLabel";
            this.uxAlbumsLabel.Size = new System.Drawing.Size(64, 16);
            this.uxAlbumsLabel.TabIndex = 9;
            this.uxAlbumsLabel.Text = "By Album";
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Location = new System.Drawing.Point(6, 124);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(63, 16);
            this.uxGenreLabel.TabIndex = 10;
            this.uxGenreLabel.Text = "By Genre";
            // 
            // uxClearSearchSongButton
            // 
            this.uxClearSearchSongButton.Location = new System.Drawing.Point(11, 53);
            this.uxClearSearchSongButton.Name = "uxClearSearchSongButton";
            this.uxClearSearchSongButton.Size = new System.Drawing.Size(95, 29);
            this.uxClearSearchSongButton.TabIndex = 16;
            this.uxClearSearchSongButton.Text = "Clear Search";
            this.uxClearSearchSongButton.UseVisualStyleBackColor = true;
            this.uxClearSearchSongButton.Click += new System.EventHandler(this.uxClearSearchButton_Click);
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
            this.uxArtistList.Enabled = false;
            this.uxArtistList.FormattingEnabled = true;
            this.uxArtistList.Location = new System.Drawing.Point(6, 92);
            this.uxArtistList.Name = "uxArtistList";
            this.uxArtistList.Size = new System.Drawing.Size(121, 24);
            this.uxArtistList.TabIndex = 23;
            // 
            // uxGenreList
            // 
            this.uxGenreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGenreList.Enabled = false;
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
            this.uxDisplayOptions.Controls.Add(this.uxUseDateCheckBox);
            this.uxDisplayOptions.Controls.Add(this.label1);
            this.uxDisplayOptions.Controls.Add(this.uxSearchByItems);
            this.uxDisplayOptions.Controls.Add(this.uxAlbumYearInput);
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
            // uxSearchDateButton
            // 
            this.uxSearchDateButton.Enabled = false;
            this.uxSearchDateButton.Location = new System.Drawing.Point(9, 199);
            this.uxSearchDateButton.Name = "uxSearchDateButton";
            this.uxSearchDateButton.Size = new System.Drawing.Size(191, 23);
            this.uxSearchDateButton.TabIndex = 10;
            this.uxSearchDateButton.Text = "Search";
            this.uxSearchDateButton.UseVisualStyleBackColor = true;
            this.uxSearchDateButton.Click += new System.EventHandler(this.uxSearchDateButton_Click);
            // 
            // uxSearchWeeksButton
            // 
            this.uxSearchWeeksButton.Enabled = false;
            this.uxSearchWeeksButton.Location = new System.Drawing.Point(135, 86);
            this.uxSearchWeeksButton.Name = "uxSearchWeeksButton";
            this.uxSearchWeeksButton.Size = new System.Drawing.Size(67, 23);
            this.uxSearchWeeksButton.TabIndex = 9;
            this.uxSearchWeeksButton.Text = "Search";
            this.uxSearchWeeksButton.UseVisualStyleBackColor = true;
            this.uxSearchWeeksButton.Click += new System.EventHandler(this.uxSearchWeeksButton_Click);
            // 
            // uxBillboardWeeksInput
            // 
            this.uxBillboardWeeksInput.Location = new System.Drawing.Point(9, 87);
            this.uxBillboardWeeksInput.Name = "uxBillboardWeeksInput";
            this.uxBillboardWeeksInput.Size = new System.Drawing.Size(120, 22);
            this.uxBillboardWeeksInput.TabIndex = 8;
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
            // uxSearchListensButton
            // 
            this.uxSearchListensButton.Enabled = false;
            this.uxSearchListensButton.Location = new System.Drawing.Point(135, 40);
            this.uxSearchListensButton.Name = "uxSearchListensButton";
            this.uxSearchListensButton.Size = new System.Drawing.Size(67, 23);
            this.uxSearchListensButton.TabIndex = 6;
            this.uxSearchListensButton.Text = "Search";
            this.uxSearchListensButton.UseVisualStyleBackColor = true;
            this.uxSearchListensButton.Click += new System.EventHandler(this.uxSearchByButton_Click);
            // 
            // uxReleaseDateInput
            // 
            this.uxReleaseDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uxReleaseDateInput.Location = new System.Drawing.Point(9, 176);
            this.uxReleaseDateInput.Name = "uxReleaseDateInput";
            this.uxReleaseDateInput.Size = new System.Drawing.Size(191, 22);
            this.uxReleaseDateInput.TabIndex = 5;
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
            // uxBillboardWeeksInputLabel
            // 
            this.uxBillboardWeeksInputLabel.AutoSize = true;
            this.uxBillboardWeeksInputLabel.Location = new System.Drawing.Point(6, 66);
            this.uxBillboardWeeksInputLabel.Name = "uxBillboardWeeksInputLabel";
            this.uxBillboardWeeksInputLabel.Size = new System.Drawing.Size(182, 16);
            this.uxBillboardWeeksInputLabel.TabIndex = 1;
            this.uxBillboardWeeksInputLabel.Text = "Search By # Billboard Weeks";
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
            // uxSpotifyListensOutput
            // 
            this.uxSpotifyListensOutput.Location = new System.Drawing.Point(9, 41);
            this.uxSpotifyListensOutput.Name = "uxSpotifyListensOutput";
            this.uxSpotifyListensOutput.ReadOnly = true;
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
            this.textBox1.Location = new System.Drawing.Point(9, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 37;
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
            this.uxSongGenreOutput.Location = new System.Drawing.Point(9, 176);
            this.uxSongGenreOutput.Name = "uxSongGenreOutput";
            this.uxSongGenreOutput.ReadOnly = true;
            this.uxSongGenreOutput.Size = new System.Drawing.Size(208, 22);
            this.uxSongGenreOutput.TabIndex = 35;
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
            this.uxSongAlbumOutput.Location = new System.Drawing.Point(9, 131);
            this.uxSongAlbumOutput.Name = "uxSongAlbumOutput";
            this.uxSongAlbumOutput.ReadOnly = true;
            this.uxSongAlbumOutput.Size = new System.Drawing.Size(208, 22);
            this.uxSongAlbumOutput.TabIndex = 33;
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
            this.uxSongArtistOutput.Location = new System.Drawing.Point(9, 84);
            this.uxSongArtistOutput.Name = "uxSongArtistOutput";
            this.uxSongArtistOutput.ReadOnly = true;
            this.uxSongArtistOutput.Size = new System.Drawing.Size(208, 22);
            this.uxSongArtistOutput.TabIndex = 31;
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
            // uxAlbumYearInput
            // 
            this.uxAlbumYearInput.Enabled = false;
            this.uxAlbumYearInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uxAlbumYearInput.Location = new System.Drawing.Point(133, 42);
            this.uxAlbumYearInput.Name = "uxAlbumYearInput";
            this.uxAlbumYearInput.Size = new System.Drawing.Size(98, 22);
            this.uxAlbumYearInput.TabIndex = 11;
            this.uxAlbumYearInput.ValueChanged += new System.EventHandler(this.uxAlbumYearInput_ValueChanged);
            // 
            // uxSearchByItems
            // 
            this.uxSearchByItems.Location = new System.Drawing.Point(133, 142);
            this.uxSearchByItems.Name = "uxSearchByItems";
            this.uxSearchByItems.Size = new System.Drawing.Size(98, 26);
            this.uxSearchByItems.TabIndex = 31;
            this.uxSearchByItems.Text = "Search";
            this.uxSearchByItems.UseVisualStyleBackColor = true;
            this.uxSearchByItems.Click += new System.EventHandler(this.uxSearchByItems_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Album Date";
            // 
            // uxUseDateCheckBox
            // 
            this.uxUseDateCheckBox.AutoSize = true;
            this.uxUseDateCheckBox.Location = new System.Drawing.Point(133, 73);
            this.uxUseDateCheckBox.Name = "uxUseDateCheckBox";
            this.uxUseDateCheckBox.Size = new System.Drawing.Size(77, 20);
            this.uxUseDateCheckBox.TabIndex = 33;
            this.uxUseDateCheckBox.Text = "By Year";
            this.uxUseDateCheckBox.UseVisualStyleBackColor = true;
            this.uxUseDateCheckBox.CheckedChanged += new System.EventHandler(this.uxUseDateCheckBox_CheckedChanged);
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
            this.Controls.Add(this.uxClearSearchSongButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.uxBillboardWeeksInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSpotifyListensInput)).EndInit();
            this.uxSongInfo.ResumeLayout(false);
            this.uxSongInfo.PerformLayout();
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
        private System.Windows.Forms.Button uxClearSearchSongButton;
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
        private System.Windows.Forms.DateTimePicker uxAlbumYearInput;
        private System.Windows.Forms.CheckBox uxUseDateCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxSearchByItems;
    }
}


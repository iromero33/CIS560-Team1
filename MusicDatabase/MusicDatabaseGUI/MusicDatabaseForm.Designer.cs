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
            this.uxAlbumsLabel = new System.Windows.Forms.Label();
            this.uxClearSearchSongButton = new System.Windows.Forms.Button();
            this.uxAddAlbumButton = new System.Windows.Forms.Button();
            this.uxAlbumList = new System.Windows.Forms.ComboBox();
            this.uxAddArtistButton = new System.Windows.Forms.Button();
            this.uxAddOptions = new System.Windows.Forms.GroupBox();
            this.uxAddSongButton2 = new System.Windows.Forms.Button();
            this.uxSearchOptions = new System.Windows.Forms.GroupBox();
            this.uxSearchDateButton = new System.Windows.Forms.Button();
            this.uxUseDateCheckBox = new System.Windows.Forms.CheckBox();
            this.uxSearchWeeksButton = new System.Windows.Forms.Button();
            this.uxBillboardWeeksInput = new System.Windows.Forms.NumericUpDown();
            this.uxSpotifyListensInput = new System.Windows.Forms.NumericUpDown();
            this.uxAlbumYearInput = new System.Windows.Forms.DateTimePicker();
            this.uxSearchByItems = new System.Windows.Forms.Button();
            this.uxSearchListensButton = new System.Windows.Forms.Button();
            this.uxReleaseDateInput = new System.Windows.Forms.DateTimePicker();
            this.uxReleaseDateInputLabel = new System.Windows.Forms.Label();
            this.uxBillboardWeeksInputLabel = new System.Windows.Forms.Label();
            this.uxSpotifyListensInputLabel = new System.Windows.Forms.Label();
            this.uxSpotifyListensOutput = new System.Windows.Forms.TextBox();
            this.uxSongInfo = new System.Windows.Forms.GroupBox();
            this.uxAlbumBillboardOutputLabel = new System.Windows.Forms.Label();
            this.uxAlbumBillboardOutput = new System.Windows.Forms.TextBox();
            this.uxSongTitleOutputLabel = new System.Windows.Forms.Label();
            this.uxSongTitleOutput = new System.Windows.Forms.TextBox();
            this.uxSongReleaseDateOutputLabel = new System.Windows.Forms.Label();
            this.uxSongReleaseDateOutput = new System.Windows.Forms.TextBox();
            this.uxSongGenreLabel = new System.Windows.Forms.Label();
            this.uxSongGenreOutput = new System.Windows.Forms.TextBox();
            this.uxSongAlbumLabel = new System.Windows.Forms.Label();
            this.uxSongAlbumOutput = new System.Windows.Forms.TextBox();
            this.uxSongArtistLabel = new System.Windows.Forms.Label();
            this.uxSongArtistOutput = new System.Windows.Forms.TextBox();
            this.uxSpotifyListensLabel = new System.Windows.Forms.Label();
            this.uxSongsBox = new System.Windows.Forms.GroupBox();
            this.uxAddOptions.SuspendLayout();
            this.uxSearchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxBillboardWeeksInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSpotifyListensInput)).BeginInit();
            this.uxSongInfo.SuspendLayout();
            this.uxSongsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSongsList
            // 
            this.uxSongsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongsList.FormattingEnabled = true;
            this.uxSongsList.ItemHeight = 29;
            this.uxSongsList.Location = new System.Drawing.Point(6, 198);
            this.uxSongsList.Name = "uxSongsList";
            this.uxSongsList.Size = new System.Drawing.Size(525, 671);
            this.uxSongsList.TabIndex = 0;
            this.uxSongsList.SelectedIndexChanged += new System.EventHandler(this.uxSongsList_SelectedIndexChanged);
            // 
            // uxAddSongButton
            // 
            this.uxAddSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddSongButton.Location = new System.Drawing.Point(281, 132);
            this.uxAddSongButton.Name = "uxAddSongButton";
            this.uxAddSongButton.Size = new System.Drawing.Size(250, 58);
            this.uxAddSongButton.TabIndex = 1;
            this.uxAddSongButton.Text = "Add Song";
            this.uxAddSongButton.UseVisualStyleBackColor = true;
            this.uxAddSongButton.Click += new System.EventHandler(this.AddItem);
            // 
            // uxSongsLabel
            // 
            this.uxSongsLabel.AutoSize = true;
            this.uxSongsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongsLabel.Location = new System.Drawing.Point(6, 44);
            this.uxSongsLabel.Name = "uxSongsLabel";
            this.uxSongsLabel.Size = new System.Drawing.Size(192, 32);
            this.uxSongsLabel.TabIndex = 2;
            this.uxSongsLabel.Text = "Search Songs";
            // 
            // uxSongTextBox
            // 
            this.uxSongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongTextBox.Location = new System.Drawing.Point(6, 82);
            this.uxSongTextBox.Name = "uxSongTextBox";
            this.uxSongTextBox.Size = new System.Drawing.Size(525, 38);
            this.uxSongTextBox.TabIndex = 7;
            this.uxSongTextBox.TextChanged += new System.EventHandler(this.uxSongTextBox_TextChanged);
            // 
            // uxAlbumsLabel
            // 
            this.uxAlbumsLabel.AutoSize = true;
            this.uxAlbumsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlbumsLabel.Location = new System.Drawing.Point(18, 230);
            this.uxAlbumsLabel.Name = "uxAlbumsLabel";
            this.uxAlbumsLabel.Size = new System.Drawing.Size(232, 32);
            this.uxAlbumsLabel.TabIndex = 9;
            this.uxAlbumsLabel.Text = "Search By Album";
            // 
            // uxClearSearchSongButton
            // 
            this.uxClearSearchSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClearSearchSongButton.Location = new System.Drawing.Point(6, 132);
            this.uxClearSearchSongButton.Name = "uxClearSearchSongButton";
            this.uxClearSearchSongButton.Size = new System.Drawing.Size(248, 58);
            this.uxClearSearchSongButton.TabIndex = 16;
            this.uxClearSearchSongButton.Text = "Full List";
            this.uxClearSearchSongButton.UseVisualStyleBackColor = true;
            this.uxClearSearchSongButton.Click += new System.EventHandler(this.uxClearSearchButton_Click);
            // 
            // uxAddAlbumButton
            // 
            this.uxAddAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddAlbumButton.Location = new System.Drawing.Point(18, 62);
            this.uxAddAlbumButton.Name = "uxAddAlbumButton";
            this.uxAddAlbumButton.Size = new System.Drawing.Size(180, 52);
            this.uxAddAlbumButton.TabIndex = 18;
            this.uxAddAlbumButton.Text = "Add Album";
            this.uxAddAlbumButton.UseVisualStyleBackColor = true;
            this.uxAddAlbumButton.Click += new System.EventHandler(this.AddItem);
            // 
            // uxAlbumList
            // 
            this.uxAlbumList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxAlbumList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlbumList.FormattingEnabled = true;
            this.uxAlbumList.Location = new System.Drawing.Point(18, 268);
            this.uxAlbumList.Name = "uxAlbumList";
            this.uxAlbumList.Size = new System.Drawing.Size(242, 33);
            this.uxAlbumList.TabIndex = 22;
            // 
            // uxAddArtistButton
            // 
            this.uxAddArtistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddArtistButton.Location = new System.Drawing.Point(18, 126);
            this.uxAddArtistButton.Name = "uxAddArtistButton";
            this.uxAddArtistButton.Size = new System.Drawing.Size(180, 52);
            this.uxAddArtistButton.TabIndex = 25;
            this.uxAddArtistButton.Text = "Add Artist";
            this.uxAddArtistButton.UseVisualStyleBackColor = true;
            this.uxAddArtistButton.Click += new System.EventHandler(this.AddItem);
            // 
            // uxAddOptions
            // 
            this.uxAddOptions.Controls.Add(this.uxAddSongButton2);
            this.uxAddOptions.Controls.Add(this.uxAddAlbumButton);
            this.uxAddOptions.Controls.Add(this.uxAddArtistButton);
            this.uxAddOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddOptions.Location = new System.Drawing.Point(1136, 623);
            this.uxAddOptions.Name = "uxAddOptions";
            this.uxAddOptions.Size = new System.Drawing.Size(434, 266);
            this.uxAddOptions.TabIndex = 26;
            this.uxAddOptions.TabStop = false;
            this.uxAddOptions.Text = "Add Items";
            // 
            // uxAddSongButton2
            // 
            this.uxAddSongButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddSongButton2.Location = new System.Drawing.Point(18, 190);
            this.uxAddSongButton2.Name = "uxAddSongButton2";
            this.uxAddSongButton2.Size = new System.Drawing.Size(180, 52);
            this.uxAddSongButton2.TabIndex = 26;
            this.uxAddSongButton2.Text = "Add Song";
            this.uxAddSongButton2.UseVisualStyleBackColor = true;
            this.uxAddSongButton2.Click += new System.EventHandler(this.AddItem);
            // 
            // uxSearchOptions
            // 
            this.uxSearchOptions.Controls.Add(this.uxSearchDateButton);
            this.uxSearchOptions.Controls.Add(this.uxUseDateCheckBox);
            this.uxSearchOptions.Controls.Add(this.uxSearchWeeksButton);
            this.uxSearchOptions.Controls.Add(this.uxBillboardWeeksInput);
            this.uxSearchOptions.Controls.Add(this.uxSpotifyListensInput);
            this.uxSearchOptions.Controls.Add(this.uxAlbumYearInput);
            this.uxSearchOptions.Controls.Add(this.uxSearchByItems);
            this.uxSearchOptions.Controls.Add(this.uxAlbumList);
            this.uxSearchOptions.Controls.Add(this.uxAlbumsLabel);
            this.uxSearchOptions.Controls.Add(this.uxSearchListensButton);
            this.uxSearchOptions.Controls.Add(this.uxReleaseDateInput);
            this.uxSearchOptions.Controls.Add(this.uxReleaseDateInputLabel);
            this.uxSearchOptions.Controls.Add(this.uxBillboardWeeksInputLabel);
            this.uxSearchOptions.Controls.Add(this.uxSpotifyListensInputLabel);
            this.uxSearchOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchOptions.Location = new System.Drawing.Point(1136, 12);
            this.uxSearchOptions.Name = "uxSearchOptions";
            this.uxSearchOptions.Size = new System.Drawing.Size(434, 605);
            this.uxSearchOptions.TabIndex = 28;
            this.uxSearchOptions.TabStop = false;
            this.uxSearchOptions.Text = "Other Search Types";
            // 
            // uxSearchDateButton
            // 
            this.uxSearchDateButton.AutoSize = true;
            this.uxSearchDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchDateButton.Location = new System.Drawing.Point(16, 522);
            this.uxSearchDateButton.Name = "uxSearchDateButton";
            this.uxSearchDateButton.Size = new System.Drawing.Size(408, 46);
            this.uxSearchDateButton.TabIndex = 10;
            this.uxSearchDateButton.Text = "Search";
            this.uxSearchDateButton.UseVisualStyleBackColor = true;
            this.uxSearchDateButton.Click += new System.EventHandler(this.uxSearchDateButton_Click);
            // 
            // uxUseDateCheckBox
            // 
            this.uxUseDateCheckBox.AutoSize = true;
            this.uxUseDateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUseDateCheckBox.Location = new System.Drawing.Point(18, 328);
            this.uxUseDateCheckBox.Name = "uxUseDateCheckBox";
            this.uxUseDateCheckBox.Size = new System.Drawing.Size(332, 36);
            this.uxUseDateCheckBox.TabIndex = 33;
            this.uxUseDateCheckBox.Text = "Search Albums by Year";
            this.uxUseDateCheckBox.UseVisualStyleBackColor = true;
            this.uxUseDateCheckBox.CheckedChanged += new System.EventHandler(this.uxUseDateCheckBox_CheckedChanged);
            // 
            // uxSearchWeeksButton
            // 
            this.uxSearchWeeksButton.AutoSize = true;
            this.uxSearchWeeksButton.Enabled = false;
            this.uxSearchWeeksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchWeeksButton.Location = new System.Drawing.Point(270, 172);
            this.uxSearchWeeksButton.Name = "uxSearchWeeksButton";
            this.uxSearchWeeksButton.Size = new System.Drawing.Size(152, 52);
            this.uxSearchWeeksButton.TabIndex = 9;
            this.uxSearchWeeksButton.Text = "Search";
            this.uxSearchWeeksButton.UseVisualStyleBackColor = true;
            this.uxSearchWeeksButton.Click += new System.EventHandler(this.uxSearchWeeksButton_Click);
            // 
            // uxBillboardWeeksInput
            // 
            this.uxBillboardWeeksInput.AutoSize = true;
            this.uxBillboardWeeksInput.Enabled = false;
            this.uxBillboardWeeksInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBillboardWeeksInput.Location = new System.Drawing.Point(18, 174);
            this.uxBillboardWeeksInput.Name = "uxBillboardWeeksInput";
            this.uxBillboardWeeksInput.Size = new System.Drawing.Size(240, 38);
            this.uxBillboardWeeksInput.TabIndex = 8;
            // 
            // uxSpotifyListensInput
            // 
            this.uxSpotifyListensInput.AutoSize = true;
            this.uxSpotifyListensInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSpotifyListensInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uxSpotifyListensInput.Location = new System.Drawing.Point(18, 82);
            this.uxSpotifyListensInput.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.uxSpotifyListensInput.Name = "uxSpotifyListensInput";
            this.uxSpotifyListensInput.Size = new System.Drawing.Size(240, 38);
            this.uxSpotifyListensInput.TabIndex = 7;
            // 
            // uxAlbumYearInput
            // 
            this.uxAlbumYearInput.Enabled = false;
            this.uxAlbumYearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlbumYearInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uxAlbumYearInput.Location = new System.Drawing.Point(18, 380);
            this.uxAlbumYearInput.Name = "uxAlbumYearInput";
            this.uxAlbumYearInput.ShowUpDown = true;
            this.uxAlbumYearInput.Size = new System.Drawing.Size(196, 38);
            this.uxAlbumYearInput.TabIndex = 11;
            this.uxAlbumYearInput.ValueChanged += new System.EventHandler(this.uxAlbumYearInput_ValueChanged);
            // 
            // uxSearchByItems
            // 
            this.uxSearchByItems.AutoSize = true;
            this.uxSearchByItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchByItems.Location = new System.Drawing.Point(270, 266);
            this.uxSearchByItems.Name = "uxSearchByItems";
            this.uxSearchByItems.Size = new System.Drawing.Size(152, 52);
            this.uxSearchByItems.TabIndex = 31;
            this.uxSearchByItems.Text = "Search";
            this.uxSearchByItems.UseVisualStyleBackColor = true;
            this.uxSearchByItems.Click += new System.EventHandler(this.uxSearchByItems_Click);
            // 
            // uxSearchListensButton
            // 
            this.uxSearchListensButton.AutoSize = true;
            this.uxSearchListensButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchListensButton.Location = new System.Drawing.Point(270, 80);
            this.uxSearchListensButton.Name = "uxSearchListensButton";
            this.uxSearchListensButton.Size = new System.Drawing.Size(152, 46);
            this.uxSearchListensButton.TabIndex = 6;
            this.uxSearchListensButton.Text = "Search";
            this.uxSearchListensButton.UseVisualStyleBackColor = true;
            this.uxSearchListensButton.Click += new System.EventHandler(this.uxSearchByButton_Click);
            // 
            // uxReleaseDateInput
            // 
            this.uxReleaseDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReleaseDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uxReleaseDateInput.Location = new System.Drawing.Point(18, 470);
            this.uxReleaseDateInput.Name = "uxReleaseDateInput";
            this.uxReleaseDateInput.Size = new System.Drawing.Size(404, 38);
            this.uxReleaseDateInput.TabIndex = 5;
            // 
            // uxReleaseDateInputLabel
            // 
            this.uxReleaseDateInputLabel.AutoSize = true;
            this.uxReleaseDateInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReleaseDateInputLabel.Location = new System.Drawing.Point(12, 432);
            this.uxReleaseDateInputLabel.Name = "uxReleaseDateInputLabel";
            this.uxReleaseDateInputLabel.Size = new System.Drawing.Size(320, 32);
            this.uxReleaseDateInputLabel.TabIndex = 2;
            this.uxReleaseDateInputLabel.Text = "Search by Release Date";
            // 
            // uxBillboardWeeksInputLabel
            // 
            this.uxBillboardWeeksInputLabel.AutoSize = true;
            this.uxBillboardWeeksInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBillboardWeeksInputLabel.Location = new System.Drawing.Point(12, 132);
            this.uxBillboardWeeksInputLabel.Name = "uxBillboardWeeksInputLabel";
            this.uxBillboardWeeksInputLabel.Size = new System.Drawing.Size(380, 32);
            this.uxBillboardWeeksInputLabel.TabIndex = 1;
            this.uxBillboardWeeksInputLabel.Text = "Search By # Billboard Weeks";
            // 
            // uxSpotifyListensInputLabel
            // 
            this.uxSpotifyListensInputLabel.AutoSize = true;
            this.uxSpotifyListensInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSpotifyListensInputLabel.Location = new System.Drawing.Point(12, 44);
            this.uxSpotifyListensInputLabel.Name = "uxSpotifyListensInputLabel";
            this.uxSpotifyListensInputLabel.Size = new System.Drawing.Size(357, 32);
            this.uxSpotifyListensInputLabel.TabIndex = 0;
            this.uxSpotifyListensInputLabel.Text = "Search by # Spotify Listens";
            // 
            // uxSpotifyListensOutput
            // 
            this.uxSpotifyListensOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSpotifyListensOutput.Location = new System.Drawing.Point(12, 174);
            this.uxSpotifyListensOutput.Name = "uxSpotifyListensOutput";
            this.uxSpotifyListensOutput.ReadOnly = true;
            this.uxSpotifyListensOutput.Size = new System.Drawing.Size(557, 38);
            this.uxSpotifyListensOutput.TabIndex = 29;
            // 
            // uxSongInfo
            // 
            this.uxSongInfo.Controls.Add(this.uxAlbumBillboardOutputLabel);
            this.uxSongInfo.Controls.Add(this.uxAlbumBillboardOutput);
            this.uxSongInfo.Controls.Add(this.uxSongTitleOutputLabel);
            this.uxSongInfo.Controls.Add(this.uxSongTitleOutput);
            this.uxSongInfo.Controls.Add(this.uxSongReleaseDateOutputLabel);
            this.uxSongInfo.Controls.Add(this.uxSongReleaseDateOutput);
            this.uxSongInfo.Controls.Add(this.uxSongGenreLabel);
            this.uxSongInfo.Controls.Add(this.uxSongGenreOutput);
            this.uxSongInfo.Controls.Add(this.uxSongAlbumLabel);
            this.uxSongInfo.Controls.Add(this.uxSongAlbumOutput);
            this.uxSongInfo.Controls.Add(this.uxSongArtistLabel);
            this.uxSongInfo.Controls.Add(this.uxSongArtistOutput);
            this.uxSongInfo.Controls.Add(this.uxSpotifyListensLabel);
            this.uxSongInfo.Controls.Add(this.uxSpotifyListensOutput);
            this.uxSongInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongInfo.Location = new System.Drawing.Point(555, 12);
            this.uxSongInfo.Name = "uxSongInfo";
            this.uxSongInfo.Size = new System.Drawing.Size(575, 877);
            this.uxSongInfo.TabIndex = 30;
            this.uxSongInfo.TabStop = false;
            this.uxSongInfo.Text = "Song Info";
            // 
            // uxAlbumBillboardOutputLabel
            // 
            this.uxAlbumBillboardOutputLabel.AutoSize = true;
            this.uxAlbumBillboardOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlbumBillboardOutputLabel.Location = new System.Drawing.Point(6, 598);
            this.uxAlbumBillboardOutputLabel.Name = "uxAlbumBillboardOutputLabel";
            this.uxAlbumBillboardOutputLabel.Size = new System.Drawing.Size(441, 29);
            this.uxAlbumBillboardOutputLabel.TabIndex = 42;
            this.uxAlbumBillboardOutputLabel.Text = "Billboard Longest Consecutive Weeks";
            // 
            // uxAlbumBillboardOutput
            // 
            this.uxAlbumBillboardOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlbumBillboardOutput.Location = new System.Drawing.Point(12, 636);
            this.uxAlbumBillboardOutput.Name = "uxAlbumBillboardOutput";
            this.uxAlbumBillboardOutput.ReadOnly = true;
            this.uxAlbumBillboardOutput.Size = new System.Drawing.Size(557, 38);
            this.uxAlbumBillboardOutput.TabIndex = 41;
            // 
            // uxSongTitleOutputLabel
            // 
            this.uxSongTitleOutputLabel.AutoSize = true;
            this.uxSongTitleOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongTitleOutputLabel.Location = new System.Drawing.Point(6, 44);
            this.uxSongTitleOutputLabel.Name = "uxSongTitleOutputLabel";
            this.uxSongTitleOutputLabel.Size = new System.Drawing.Size(69, 32);
            this.uxSongTitleOutputLabel.TabIndex = 40;
            this.uxSongTitleOutputLabel.Text = "Title";
            // 
            // uxSongTitleOutput
            // 
            this.uxSongTitleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongTitleOutput.Location = new System.Drawing.Point(12, 82);
            this.uxSongTitleOutput.Name = "uxSongTitleOutput";
            this.uxSongTitleOutput.ReadOnly = true;
            this.uxSongTitleOutput.Size = new System.Drawing.Size(557, 38);
            this.uxSongTitleOutput.TabIndex = 39;
            // 
            // uxSongReleaseDateOutputLabel
            // 
            this.uxSongReleaseDateOutputLabel.AutoSize = true;
            this.uxSongReleaseDateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongReleaseDateOutputLabel.Location = new System.Drawing.Point(6, 506);
            this.uxSongReleaseDateOutputLabel.Name = "uxSongReleaseDateOutputLabel";
            this.uxSongReleaseDateOutputLabel.Size = new System.Drawing.Size(186, 32);
            this.uxSongReleaseDateOutputLabel.TabIndex = 38;
            this.uxSongReleaseDateOutputLabel.Text = "Release Date";
            // 
            // uxSongReleaseDateOutput
            // 
            this.uxSongReleaseDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongReleaseDateOutput.Location = new System.Drawing.Point(12, 544);
            this.uxSongReleaseDateOutput.Name = "uxSongReleaseDateOutput";
            this.uxSongReleaseDateOutput.ReadOnly = true;
            this.uxSongReleaseDateOutput.Size = new System.Drawing.Size(557, 38);
            this.uxSongReleaseDateOutput.TabIndex = 37;
            // 
            // uxSongGenreLabel
            // 
            this.uxSongGenreLabel.AutoSize = true;
            this.uxSongGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongGenreLabel.Location = new System.Drawing.Point(6, 414);
            this.uxSongGenreLabel.Name = "uxSongGenreLabel";
            this.uxSongGenreLabel.Size = new System.Drawing.Size(93, 32);
            this.uxSongGenreLabel.TabIndex = 36;
            this.uxSongGenreLabel.Text = "Genre";
            // 
            // uxSongGenreOutput
            // 
            this.uxSongGenreOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongGenreOutput.Location = new System.Drawing.Point(12, 452);
            this.uxSongGenreOutput.Name = "uxSongGenreOutput";
            this.uxSongGenreOutput.ReadOnly = true;
            this.uxSongGenreOutput.Size = new System.Drawing.Size(557, 38);
            this.uxSongGenreOutput.TabIndex = 35;
            // 
            // uxSongAlbumLabel
            // 
            this.uxSongAlbumLabel.AutoSize = true;
            this.uxSongAlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongAlbumLabel.Location = new System.Drawing.Point(6, 324);
            this.uxSongAlbumLabel.Name = "uxSongAlbumLabel";
            this.uxSongAlbumLabel.Size = new System.Drawing.Size(95, 32);
            this.uxSongAlbumLabel.TabIndex = 34;
            this.uxSongAlbumLabel.Text = "Album";
            // 
            // uxSongAlbumOutput
            // 
            this.uxSongAlbumOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongAlbumOutput.Location = new System.Drawing.Point(12, 362);
            this.uxSongAlbumOutput.Name = "uxSongAlbumOutput";
            this.uxSongAlbumOutput.ReadOnly = true;
            this.uxSongAlbumOutput.Size = new System.Drawing.Size(557, 38);
            this.uxSongAlbumOutput.TabIndex = 33;
            // 
            // uxSongArtistLabel
            // 
            this.uxSongArtistLabel.AutoSize = true;
            this.uxSongArtistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongArtistLabel.Location = new System.Drawing.Point(6, 230);
            this.uxSongArtistLabel.Name = "uxSongArtistLabel";
            this.uxSongArtistLabel.Size = new System.Drawing.Size(79, 32);
            this.uxSongArtistLabel.TabIndex = 32;
            this.uxSongArtistLabel.Text = "Artist";
            // 
            // uxSongArtistOutput
            // 
            this.uxSongArtistOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongArtistOutput.Location = new System.Drawing.Point(12, 268);
            this.uxSongArtistOutput.Name = "uxSongArtistOutput";
            this.uxSongArtistOutput.ReadOnly = true;
            this.uxSongArtistOutput.Size = new System.Drawing.Size(557, 38);
            this.uxSongArtistOutput.TabIndex = 31;
            // 
            // uxSpotifyListensLabel
            // 
            this.uxSpotifyListensLabel.AutoSize = true;
            this.uxSpotifyListensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSpotifyListensLabel.Location = new System.Drawing.Point(6, 136);
            this.uxSpotifyListensLabel.Name = "uxSpotifyListensLabel";
            this.uxSpotifyListensLabel.Size = new System.Drawing.Size(200, 32);
            this.uxSpotifyListensLabel.TabIndex = 30;
            this.uxSpotifyListensLabel.Text = "Spotify Listens";
            // 
            // uxSongsBox
            // 
            this.uxSongsBox.Controls.Add(this.uxClearSearchSongButton);
            this.uxSongsBox.Controls.Add(this.uxSongsList);
            this.uxSongsBox.Controls.Add(this.uxAddSongButton);
            this.uxSongsBox.Controls.Add(this.uxSongsLabel);
            this.uxSongsBox.Controls.Add(this.uxSongTextBox);
            this.uxSongsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSongsBox.Location = new System.Drawing.Point(12, 12);
            this.uxSongsBox.Name = "uxSongsBox";
            this.uxSongsBox.Size = new System.Drawing.Size(537, 877);
            this.uxSongsBox.TabIndex = 32;
            this.uxSongsBox.TabStop = false;
            this.uxSongsBox.Text = "Songs";
            // 
            // MusicDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1582, 913);
            this.Controls.Add(this.uxSongsBox);
            this.Controls.Add(this.uxSongInfo);
            this.Controls.Add(this.uxSearchOptions);
            this.Controls.Add(this.uxAddOptions);
            this.Name = "MusicDatabaseForm";
            this.Text = "Music Database";
            this.uxAddOptions.ResumeLayout(false);
            this.uxSearchOptions.ResumeLayout(false);
            this.uxSearchOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxBillboardWeeksInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSpotifyListensInput)).EndInit();
            this.uxSongInfo.ResumeLayout(false);
            this.uxSongInfo.PerformLayout();
            this.uxSongsBox.ResumeLayout(false);
            this.uxSongsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxSongsList;
        private System.Windows.Forms.Button uxAddSongButton;
        private System.Windows.Forms.Label uxSongsLabel;
        private System.Windows.Forms.TextBox uxSongTextBox;
        private System.Windows.Forms.Label uxAlbumsLabel;
        private System.Windows.Forms.Button uxClearSearchSongButton;
        private System.Windows.Forms.Button uxAddAlbumButton;
        private System.Windows.Forms.ComboBox uxAlbumList;
        private System.Windows.Forms.Button uxAddArtistButton;
        private System.Windows.Forms.GroupBox uxAddOptions;
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
        private System.Windows.Forms.Label uxSongReleaseDateOutputLabel;
        private System.Windows.Forms.DateTimePicker uxReleaseDateInput;
        private System.Windows.Forms.Label uxReleaseDateInputLabel;
        private System.Windows.Forms.Button uxSearchListensButton;
        private System.Windows.Forms.NumericUpDown uxSpotifyListensInput;
        private System.Windows.Forms.NumericUpDown uxBillboardWeeksInput;
        private System.Windows.Forms.Button uxSearchWeeksButton;
        private System.Windows.Forms.Button uxSearchDateButton;
        private System.Windows.Forms.DateTimePicker uxAlbumYearInput;
        private System.Windows.Forms.CheckBox uxUseDateCheckBox;
        private System.Windows.Forms.Button uxSearchByItems;
        private System.Windows.Forms.Button uxAddSongButton2;
        private System.Windows.Forms.Label uxSongTitleOutputLabel;
        private System.Windows.Forms.TextBox uxSongTitleOutput;
        private System.Windows.Forms.Label uxAlbumBillboardOutputLabel;
        private System.Windows.Forms.TextBox uxAlbumBillboardOutput;
        private System.Windows.Forms.TextBox uxSongReleaseDateOutput;
        private System.Windows.Forms.GroupBox uxSongsBox;
    }
}


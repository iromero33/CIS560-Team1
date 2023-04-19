namespace MusicDatabaseGUI
{
    partial class AddItemForm
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
            this.uxAlbumMenu = new System.Windows.Forms.ComboBox();
            this.uxItemNameInput = new System.Windows.Forms.TextBox();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxOkButton = new System.Windows.Forms.Button();
            this.uxAlbumLabel = new System.Windows.Forms.Label();
            this.uxArtistLabel = new System.Windows.Forms.Label();
            this.uxArtistMenu = new System.Windows.Forms.ComboBox();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxGenreMenu = new System.Windows.Forms.ComboBox();
            this.uxOtherLabel = new System.Windows.Forms.Label();
            this.uxOtherInput = new System.Windows.Forms.TextBox();
            this.uxReleaseDateInput = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uxAlbumMenu
            // 
            this.uxAlbumMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxAlbumMenu.FormattingEnabled = true;
            this.uxAlbumMenu.Location = new System.Drawing.Point(228, 97);
            this.uxAlbumMenu.Name = "uxAlbumMenu";
            this.uxAlbumMenu.Size = new System.Drawing.Size(170, 24);
            this.uxAlbumMenu.TabIndex = 0;
            // 
            // uxItemNameInput
            // 
            this.uxItemNameInput.Location = new System.Drawing.Point(12, 28);
            this.uxItemNameInput.Name = "uxItemNameInput";
            this.uxItemNameInput.Size = new System.Drawing.Size(170, 22);
            this.uxItemNameInput.TabIndex = 1;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Location = new System.Drawing.Point(12, 9);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(44, 16);
            this.uxNameLabel.TabIndex = 2;
            this.uxNameLabel.Text = "Name";
            // 
            // uxOkButton
            // 
            this.uxOkButton.Location = new System.Drawing.Point(228, 166);
            this.uxOkButton.Name = "uxOkButton";
            this.uxOkButton.Size = new System.Drawing.Size(75, 26);
            this.uxOkButton.TabIndex = 3;
            this.uxOkButton.Text = "Ok";
            this.uxOkButton.UseVisualStyleBackColor = true;
            this.uxOkButton.Click += new System.EventHandler(this.uxOkButton_Click);
            // 
            // uxAlbumLabel
            // 
            this.uxAlbumLabel.AutoSize = true;
            this.uxAlbumLabel.Location = new System.Drawing.Point(225, 78);
            this.uxAlbumLabel.Name = "uxAlbumLabel";
            this.uxAlbumLabel.Size = new System.Drawing.Size(45, 16);
            this.uxAlbumLabel.TabIndex = 4;
            this.uxAlbumLabel.Text = "Album";
            // 
            // uxArtistLabel
            // 
            this.uxArtistLabel.AutoSize = true;
            this.uxArtistLabel.Location = new System.Drawing.Point(12, 78);
            this.uxArtistLabel.Name = "uxArtistLabel";
            this.uxArtistLabel.Size = new System.Drawing.Size(36, 16);
            this.uxArtistLabel.TabIndex = 5;
            this.uxArtistLabel.Text = "Artist";
            // 
            // uxArtistMenu
            // 
            this.uxArtistMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxArtistMenu.FormattingEnabled = true;
            this.uxArtistMenu.Location = new System.Drawing.Point(12, 97);
            this.uxArtistMenu.Name = "uxArtistMenu";
            this.uxArtistMenu.Size = new System.Drawing.Size(170, 24);
            this.uxArtistMenu.TabIndex = 6;
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Location = new System.Drawing.Point(323, 166);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(75, 26);
            this.uxCancelButton.TabIndex = 7;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Location = new System.Drawing.Point(9, 148);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(44, 16);
            this.uxGenreLabel.TabIndex = 8;
            this.uxGenreLabel.Text = "Genre";
            // 
            // uxGenreMenu
            // 
            this.uxGenreMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGenreMenu.FormattingEnabled = true;
            this.uxGenreMenu.Location = new System.Drawing.Point(12, 167);
            this.uxGenreMenu.Name = "uxGenreMenu";
            this.uxGenreMenu.Size = new System.Drawing.Size(170, 24);
            this.uxGenreMenu.TabIndex = 9;
            // 
            // uxOtherLabel
            // 
            this.uxOtherLabel.AutoSize = true;
            this.uxOtherLabel.Location = new System.Drawing.Point(225, 9);
            this.uxOtherLabel.Name = "uxOtherLabel";
            this.uxOtherLabel.Size = new System.Drawing.Size(91, 16);
            this.uxOtherLabel.TabIndex = 10;
            this.uxOtherLabel.Text = "Release Date";
            // 
            // uxOtherInput
            // 
            this.uxOtherInput.Location = new System.Drawing.Point(228, 28);
            this.uxOtherInput.Name = "uxOtherInput";
            this.uxOtherInput.Size = new System.Drawing.Size(170, 22);
            this.uxOtherInput.TabIndex = 11;
            // 
            // uxReleaseDateInput
            // 
            this.uxReleaseDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxReleaseDateInput.Location = new System.Drawing.Point(228, 28);
            this.uxReleaseDateInput.Name = "uxReleaseDateInput";
            this.uxReleaseDateInput.Size = new System.Drawing.Size(170, 22);
            this.uxReleaseDateInput.TabIndex = 12;
            this.uxReleaseDateInput.Value = new System.DateTime(2023, 4, 18, 20, 41, 1, 0);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 203);
            this.Controls.Add(this.uxReleaseDateInput);
            this.Controls.Add(this.uxOtherInput);
            this.Controls.Add(this.uxOtherLabel);
            this.Controls.Add(this.uxGenreMenu);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxArtistMenu);
            this.Controls.Add(this.uxArtistLabel);
            this.Controls.Add(this.uxAlbumLabel);
            this.Controls.Add(this.uxOkButton);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxItemNameInput);
            this.Controls.Add(this.uxAlbumMenu);
            this.Name = "AddItemForm";
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxAlbumMenu;
        private System.Windows.Forms.TextBox uxItemNameInput;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Button uxOkButton;
        private System.Windows.Forms.Label uxAlbumLabel;
        private System.Windows.Forms.Label uxArtistLabel;
        private System.Windows.Forms.ComboBox uxArtistMenu;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.ComboBox uxGenreMenu;
        private System.Windows.Forms.Label uxOtherLabel;
        private System.Windows.Forms.TextBox uxOtherInput;
        private System.Windows.Forms.DateTimePicker uxReleaseDateInput;
    }
}
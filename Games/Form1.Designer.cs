namespace Games
{
    partial class Form1
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
            this.GBGames = new System.Windows.Forms.GroupBox();
            this.TBGamesEAN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.datetimeGamesReleasedate = new System.Windows.Forms.DateTimePicker();
            this.ButtonGamesAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TBGamename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBDevelopers = new System.Windows.Forms.GroupBox();
            this.ButtonDevelopersAdd = new System.Windows.Forms.Button();
            this.TBDeveloperCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBDevelopername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GBPlayers = new System.Windows.Forms.GroupBox();
            this.TBPlayersPNR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonPlayersAdd = new System.Windows.Forms.Button();
            this.TBPlayersName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GBDevelop = new System.Windows.Forms.GroupBox();
            this.buttonDevelopAdd = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GBPlaying = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.buttonPlayingAdd = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.TBSearchWord = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GBGames.SuspendLayout();
            this.GBDevelopers.SuspendLayout();
            this.GBPlayers.SuspendLayout();
            this.GBDevelop.SuspendLayout();
            this.GBPlaying.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBGames
            // 
            this.GBGames.Controls.Add(this.TBGamesEAN);
            this.GBGames.Controls.Add(this.label10);
            this.GBGames.Controls.Add(this.datetimeGamesReleasedate);
            this.GBGames.Controls.Add(this.ButtonGamesAdd);
            this.GBGames.Controls.Add(this.label7);
            this.GBGames.Controls.Add(this.TBGamename);
            this.GBGames.Controls.Add(this.label4);
            this.GBGames.Controls.Add(this.label1);
            this.GBGames.Location = new System.Drawing.Point(13, 13);
            this.GBGames.Name = "GBGames";
            this.GBGames.Size = new System.Drawing.Size(200, 201);
            this.GBGames.TabIndex = 0;
            this.GBGames.TabStop = false;
            this.GBGames.Text = "Games";
            // 
            // TBGamesEAN
            // 
            this.TBGamesEAN.Location = new System.Drawing.Point(10, 95);
            this.TBGamesEAN.Name = "TBGamesEAN";
            this.TBGamesEAN.Size = new System.Drawing.Size(100, 20);
            this.TBGamesEAN.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "EAN:";
            // 
            // datetimeGamesReleasedate
            // 
            this.datetimeGamesReleasedate.Location = new System.Drawing.Point(10, 138);
            this.datetimeGamesReleasedate.Name = "datetimeGamesReleasedate";
            this.datetimeGamesReleasedate.Size = new System.Drawing.Size(184, 20);
            this.datetimeGamesReleasedate.TabIndex = 6;
            // 
            // ButtonGamesAdd
            // 
            this.ButtonGamesAdd.Location = new System.Drawing.Point(10, 164);
            this.ButtonGamesAdd.Name = "ButtonGamesAdd";
            this.ButtonGamesAdd.Size = new System.Drawing.Size(97, 23);
            this.ButtonGamesAdd.TabIndex = 5;
            this.ButtonGamesAdd.Text = "Add game";
            this.ButtonGamesAdd.UseVisualStyleBackColor = true;
            this.ButtonGamesAdd.Click += new System.EventHandler(this.ButtonGamesAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Release date:";
            // 
            // TBGamename
            // 
            this.TBGamename.Location = new System.Drawing.Point(10, 54);
            this.TBGamename.Name = "TBGamename";
            this.TBGamename.Size = new System.Drawing.Size(100, 20);
            this.TBGamename.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new game:";
            // 
            // GBDevelopers
            // 
            this.GBDevelopers.Controls.Add(this.ButtonDevelopersAdd);
            this.GBDevelopers.Controls.Add(this.TBDeveloperCountry);
            this.GBDevelopers.Controls.Add(this.label8);
            this.GBDevelopers.Controls.Add(this.TBDevelopername);
            this.GBDevelopers.Controls.Add(this.label5);
            this.GBDevelopers.Controls.Add(this.label2);
            this.GBDevelopers.Location = new System.Drawing.Point(220, 13);
            this.GBDevelopers.Name = "GBDevelopers";
            this.GBDevelopers.Size = new System.Drawing.Size(200, 153);
            this.GBDevelopers.TabIndex = 1;
            this.GBDevelopers.TabStop = false;
            this.GBDevelopers.Text = "Developers";
            // 
            // ButtonDevelopersAdd
            // 
            this.ButtonDevelopersAdd.Location = new System.Drawing.Point(9, 118);
            this.ButtonDevelopersAdd.Name = "ButtonDevelopersAdd";
            this.ButtonDevelopersAdd.Size = new System.Drawing.Size(100, 23);
            this.ButtonDevelopersAdd.TabIndex = 5;
            this.ButtonDevelopersAdd.Text = "Add developer";
            this.ButtonDevelopersAdd.UseVisualStyleBackColor = true;
            this.ButtonDevelopersAdd.Click += new System.EventHandler(this.ButtonDevelopersAdd_Click);
            // 
            // TBDeveloperCountry
            // 
            this.TBDeveloperCountry.Location = new System.Drawing.Point(9, 92);
            this.TBDeveloperCountry.Name = "TBDeveloperCountry";
            this.TBDeveloperCountry.Size = new System.Drawing.Size(100, 20);
            this.TBDeveloperCountry.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Country:";
            // 
            // TBDevelopername
            // 
            this.TBDevelopername.Location = new System.Drawing.Point(9, 53);
            this.TBDevelopername.Name = "TBDevelopername";
            this.TBDevelopername.Size = new System.Drawing.Size(100, 20);
            this.TBDevelopername.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add new developer:";
            // 
            // GBPlayers
            // 
            this.GBPlayers.Controls.Add(this.TBPlayersPNR);
            this.GBPlayers.Controls.Add(this.label9);
            this.GBPlayers.Controls.Add(this.ButtonPlayersAdd);
            this.GBPlayers.Controls.Add(this.TBPlayersName);
            this.GBPlayers.Controls.Add(this.label6);
            this.GBPlayers.Controls.Add(this.label3);
            this.GBPlayers.Location = new System.Drawing.Point(427, 13);
            this.GBPlayers.Name = "GBPlayers";
            this.GBPlayers.Size = new System.Drawing.Size(200, 153);
            this.GBPlayers.TabIndex = 2;
            this.GBPlayers.TabStop = false;
            this.GBPlayers.Text = "Players";
            // 
            // TBPlayersPNR
            // 
            this.TBPlayersPNR.Location = new System.Drawing.Point(10, 92);
            this.TBPlayersPNR.Name = "TBPlayersPNR";
            this.TBPlayersPNR.Size = new System.Drawing.Size(100, 20);
            this.TBPlayersPNR.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Personal Identity Number:";
            // 
            // ButtonPlayersAdd
            // 
            this.ButtonPlayersAdd.Location = new System.Drawing.Point(10, 118);
            this.ButtonPlayersAdd.Name = "ButtonPlayersAdd";
            this.ButtonPlayersAdd.Size = new System.Drawing.Size(100, 23);
            this.ButtonPlayersAdd.TabIndex = 3;
            this.ButtonPlayersAdd.Text = "Add player";
            this.ButtonPlayersAdd.UseVisualStyleBackColor = true;
            this.ButtonPlayersAdd.Click += new System.EventHandler(this.ButtonPlayersAdd_Click);
            // 
            // TBPlayersName
            // 
            this.TBPlayersName.Location = new System.Drawing.Point(10, 53);
            this.TBPlayersName.Name = "TBPlayersName";
            this.TBPlayersName.Size = new System.Drawing.Size(100, 20);
            this.TBPlayersName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name of player:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add new player count:";
            // 
            // GBDevelop
            // 
            this.GBDevelop.Controls.Add(this.buttonDevelopAdd);
            this.GBDevelop.Controls.Add(this.comboBox2);
            this.GBDevelop.Controls.Add(this.label11);
            this.GBDevelop.Controls.Add(this.comboBox1);
            this.GBDevelop.Controls.Add(this.label12);
            this.GBDevelop.Location = new System.Drawing.Point(634, 13);
            this.GBDevelop.Name = "GBDevelop";
            this.GBDevelop.Size = new System.Drawing.Size(200, 153);
            this.GBDevelop.TabIndex = 3;
            this.GBDevelop.TabStop = false;
            this.GBDevelop.Text = "Develop";
            // 
            // buttonDevelopAdd
            // 
            this.buttonDevelopAdd.Location = new System.Drawing.Point(12, 104);
            this.buttonDevelopAdd.Name = "buttonDevelopAdd";
            this.buttonDevelopAdd.Size = new System.Drawing.Size(121, 23);
            this.buttonDevelopAdd.TabIndex = 6;
            this.buttonDevelopAdd.Text = "Add connection";
            this.buttonDevelopAdd.UseVisualStyleBackColor = true;
            this.buttonDevelopAdd.Click += new System.EventHandler(this.buttonDevelopAdd_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Game:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Game developed by:";
            // 
            // GBPlaying
            // 
            this.GBPlaying.Controls.Add(this.comboBox4);
            this.GBPlaying.Controls.Add(this.buttonPlayingAdd);
            this.GBPlaying.Controls.Add(this.comboBox3);
            this.GBPlaying.Controls.Add(this.label14);
            this.GBPlaying.Controls.Add(this.label13);
            this.GBPlaying.Location = new System.Drawing.Point(841, 13);
            this.GBPlaying.Name = "GBPlaying";
            this.GBPlaying.Size = new System.Drawing.Size(200, 153);
            this.GBPlaying.TabIndex = 4;
            this.GBPlaying.TabStop = false;
            this.GBPlaying.Text = "Playing";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(13, 37);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 5;
            // 
            // buttonPlayingAdd
            // 
            this.buttonPlayingAdd.Location = new System.Drawing.Point(13, 109);
            this.buttonPlayingAdd.Name = "buttonPlayingAdd";
            this.buttonPlayingAdd.Size = new System.Drawing.Size(121, 23);
            this.buttonPlayingAdd.TabIndex = 4;
            this.buttonPlayingAdd.Text = "Add connection";
            this.buttonPlayingAdd.UseVisualStyleBackColor = true;
            this.buttonPlayingAdd.Click += new System.EventHandler(this.buttonPlayingAdd_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(13, 81);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Game:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Personal Identity Number:";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(246, 186);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 6;
            this.buttonShowAll.Text = "Show all";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(327, 186);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete selected";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(533, 185);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 242);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(502, 134);
            this.listBox1.TabIndex = 12;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 382);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(238, 121);
            this.listBox2.TabIndex = 13;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(257, 382);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(258, 121);
            this.listBox3.TabIndex = 14;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(521, 242);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(180, 173);
            this.listBox4.TabIndex = 15;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(707, 242);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(183, 173);
            this.listBox5.TabIndex = 16;
            // 
            // TBSearchWord
            // 
            this.TBSearchWord.Location = new System.Drawing.Point(427, 188);
            this.TBSearchWord.Name = "TBSearchWord";
            this.TBSearchWord.Size = new System.Drawing.Size(100, 20);
            this.TBSearchWord.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(615, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(408, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 518);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TBSearchWord);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.GBPlaying);
            this.Controls.Add(this.GBDevelop);
            this.Controls.Add(this.GBPlayers);
            this.Controls.Add(this.GBDevelopers);
            this.Controls.Add(this.GBGames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBGames.ResumeLayout(false);
            this.GBGames.PerformLayout();
            this.GBDevelopers.ResumeLayout(false);
            this.GBDevelopers.PerformLayout();
            this.GBPlayers.ResumeLayout(false);
            this.GBPlayers.PerformLayout();
            this.GBDevelop.ResumeLayout(false);
            this.GBDevelop.PerformLayout();
            this.GBPlaying.ResumeLayout(false);
            this.GBPlaying.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBGames;
        private System.Windows.Forms.GroupBox GBDevelopers;
        private System.Windows.Forms.GroupBox GBPlayers;
        private System.Windows.Forms.TextBox TBGamename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBDevelopername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPlayersName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBDeveloperCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonGamesAdd;
        private System.Windows.Forms.Button ButtonDevelopersAdd;
        private System.Windows.Forms.Button ButtonPlayersAdd;
        private System.Windows.Forms.DateTimePicker datetimeGamesReleasedate;
        private System.Windows.Forms.TextBox TBPlayersPNR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GBDevelop;
        private System.Windows.Forms.GroupBox GBPlaying;
        private System.Windows.Forms.TextBox TBGamesEAN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonDevelopAdd;
        private System.Windows.Forms.Button buttonPlayingAdd;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.TextBox TBSearchWord;
        private System.Windows.Forms.TextBox textBox1;
    }
}


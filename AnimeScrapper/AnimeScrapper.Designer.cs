namespace AnimeScrapper
{
    partial class AnimeScrapper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimeScrapper));
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.displayImagesChk = new MetroFramework.Controls.MetroCheckBox();
            this.searchResultPnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sampleImg = new System.Windows.Forms.PictureBox();
            this.logoLbl = new System.Windows.Forms.Label();
            this.searchTb = new MetroFramework.Controls.MetroTextBox();
            this.AnimeInformationPanel = new System.Windows.Forms.Panel();
            this.nextBtn = new MetroFramework.Controls.MetroButton();
            this.yearReleasedLbl = new System.Windows.Forms.Label();
            this.coverImagePb = new System.Windows.Forms.PictureBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.animeInfoGoBackBtn = new MetroFramework.Controls.MetroButton();
            this.ScrapePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.epToBeScrappedPnl = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scrapeGoBackBtn = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SearchPanel.SuspendLayout();
            this.searchResultPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleImg)).BeginInit();
            this.AnimeInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImagePb)).BeginInit();
            this.ScrapePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.epToBeScrappedPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.Controls.Add(this.displayImagesChk);
            this.SearchPanel.Controls.Add(this.searchResultPnl);
            this.SearchPanel.Controls.Add(this.logoLbl);
            this.SearchPanel.Controls.Add(this.searchTb);
            this.SearchPanel.Location = new System.Drawing.Point(0, -2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(787, 513);
            this.SearchPanel.TabIndex = 0;
            // 
            // displayImagesChk
            // 
            this.displayImagesChk.Checked = true;
            this.displayImagesChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayImagesChk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayImagesChk.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.displayImagesChk.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.displayImagesChk.Location = new System.Drawing.Point(571, 31);
            this.displayImagesChk.Name = "displayImagesChk";
            this.displayImagesChk.Size = new System.Drawing.Size(165, 35);
            this.displayImagesChk.Style = MetroFramework.MetroColorStyle.Red;
            this.displayImagesChk.TabIndex = 4;
            this.displayImagesChk.Text = "Display Images";
            this.displayImagesChk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.displayImagesChk.UseVisualStyleBackColor = true;
            // 
            // searchResultPnl
            // 
            this.searchResultPnl.Controls.Add(this.label3);
            this.searchResultPnl.Controls.Add(this.label4);
            this.searchResultPnl.Controls.Add(this.label2);
            this.searchResultPnl.Controls.Add(this.label1);
            this.searchResultPnl.Controls.Add(this.pictureBox1);
            this.searchResultPnl.Controls.Add(this.sampleImg);
            this.searchResultPnl.Location = new System.Drawing.Point(75, 100);
            this.searchResultPnl.Name = "searchResultPnl";
            this.searchResultPnl.Size = new System.Drawing.Size(646, 375);
            this.searchResultPnl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(232, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Comedy, Ecchi, Harem, Romance, Sci Fi, Shounen, Slice Of Life, Aliens, Love Trian" +
    "gle, Nudity, Panty Shots, Sexual Content";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(232, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 77);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dragon Ball Z Special 1: Tatta Hitori no Saishuu Kessen - Freezer ni Idonda Z Sen" +
    "shi Son Goku no Chi";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(232, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Comedy, Ecchi, Harem, Romance, Sci Fi, Shounen, Slice Of Life, Aliens, Love Trian" +
    "gle, Nudity, Panty Shots, Sexual Content";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(232, 0);
            this.label1.MaximumSize = new System.Drawing.Size(378, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 72);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dragon Ball Z Special 1: Tatta Hitori no Saishuu Kessen - Freezer ni Idonda Z Sen" +
    "shi Son Goku no Chi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 109);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // sampleImg
            // 
            this.sampleImg.BackColor = System.Drawing.Color.White;
            this.sampleImg.Location = new System.Drawing.Point(0, 0);
            this.sampleImg.Name = "sampleImg";
            this.sampleImg.Size = new System.Drawing.Size(226, 109);
            this.sampleImg.TabIndex = 3;
            this.sampleImg.TabStop = false;
            // 
            // logoLbl
            // 
            this.logoLbl.Image = global::AnimeScrapper.Properties.Resources.sampleLogo;
            this.logoLbl.Location = new System.Drawing.Point(21, 32);
            this.logoLbl.Name = "logoLbl";
            this.logoLbl.Size = new System.Drawing.Size(48, 32);
            this.logoLbl.TabIndex = 1;
            // 
            // searchTb
            // 
            this.searchTb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchTb.Location = new System.Drawing.Point(75, 31);
            this.searchTb.Name = "searchTb";
            this.searchTb.PromptText = "Search Anime Here . . . . .";
            this.searchTb.Size = new System.Drawing.Size(304, 35);
            this.searchTb.TabIndex = 0;
            this.searchTb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.searchTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTb_KeyPress);
            // 
            // AnimeInformationPanel
            // 
            this.AnimeInformationPanel.BackColor = System.Drawing.Color.Transparent;
            this.AnimeInformationPanel.Controls.Add(this.nextBtn);
            this.AnimeInformationPanel.Controls.Add(this.yearReleasedLbl);
            this.AnimeInformationPanel.Controls.Add(this.coverImagePb);
            this.AnimeInformationPanel.Controls.Add(this.statusLbl);
            this.AnimeInformationPanel.Controls.Add(this.descriptionLbl);
            this.AnimeInformationPanel.Controls.Add(this.label10);
            this.AnimeInformationPanel.Controls.Add(this.titleLbl);
            this.AnimeInformationPanel.Controls.Add(this.label9);
            this.AnimeInformationPanel.Controls.Add(this.genreLbl);
            this.AnimeInformationPanel.Controls.Add(this.label8);
            this.AnimeInformationPanel.Controls.Add(this.animeInfoGoBackBtn);
            this.AnimeInformationPanel.Location = new System.Drawing.Point(0, 0);
            this.AnimeInformationPanel.Name = "AnimeInformationPanel";
            this.AnimeInformationPanel.Size = new System.Drawing.Size(787, 513);
            this.AnimeInformationPanel.TabIndex = 4;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(658, 22);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(111, 31);
            this.nextBtn.TabIndex = 28;
            this.nextBtn.Text = "Next >>";
            this.nextBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // yearReleasedLbl
            // 
            this.yearReleasedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearReleasedLbl.ForeColor = System.Drawing.Color.White;
            this.yearReleasedLbl.Location = new System.Drawing.Point(156, 424);
            this.yearReleasedLbl.Name = "yearReleasedLbl";
            this.yearReleasedLbl.Size = new System.Drawing.Size(613, 24);
            this.yearReleasedLbl.TabIndex = 27;
            this.yearReleasedLbl.Text = "2018";
            // 
            // coverImagePb
            // 
            this.coverImagePb.BackColor = System.Drawing.Color.White;
            this.coverImagePb.Location = new System.Drawing.Point(16, 113);
            this.coverImagePb.Name = "coverImagePb";
            this.coverImagePb.Size = new System.Drawing.Size(285, 169);
            this.coverImagePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverImagePb.TabIndex = 19;
            this.coverImagePb.TabStop = false;
            // 
            // statusLbl
            // 
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.Color.White;
            this.statusLbl.Location = new System.Drawing.Point(156, 377);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(613, 24);
            this.statusLbl.TabIndex = 26;
            this.statusLbl.Text = "Completed";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.ForeColor = System.Drawing.Color.White;
            this.descriptionLbl.Location = new System.Drawing.Point(311, 113);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(458, 207);
            this.descriptionLbl.TabIndex = 20;
            this.descriptionLbl.Text = resources.GetString("descriptionLbl.Text");
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Year Released : ";
            // 
            // titleLbl
            // 
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(16, 67);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(753, 39);
            this.titleLbl.TabIndex = 21;
            this.titleLbl.Text = "DUNGEON NI DEAI WO MOTOMERU NO WA MACHIGATTEIRU DAROU KA";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(37, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "                  Genre : ";
            // 
            // genreLbl
            // 
            this.genreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLbl.ForeColor = System.Drawing.Color.White;
            this.genreLbl.Location = new System.Drawing.Point(156, 330);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(613, 38);
            this.genreLbl.TabIndex = 22;
            this.genreLbl.Text = "Comedy, Ecchi, Harem, Romance, Sci Fi, Shounen, Slice Of Life, Aliens, Love Trian" +
    "gle, Nudity";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "                  Status : ";
            // 
            // animeInfoGoBackBtn
            // 
            this.animeInfoGoBackBtn.Location = new System.Drawing.Point(16, 22);
            this.animeInfoGoBackBtn.Name = "animeInfoGoBackBtn";
            this.animeInfoGoBackBtn.Size = new System.Drawing.Size(111, 31);
            this.animeInfoGoBackBtn.TabIndex = 18;
            this.animeInfoGoBackBtn.Text = "<< Go Back";
            this.animeInfoGoBackBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.animeInfoGoBackBtn.Click += new System.EventHandler(this.animeInfoGoBackBtn_Click);
            // 
            // ScrapePanel
            // 
            this.ScrapePanel.BackColor = System.Drawing.Color.Transparent;
            this.ScrapePanel.Controls.Add(this.panel1);
            this.ScrapePanel.Controls.Add(this.label12);
            this.ScrapePanel.Controls.Add(this.label7);
            this.ScrapePanel.Controls.Add(this.label6);
            this.ScrapePanel.Controls.Add(this.epToBeScrappedPnl);
            this.ScrapePanel.Controls.Add(this.label5);
            this.ScrapePanel.Controls.Add(this.scrapeGoBackBtn);
            this.ScrapePanel.Controls.Add(this.metroTextBox1);
            this.ScrapePanel.Location = new System.Drawing.Point(0, 0);
            this.ScrapePanel.Name = "ScrapePanel";
            this.ScrapePanel.Size = new System.Drawing.Size(787, 513);
            this.ScrapePanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(16, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 320);
            this.panel1.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(8, 8);
            this.label13.MaximumSize = new System.Drawing.Size(340, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 270);
            this.label13.TabIndex = 5;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(430, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(321, 41);
            this.label12.TabIndex = 24;
            this.label12.Text = "Hint : \' - \' (dash) character means \'to\', while \' , \' (comma) character means \'an" +
    "d\'";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(430, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 27);
            this.label7.TabIndex = 23;
            this.label7.Text = "STATUS PANEL :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(143, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "STATUS PANEL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epToBeScrappedPnl
            // 
            this.epToBeScrappedPnl.AutoScroll = true;
            this.epToBeScrappedPnl.Controls.Add(this.label11);
            this.epToBeScrappedPnl.Location = new System.Drawing.Point(433, 250);
            this.epToBeScrappedPnl.Name = "epToBeScrappedPnl";
            this.epToBeScrappedPnl.Size = new System.Drawing.Size(318, 233);
            this.epToBeScrappedPnl.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.MaximumSize = new System.Drawing.Size(366, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 270);
            this.label11.TabIndex = 5;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(430, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "EPISODE/S YOU\'VE WANTED TO SCRAPE :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scrapeGoBackBtn
            // 
            this.scrapeGoBackBtn.Location = new System.Drawing.Point(16, 22);
            this.scrapeGoBackBtn.Name = "scrapeGoBackBtn";
            this.scrapeGoBackBtn.Size = new System.Drawing.Size(111, 31);
            this.scrapeGoBackBtn.TabIndex = 19;
            this.scrapeGoBackBtn.Text = "<< Go Back";
            this.scrapeGoBackBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scrapeGoBackBtn.Click += new System.EventHandler(this.scrapeGoBackBtn_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.Location = new System.Drawing.Point(433, 112);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "Search Anime Here . . . . .";
            this.metroTextBox1.Size = new System.Drawing.Size(318, 35);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AnimeScrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(785, 509);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.ScrapePanel);
            this.Controls.Add(this.AnimeInformationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnimeScrapper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anime Download Link Scrapper";
            this.SearchPanel.ResumeLayout(false);
            this.searchResultPnl.ResumeLayout(false);
            this.searchResultPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleImg)).EndInit();
            this.AnimeInformationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coverImagePb)).EndInit();
            this.ScrapePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.epToBeScrappedPnl.ResumeLayout(false);
            this.epToBeScrappedPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private MetroFramework.Controls.MetroTextBox searchTb;
        private System.Windows.Forms.Label logoLbl;
        private System.Windows.Forms.Panel searchResultPnl;
        private System.Windows.Forms.PictureBox sampleImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel AnimeInformationPanel;
        private MetroFramework.Controls.MetroButton animeInfoGoBackBtn;
        private MetroFramework.Controls.MetroButton nextBtn;
        private System.Windows.Forms.Label yearReleasedLbl;
        private System.Windows.Forms.PictureBox coverImagePb;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroCheckBox displayImagesChk;
        private System.Windows.Forms.Panel ScrapePanel;
        private MetroFramework.Controls.MetroButton scrapeGoBackBtn;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel epToBeScrappedPnl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
    }
}


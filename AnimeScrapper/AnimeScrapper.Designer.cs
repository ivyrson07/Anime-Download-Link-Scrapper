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
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.logoLbl = new System.Windows.Forms.Label();
            this.searchTb = new MetroFramework.Controls.MetroTextBox();
            this.searchResultPnl = new System.Windows.Forms.Panel();
            this.sampleImg = new System.Windows.Forms.PictureBox();
            this.SearchPanel.SuspendLayout();
            this.searchResultPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleImg)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.Controls.Add(this.searchResultPnl);
            this.SearchPanel.Controls.Add(this.logoLbl);
            this.SearchPanel.Controls.Add(this.searchTb);
            this.SearchPanel.Location = new System.Drawing.Point(0, -2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(787, 513);
            this.SearchPanel.TabIndex = 0;
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
            // searchResultPnl
            // 
            this.searchResultPnl.Controls.Add(this.sampleImg);
            this.searchResultPnl.Location = new System.Drawing.Point(75, 100);
            this.searchResultPnl.Name = "searchResultPnl";
            this.searchResultPnl.Size = new System.Drawing.Size(646, 62);
            this.searchResultPnl.TabIndex = 3;
            // 
            // sampleImg
            // 
            this.sampleImg.Location = new System.Drawing.Point(0, 0);
            this.sampleImg.Name = "sampleImg";
            this.sampleImg.Size = new System.Drawing.Size(226, 109);
            this.sampleImg.TabIndex = 3;
            this.sampleImg.TabStop = false;
            // 
            // AnimeScrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(785, 509);
            this.Controls.Add(this.SearchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnimeScrapper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anime Download Link Scrapper";
            this.SearchPanel.ResumeLayout(false);
            this.searchResultPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private MetroFramework.Controls.MetroTextBox searchTb;
        private System.Windows.Forms.Label logoLbl;
        private System.Windows.Forms.Panel searchResultPnl;
        private System.Windows.Forms.PictureBox sampleImg;
    }
}


namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelAppID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxVideos = new System.Windows.Forms.ListBox();
            this.linkLabelVideos = new System.Windows.Forms.LinkLabel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabalFriends = new System.Windows.Forms.LinkLabel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.linkLabelGallery = new System.Windows.Forms.LinkLabel();
            this.listBoxGallery = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.linkLabelPosts = new System.Windows.Forms.LinkLabel();
            this.newTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelToken = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Nunito Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(38, 7);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 58);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Font = new System.Drawing.Font("Nunito Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(38, 73);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 49);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelAppID
            // 
            this.labelAppID.AutoSize = true;
            this.labelAppID.Font = new System.Drawing.Font("Nunito Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppID.Location = new System.Drawing.Point(22, 149);
            this.labelAppID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppID.Name = "labelAppID";
            this.labelAppID.Size = new System.Drawing.Size(89, 31);
            this.labelAppID.TabIndex = 53;
            this.labelAppID.Text = "AppID:";
            this.labelAppID.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1894, 960);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelToken);
            this.tabPage1.Controls.Add(this.listBoxVideos);
            this.tabPage1.Controls.Add(this.linkLabelVideos);
            this.tabPage1.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.linkLabelInfo);
            this.tabPage1.Controls.Add(this.linkLabalFriends);
            this.tabPage1.Controls.Add(this.listBoxFriends);
            this.tabPage1.Controls.Add(this.listBoxInfo);
            this.tabPage1.Controls.Add(this.pictureBoxPost);
            this.tabPage1.Controls.Add(this.linkLabelGallery);
            this.tabPage1.Controls.Add(this.listBoxGallery);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.linkLabelPosts);
            this.tabPage1.Controls.Add(this.newTextBox);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.labelAppID);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1886, 921);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // listBoxVideos
            // 
            this.listBoxVideos.Font = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVideos.FormattingEnabled = true;
            this.listBoxVideos.ItemHeight = 31;
            this.listBoxVideos.Location = new System.Drawing.Point(784, 317);
            this.listBoxVideos.Name = "listBoxVideos";
            this.listBoxVideos.Size = new System.Drawing.Size(327, 314);
            this.listBoxVideos.TabIndex = 71;
            this.listBoxVideos.SelectedIndexChanged += new System.EventHandler(this.listBoxVideos_SelectedIndexChanged);
            // 
            // linkLabelVideos
            // 
            this.linkLabelVideos.AutoSize = true;
            this.linkLabelVideos.Font = new System.Drawing.Font("Nunito Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelVideos.Location = new System.Drawing.Point(796, 265);
            this.linkLabelVideos.Name = "linkLabelVideos";
            this.linkLabelVideos.Size = new System.Drawing.Size(151, 31);
            this.linkLabelVideos.TabIndex = 70;
            this.linkLabelVideos.TabStop = true;
            this.linkLabelVideos.Text = "Fetch Videos";
            this.linkLabelVideos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVideos_LinkClicked);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(784, 650);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(345, 254);
            this.axWindowsMediaPlayer1.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1543, 673);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 218);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabelInfo
            // 
            this.linkLabelInfo.AutoSize = true;
            this.linkLabelInfo.Font = new System.Drawing.Font("Nunito Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelInfo.Location = new System.Drawing.Point(32, 265);
            this.linkLabelInfo.Name = "linkLabelInfo";
            this.linkLabelInfo.Size = new System.Drawing.Size(120, 31);
            this.linkLabelInfo.TabIndex = 67;
            this.linkLabelInfo.TabStop = true;
            this.linkLabelInfo.Text = "Fetch Info";
            this.linkLabelInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfo_LinkClicked);
            // 
            // linkLabalFriends
            // 
            this.linkLabalFriends.AutoSize = true;
            this.linkLabalFriends.Font = new System.Drawing.Font("Nunito Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabalFriends.Location = new System.Drawing.Point(1178, 265);
            this.linkLabalFriends.Name = "linkLabalFriends";
            this.linkLabalFriends.Size = new System.Drawing.Size(157, 31);
            this.linkLabalFriends.TabIndex = 66;
            this.linkLabalFriends.TabStop = true;
            this.linkLabalFriends.Text = "Fetch Friends";
            this.linkLabalFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabalFriends_LinkClicked);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Font = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 31;
            this.listBoxFriends.Location = new System.Drawing.Point(1184, 317);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(275, 314);
            this.listBoxFriends.TabIndex = 65;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Font = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 31;
            this.listBoxInfo.Location = new System.Drawing.Point(28, 317);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(301, 345);
            this.listBoxInfo.TabIndex = 63;
            this.listBoxInfo.SelectedIndexChanged += new System.EventHandler(this.listBoxAbout_SelectedIndexChanged);
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Location = new System.Drawing.Point(367, 697);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(313, 194);
            this.pictureBoxPost.TabIndex = 62;
            this.pictureBoxPost.TabStop = false;
            // 
            // linkLabelGallery
            // 
            this.linkLabelGallery.AutoSize = true;
            this.linkLabelGallery.Font = new System.Drawing.Font("Nunito Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGallery.Location = new System.Drawing.Point(1511, 259);
            this.linkLabelGallery.Name = "linkLabelGallery";
            this.linkLabelGallery.Size = new System.Drawing.Size(157, 31);
            this.linkLabelGallery.TabIndex = 61;
            this.linkLabelGallery.TabStop = true;
            this.linkLabelGallery.Text = "Fetch Gallery";
            this.linkLabelGallery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGallery_LinkClicked);
            // 
            // listBoxGallery
            // 
            this.listBoxGallery.Font = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGallery.FormattingEnabled = true;
            this.listBoxGallery.ItemHeight = 31;
            this.listBoxGallery.Location = new System.Drawing.Point(1510, 322);
            this.listBoxGallery.Name = "listBoxGallery";
            this.listBoxGallery.Size = new System.Drawing.Size(292, 314);
            this.listBoxGallery.TabIndex = 60;
            this.listBoxGallery.SelectedIndexChanged += new System.EventHandler(this.listBoxGallery_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Nunito", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 31;
            this.listBoxPosts.Location = new System.Drawing.Point(367, 315);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(377, 345);
            this.listBoxPosts.TabIndex = 59;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // linkLabelPosts
            // 
            this.linkLabelPosts.AutoSize = true;
            this.linkLabelPosts.Font = new System.Drawing.Font("Nunito Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPosts.Location = new System.Drawing.Point(361, 265);
            this.linkLabelPosts.Name = "linkLabelPosts";
            this.linkLabelPosts.Size = new System.Drawing.Size(137, 31);
            this.linkLabelPosts.TabIndex = 58;
            this.linkLabelPosts.TabStop = true;
            this.linkLabelPosts.Text = "Fetch Posts";
            this.linkLabelPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPosts_LinkClicked);
            // 
            // newTextBox
            // 
            this.newTextBox.Location = new System.Drawing.Point(118, 198);
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.Size = new System.Drawing.Size(237, 32);
            this.newTextBox.TabIndex = 56;
            this.newTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(396, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(148, 123);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(118, 148);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 32);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "917683610037169";
            this.textBoxAppID.TextChanged += new System.EventHandler(this.textBoxAppID_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1886, 921);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Font = new System.Drawing.Font("Nunito Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToken.Location = new System.Drawing.Point(34, 198);
            this.labelToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(83, 31);
            this.labelToken.TabIndex = 72;
            this.labelToken.Text = "Token:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 960);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label labelAppID;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox newTextBox;
        private System.Windows.Forms.LinkLabel linkLabelPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkLabelGallery;
        private System.Windows.Forms.ListBox listBoxGallery;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.LinkLabel linkLabalFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.LinkLabel linkLabelInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelVideos;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBoxVideos;
        private System.Windows.Forms.Label labelToken;
    }
}


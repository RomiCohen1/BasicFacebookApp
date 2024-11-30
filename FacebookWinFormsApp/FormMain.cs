using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Runtime.Remoting.Messaging;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        FacebookWrapper.LoginResult m_LoginResult;
        User m_LoggedInUser;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }


        private void login()
        {
            m_LoginResult = FacebookService.Login(
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile",
                "user_photos",
                "user_posts",
                "user_friends",
                "user_location",
                "user_birthday",
                "user_hometown",
                "user_gender",
                "user_videos"
                /// add any relevant permissions
                );
            //String AccessToken = "";
            //m_LoginResult = FacebookService.Connect(AccessToken);


            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                newTextBox.Text = m_LoginResult.AccessToken;
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
        }

        private bool validateLoggedInUser()
        {
            if (m_LoggedInUser == null)
            {
                MessageBox.Show("Please log in first.");
                return false;
            }

            return true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAppID_TextChanged(object sender, EventArgs e)
        {

        }


        private void linkLabelPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!validateLoggedInUser()) return;
            fetchPosts();
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();
            listBoxPosts.DisplayMember = "Message";

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post);
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selectedPost = listBoxPosts.SelectedItem as Post;
            if (selectedPost != null && selectedPost.PictureURL != null)
            {
                pictureBoxPost.ImageLocation = selectedPost.PictureURL;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxGallery_SelectedIndexChanged(object sender, EventArgs e)
        {
            Photo selectedPhoto = listBoxGallery.SelectedItem as Photo;
            if (selectedPhoto != null && selectedPhoto.PictureAlbumURL != null)
                pictureBox1.ImageLocation = selectedPhoto.PictureAlbumURL;
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBoxAbout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!validateLoggedInUser()) return;
            fetchInfo();
        }

        private void fetchInfo()
        {
            if (m_LoggedInUser.Name != null)
            {
                listBoxInfo.Items.Add("Name: " + m_LoggedInUser.Name);
            }

            if (m_LoggedInUser.Gender != null)
            {
                listBoxInfo.Items.Add("Gender: " + m_LoggedInUser.Gender);
            }

            if (m_LoggedInUser.Hometown != null)
            {
                listBoxInfo.Items.Add("Hometown: " + m_LoggedInUser.Hometown);
            }

            if (m_LoggedInUser.Birthday != null)
            {
                listBoxInfo.Items.Add("Birthday: " + m_LoggedInUser.Birthday);
            }

            if (m_LoggedInUser.Email != null)
            {
                listBoxInfo.Items.Add("Email: " + m_LoggedInUser.Email);
            }

        }

        private void linkLabalFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!validateLoggedInUser()) return;
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (friend != null)
                {
                    listBoxFriends.Items.Add(friend.Name);
                }
            }

            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show("No Friends using this app were found :(");
            }
        }

        private void linkLabelGallery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!validateLoggedInUser()) return;
            fetchPhotos();
        }

        private void fetchPhotos()
        {
            listBoxGallery.DisplayMember = "ToString";

            if (m_LoggedInUser.Albums != null)
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    foreach(Photo photo in album.Photos)
                    {
                        if (photo != null)
                        {
                            listBoxGallery.Items.Add(photo);
                        }
                    }
                }
            }
        }

        private void fetchVideos()
        {
            listBoxVideos.Items.Clear();
            listBoxPosts.DisplayMember = "Name";

            if (m_LoggedInUser.Videos != null)
            {
                foreach (Video video in m_LoggedInUser.Videos)
                {
                    listBoxVideos.Items.Add(video);
                }
            }

            if (listBoxVideos.Items.Count == 0)
            {
                MessageBox.Show($"Videos count: {m_LoggedInUser.Videos.Count}. No video retrived");
            }
        }

        private void listBoxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Video video = listBoxVideos.SelectedItem as Video;
            try
            {
                if (video != null && video.URL != null)
                {
                    axWindowsMediaPlayer1.URL = video.URL;
                }
                else
                {
                    MessageBox.Show("Cannot play the selected video :(");
                }
            }
            catch (Exception ex) { }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelVideos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!validateLoggedInUser()) return;
            fetchVideos();
        }
    }
}

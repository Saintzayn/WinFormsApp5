namespace RollandKnow
{
    partial class Anamenü
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anamenü));
            PlayButtonlabel = new Label();
            QuitButtonlabel = new Label();
            ProfileButtonlabel = new Label();
            profilepicturebox1 = new PictureBox();
            pnl_MainMenu = new Panel();
            pnl_Profile = new Panel();
            AddFriendPictureBox = new PictureBox();
            flow_FriendList = new FlowLayoutPanel();
            SolvedHardestQ_label = new Label();
            Achievemnt_label = new Label();
            TotalScore_label = new Label();
            AverageScore_label = new Label();
            TotalPlay_label = new Label();
            BestScore_label = new Label();
            BadgePictureBox3 = new PictureBox();
            BadgePictureBox2 = new PictureBox();
            BadgePictureBox1 = new PictureBox();
            ProfileNickNamelabel = new Label();
            ProfileMenuPictureBox = new PictureBox();
            returnArrow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)profilepicturebox1).BeginInit();
            pnl_MainMenu.SuspendLayout();
            pnl_Profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddFriendPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BadgePictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BadgePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BadgePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfileMenuPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnArrow).BeginInit();
            SuspendLayout();
            // 
            // PlayButtonlabel
            // 
            PlayButtonlabel.BackColor = Color.Transparent;
            PlayButtonlabel.Cursor = Cursors.Hand;
            PlayButtonlabel.Location = new Point(377, 587);
            PlayButtonlabel.Name = "PlayButtonlabel";
            PlayButtonlabel.Size = new Size(201, 67);
            PlayButtonlabel.TabIndex = 5;
            PlayButtonlabel.Click += PlayButtonlabel_Click;
            PlayButtonlabel.Paint += Buton_Paint;
            PlayButtonlabel.MouseEnter += Buton_MouseEnter;
            PlayButtonlabel.MouseLeave += Buton_MouseLeave;
            // 
            // QuitButtonlabel
            // 
            QuitButtonlabel.BackColor = Color.Transparent;
            QuitButtonlabel.Cursor = Cursors.Hand;
            QuitButtonlabel.Location = new Point(377, 675);
            QuitButtonlabel.Name = "QuitButtonlabel";
            QuitButtonlabel.Size = new Size(201, 65);
            QuitButtonlabel.TabIndex = 6;
            QuitButtonlabel.Click += QuitButtonlabel_Click;
            QuitButtonlabel.Paint += Buton_Paint;
            QuitButtonlabel.MouseEnter += Buton_MouseEnter;
            QuitButtonlabel.MouseLeave += Buton_MouseLeave;
            // 
            // ProfileButtonlabel
            // 
            ProfileButtonlabel.BackColor = Color.Transparent;
            ProfileButtonlabel.Cursor = Cursors.Hand;
            ProfileButtonlabel.Location = new Point(788, 21);
            ProfileButtonlabel.Name = "ProfileButtonlabel";
            ProfileButtonlabel.Size = new Size(173, 32);
            ProfileButtonlabel.TabIndex = 7;
            ProfileButtonlabel.Click += OpenProfile_Click;
            // 
            // profilepicturebox1
            // 
            profilepicturebox1.Cursor = Cursors.Hand;
            profilepicturebox1.Location = new Point(729, 6);
            profilepicturebox1.Name = "profilepicturebox1";
            profilepicturebox1.Size = new Size(65, 65);
            profilepicturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
            profilepicturebox1.TabIndex = 8;
            profilepicturebox1.TabStop = false;
            profilepicturebox1.Click += OpenProfile_Click;
            // 
            // pnl_MainMenu
            // 
            pnl_MainMenu.BackColor = Color.Transparent;
            pnl_MainMenu.BackgroundImage = (Image)resources.GetObject("pnl_MainMenu.BackgroundImage");
            pnl_MainMenu.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_MainMenu.Controls.Add(QuitButtonlabel);
            pnl_MainMenu.Controls.Add(PlayButtonlabel);
            pnl_MainMenu.Controls.Add(profilepicturebox1);
            pnl_MainMenu.Controls.Add(ProfileButtonlabel);
            pnl_MainMenu.Location = new Point(909, 3);
            pnl_MainMenu.Name = "pnl_MainMenu";
            pnl_MainMenu.Size = new Size(964, 783);
            pnl_MainMenu.TabIndex = 5;
            // 
            // pnl_Profile
            // 
            pnl_Profile.BackColor = Color.Black;
            pnl_Profile.BackgroundImage = (Image)resources.GetObject("pnl_Profile.BackgroundImage");
            pnl_Profile.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Profile.Controls.Add(pnl_MainMenu);
            pnl_Profile.Controls.Add(AddFriendPictureBox);
            pnl_Profile.Controls.Add(flow_FriendList);
            pnl_Profile.Controls.Add(SolvedHardestQ_label);
            pnl_Profile.Controls.Add(Achievemnt_label);
            pnl_Profile.Controls.Add(TotalScore_label);
            pnl_Profile.Controls.Add(AverageScore_label);
            pnl_Profile.Controls.Add(TotalPlay_label);
            pnl_Profile.Controls.Add(BestScore_label);
            pnl_Profile.Controls.Add(BadgePictureBox3);
            pnl_Profile.Controls.Add(BadgePictureBox2);
            pnl_Profile.Controls.Add(BadgePictureBox1);
            pnl_Profile.Controls.Add(ProfileNickNamelabel);
            pnl_Profile.Controls.Add(ProfileMenuPictureBox);
            pnl_Profile.Controls.Add(returnArrow);
            pnl_Profile.Dock = DockStyle.Fill;
            pnl_Profile.Location = new Point(0, 0);
            pnl_Profile.Name = "pnl_Profile";
            pnl_Profile.Size = new Size(964, 783);
            pnl_Profile.TabIndex = 6;
            pnl_Profile.Visible = false;
            pnl_Profile.Paint += pnl_Profile_Paint;
            // 
            // AddFriendPictureBox
            // 
            AddFriendPictureBox.BackColor = Color.Transparent;
            AddFriendPictureBox.BackgroundImage = (Image)resources.GetObject("AddFriendPictureBox.BackgroundImage");
            AddFriendPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            AddFriendPictureBox.Cursor = Cursors.Hand;
            AddFriendPictureBox.ErrorImage = null;
            AddFriendPictureBox.Location = new Point(353, 403);
            AddFriendPictureBox.Name = "AddFriendPictureBox";
            AddFriendPictureBox.Size = new Size(40, 40);
            AddFriendPictureBox.TabIndex = 20;
            AddFriendPictureBox.TabStop = false;
            // 
            // flow_FriendList
            // 
            flow_FriendList.AutoScroll = true;
            flow_FriendList.BackColor = Color.Transparent;
            flow_FriendList.FlowDirection = FlowDirection.TopDown;
            flow_FriendList.Location = new Point(33, 449);
            flow_FriendList.Name = "flow_FriendList";
            flow_FriendList.Size = new Size(895, 295);
            flow_FriendList.TabIndex = 19;
            flow_FriendList.WrapContents = false;
            // 
            // SolvedHardestQ_label
            // 
            SolvedHardestQ_label.BackColor = Color.Transparent;
            SolvedHardestQ_label.Font = new Font("Segoe UI", 15F);
            SolvedHardestQ_label.ForeColor = Color.White;
            SolvedHardestQ_label.Location = new Point(811, 287);
            SolvedHardestQ_label.Name = "SolvedHardestQ_label";
            SolvedHardestQ_label.Size = new Size(124, 28);
            SolvedHardestQ_label.TabIndex = 18;
            SolvedHardestQ_label.Text = "15";
            // 
            // Achievemnt_label
            // 
            Achievemnt_label.BackColor = Color.Transparent;
            Achievemnt_label.Cursor = Cursors.Hand;
            Achievemnt_label.Font = new Font("Segoe UI", 15F);
            Achievemnt_label.ForeColor = Color.White;
            Achievemnt_label.Location = new Point(811, 326);
            Achievemnt_label.Name = "Achievemnt_label";
            Achievemnt_label.Size = new Size(124, 28);
            Achievemnt_label.TabIndex = 17;
            Achievemnt_label.Text = "15/72";
            Achievemnt_label.Click += Achievemnt_label_Click_1;
            // 
            // TotalScore_label
            // 
            TotalScore_label.BackColor = Color.Transparent;
            TotalScore_label.Font = new Font("Segoe UI", 15F);
            TotalScore_label.ForeColor = Color.White;
            TotalScore_label.Location = new Point(811, 247);
            TotalScore_label.Name = "TotalScore_label";
            TotalScore_label.Size = new Size(124, 28);
            TotalScore_label.TabIndex = 16;
            TotalScore_label.Text = "1556345";
            // 
            // AverageScore_label
            // 
            AverageScore_label.BackColor = Color.Transparent;
            AverageScore_label.Font = new Font("Segoe UI", 15F);
            AverageScore_label.ForeColor = Color.White;
            AverageScore_label.Location = new Point(310, 326);
            AverageScore_label.Name = "AverageScore_label";
            AverageScore_label.Size = new Size(165, 28);
            AverageScore_label.TabIndex = 15;
            AverageScore_label.Text = "8436";
            // 
            // TotalPlay_label
            // 
            TotalPlay_label.BackColor = Color.Transparent;
            TotalPlay_label.Font = new Font("Segoe UI", 15F);
            TotalPlay_label.ForeColor = Color.White;
            TotalPlay_label.Location = new Point(310, 288);
            TotalPlay_label.Name = "TotalPlay_label";
            TotalPlay_label.Size = new Size(165, 28);
            TotalPlay_label.TabIndex = 14;
            TotalPlay_label.Text = "15";
            // 
            // BestScore_label
            // 
            BestScore_label.BackColor = Color.Transparent;
            BestScore_label.Font = new Font("Segoe UI", 15F);
            BestScore_label.ForeColor = Color.White;
            BestScore_label.Location = new Point(310, 247);
            BestScore_label.Name = "BestScore_label";
            BestScore_label.Size = new Size(165, 28);
            BestScore_label.TabIndex = 13;
            // 
            // BadgePictureBox3
            // 
            BadgePictureBox3.BackColor = Color.Transparent;
            BadgePictureBox3.Cursor = Cursors.Hand;
            BadgePictureBox3.Location = new Point(836, 77);
            BadgePictureBox3.Name = "BadgePictureBox3";
            BadgePictureBox3.Size = new Size(99, 93);
            BadgePictureBox3.TabIndex = 12;
            BadgePictureBox3.TabStop = false;
            // 
            // BadgePictureBox2
            // 
            BadgePictureBox2.BackColor = Color.Transparent;
            BadgePictureBox2.Cursor = Cursors.Hand;
            BadgePictureBox2.Location = new Point(734, 77);
            BadgePictureBox2.Name = "BadgePictureBox2";
            BadgePictureBox2.Size = new Size(99, 93);
            BadgePictureBox2.TabIndex = 11;
            BadgePictureBox2.TabStop = false;
            // 
            // BadgePictureBox1
            // 
            BadgePictureBox1.BackColor = Color.Transparent;
            BadgePictureBox1.Cursor = Cursors.Hand;
            BadgePictureBox1.Location = new Point(633, 77);
            BadgePictureBox1.Name = "BadgePictureBox1";
            BadgePictureBox1.Size = new Size(99, 93);
            BadgePictureBox1.TabIndex = 10;
            BadgePictureBox1.TabStop = false;
            // 
            // ProfileNickNamelabel
            // 
            ProfileNickNamelabel.BackColor = Color.Transparent;
            ProfileNickNamelabel.Location = new Point(202, 74);
            ProfileNickNamelabel.Name = "ProfileNickNamelabel";
            ProfileNickNamelabel.Size = new Size(352, 93);
            ProfileNickNamelabel.TabIndex = 9;
            // 
            // ProfileMenuPictureBox
            // 
            ProfileMenuPictureBox.BackColor = Color.Transparent;
            ProfileMenuPictureBox.Cursor = Cursors.Hand;
            ProfileMenuPictureBox.Location = new Point(42, 45);
            ProfileMenuPictureBox.Name = "ProfileMenuPictureBox";
            ProfileMenuPictureBox.Size = new Size(154, 154);
            ProfileMenuPictureBox.TabIndex = 8;
            ProfileMenuPictureBox.TabStop = false;
            // 
            // returnArrow
            // 
            returnArrow.BackColor = Color.Transparent;
            returnArrow.BackgroundImage = (Image)resources.GetObject("returnArrow.BackgroundImage");
            returnArrow.BackgroundImageLayout = ImageLayout.Stretch;
            returnArrow.Cursor = Cursors.Hand;
            returnArrow.Location = new Point(0, 0);
            returnArrow.Name = "returnArrow";
            returnArrow.Size = new Size(40, 40);
            returnArrow.TabIndex = 7;
            returnArrow.TabStop = false;
            returnArrow.Click += returnArrow_Click;
            // 
            // Anamenü
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 783);
            Controls.Add(pnl_Profile);
            Name = "Anamenü";
            Load += FormMainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)profilepicturebox1).EndInit();
            pnl_MainMenu.ResumeLayout(false);
            pnl_Profile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AddFriendPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BadgePictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BadgePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BadgePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfileMenuPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnArrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label PlayButtonlabel;
        private Label QuitButtonlabel;
        private Label ProfileButtonlabel;
        private PictureBox profilepicturebox1;
        private Panel pnl_MainMenu;
        private Panel pnl_Profile;
        private PictureBox returnArrow;
        private PictureBox ProfileMenuPictureBox;
        private Label ProfileNickNamelabel;
        private PictureBox BadgePictureBox1;
        private PictureBox BadgePictureBox3;
        private PictureBox BadgePictureBox2;
        private Label AverageScore_label;
        private Label TotalPlay_label;
        private Label BestScore_label;
        private Label SolvedHardestQ_label;
        private Label Achievemnt_label;
        private Label TotalScore_label;
        private FlowLayoutPanel flow_FriendList;
        private PictureBox AddFriendPictureBox;
    }
}

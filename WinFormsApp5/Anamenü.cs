using Achievements;

namespace RollandKnow
{

    public partial class Anamenü : Form
    {

        public readonly User CurrentUser;
        public Anamenü(User currentUser)
        {
            InitializeComponent();
            this.CurrentUser = currentUser;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            // Ensure main menu is a direct child of the form (not nested under pnl_Profile)
            // This fixes the issue where pnl_MainMenu remains hidden because its parent is invisible.
            if (pnl_MainMenu.Parent != this)
            {
                pnl_MainMenu.Parent = this;
                pnl_MainMenu.BringToFront();
            }

            MakePictureBoxRound(profilepicturebox1); // Make profile picture round

            MakePictureBoxRoundArrow(returnArrow); // Make return arrow pic round

            MakePictureBoxRoundArrow(AddFriendPictureBox);

            MakePictureBoxRound(ProfileMenuPictureBox);

            MakePictureBoxRound(BadgePictureBox1);

            MakePictureBoxRound(BadgePictureBox2);

            MakePictureBoxRound(BadgePictureBox3);

            AddFriend("Ege Çalışkan", "12000");
            AddFriend("Suat Eray Dereli", "15000");


            pnl_Profile.Visible = false;
            pnl_MainMenu.Visible = true;

            pnl_Profile.Dock = DockStyle.Fill;
            pnl_MainMenu.Dock = DockStyle.Fill;
            int UnlockedCount = 0;
            foreach (int UnlockedAchievement in CurrentUser.UnlockedAchievements)
            {
                if (UnlockedAchievement == 1)
                {
                    UnlockedCount++;
                }
            }
            BestScore_label.Text = $"{CurrentUser.highScore}";
            TotalScore_label.Text = $"{CurrentUser.TotalScore}";
            AverageScore_label.Text = $"{CurrentUser.AverageScore}";
            TotalPlay_label.Text = $"{CurrentUser.TotalPlay}";
            Achievemnt_label.Text = $"{UnlockedCount}/{CurrentUser.UnlockedAchievements.Length}";
        }

        private void OpenProfile_Click(object sender, EventArgs e)
        {

            pnl_MainMenu.Visible = false;

            pnl_Profile.Visible = true;
        }

        private void AddFriend(string isim, string skor)
        {
            // 1. Her arkadaş için bir Şerit (Panel) oluştur
            Panel pnl_Line = new Panel();
            pnl_Line.Size = new Size(flow_FriendList.Width - 40, 40); // Genişlik panel kadar, yükseklik 40px
            pnl_Line.BackColor = Color.FromArgb(100, 0, 0, 0); // Yarı saydam siyah zemin (Okunabilirlik için)
            pnl_Line.Margin = new Padding(5); // Kutular arası boşluk

            // 2. Arkadaşın İsmi (Label)
            Label lbl_Name = new Label();
            lbl_Name.Text = isim;
            lbl_Name.ForeColor = Color.Gold;
            lbl_Name.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(10, 10); // Sol tarafa koy

            // 3. Arkadaşın Skoru (Label)
            Label lbl_Score = new Label();
            lbl_Score.Text = "Skor: " + skor;
            lbl_Score.ForeColor = Color.White;
            lbl_Score.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lbl_Score.AutoSize = true;
            lbl_Score.Location = new Point(pnl_Line.Width - 100, 10); // Sağ tarafa koy

            // 4. Parçaları birleştir
            pnl_Line.Controls.Add(lbl_Name);
            pnl_Line.Controls.Add(lbl_Score);

            // 5. Hazırlanan satırı ana listeye (FlowLayoutPanel) ekle
            flow_FriendList.Controls.Add(pnl_Line);
        }

        public void MakePictureBoxRound(PictureBox pb)
        {
            // Yuvarlak bir yol oluştur
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            // PictureBox'ın boyutlarında bir elips çiz (x, y, genişlik, yükseklik)
            gp.AddEllipse(0, 0, pb.Width - 7, pb.Height - 7);

            // PictureBox'ın görünür bölgesini bu elips yap
            pb.Region = new System.Drawing.Region(gp);
        }

        public void MakePictureBoxRoundArrow(PictureBox pb)
        {
            // Yuvarlak bir yol oluştur
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            // PictureBox'ın boyutlarında bir elips çiz (x, y, genişlik, yükseklik)
            gp.AddEllipse(0, 0, pb.Width - 1, pb.Height - 1);

            // PictureBox'ın görünür bölgesini bu elips yap
            pb.Region = new System.Drawing.Region(gp);
        }
        private void Buton_MouseEnter(object sender, EventArgs e)
        {
            // is mouse on the button (for all buttons)
            Label lbl = (Label)sender; // Catch the which button
            lbl.Tag = "Active";
            lbl.Invalidate();          // Redraw yourself
        }

        private void Buton_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.Tag = "Pasif";
            lbl.Invalidate();          // Redraw (to delete)
        }

        private void Buton_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender; // Which button 

            // If mouse on it ("Active") paint
            if (Convert.ToString(lbl.Tag) == "Active")
            {
                // Pen Color: Gold, Thickness: 3
                using (Pen kalem = new Pen(Color.Gold, 3))
                {
                    //Taking sizes of the button with lbl.Width and lbl.Height
                    e.Graphics.DrawRectangle(kalem, 1, 1, lbl.Width - 2, lbl.Height - 2);
                }
            }
        }

        private void ProfileButtonlabel_Click(object sender, EventArgs e)
        {

        }

        private void profilepicturebox1_Click(object sender, EventArgs e)
        {

        }

        private void QuitButtonlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_Profile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returnArrow_Click(object sender, EventArgs e)
        {
            pnl_Profile.Visible = false;
            pnl_MainMenu.Visible = true;
        }

        private void PlayButtonlabel_Click(object sender, EventArgs e)
        {
            Questionscreen questions = new Questionscreen(CurrentUser);


            questions.Show();


            this.Close();

        }

        private void Achievemnt_label_Click_1(object sender, EventArgs e)
        {
            AchievementsForm achs = new AchievementsForm(CurrentUser);

            achs.Show();

        }
    }
}

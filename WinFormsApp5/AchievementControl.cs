using System.ComponentModel;

namespace Achievements
{
    public partial class AchievementControl : UserControl
    {
        public AchievementControl()
        {
            InitializeComponent();
        }

        public void LoadAchievement(Achievement achievement)
        {
            labelTitle.Text = achievement.Name;
            labelDescription.Text = achievement.Description;

            if (!string.IsNullOrEmpty(achievement.ImagePath))
            {
                iconAchievementImage.Image = Image.FromFile(achievement.ImagePath);
            }

            if (achievement.IsUnlocked)
            {
                labelDateAchieved.Text = $"Unlocked: {achievement.DateAchieved:dd-MM-yyyy HH:mm}";

                this.BackColor = Color.FromArgb(220, 255, 220);
            }
            else
            {
                labelDateAchieved.Text = "Status: Locked";

                this.BackColor = Color.LightGray;
            }

        }

        private void BadgeSelectButton_Click(object sender, EventArgs e)
        {
            badgeSelect_Opening(sender, new CancelEventArgs());
        }

        private void badgeSelect_Opening(object sender, CancelEventArgs e)
        {
            badgeSelect.Show(BadgeSelectButton, new Point(0, BadgeSelectButton.Height));
        }

        private void badge1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void badge2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void badge3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

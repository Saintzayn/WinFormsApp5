using RollandKnow;

namespace Achievements
{
    public partial class AchievementsForm : Form
    {
        // List<Achievement>: Holds all achievements
        List<Achievement> achievements = new List<Achievement>();
        public readonly User LoadedUser;
        public AchievementsForm(User CurrentUser)
        {
            InitializeComponent();
            this.LoadedUser = CurrentUser;   // assign first to avoid DisplayAchievements using null
            InitializeAchievements();
        }

        private void InitializeAchievements()
        {
            achievements.Clear(); // ensure we don't keep previous entries if called multiple times

            achievements.Add(new Achievement("firstQuestion", "The Beginning!", "Solve your first Question.", ""));
            achievements.Add(new Achievement("fiveQuestions", "Getting Started!", "Solve 5 Questions.", ""));
            achievements.Add(new Achievement("tenQuestions", "On a Roll!", "Solve 10 Questions.", ""));
            achievements.Add(new Achievement("fiftyQuestions", "50 Shades of Knowledge!", "Solve 50 Questions.", ""));
            achievements.Add(new Achievement("hundredQuestions", "Century Club!", "Solve 100 Questions.", ""));
            achievements.Add(new Achievement("threehundredQuestions", "Quiz Master!", "Solve 300 Questions.", ""));
            DisplayAchievements();
        }

        private void UnlockAchievement(string id)
        {
            // Find method: Searches the list using the ID.
            Achievement ach = achievements.Find(a => a.ID == id);

            // Check if achievement exists AND is currently locked
            if (ach != null && !ach.IsUnlocked)
            {
                // Update the status
                ach.IsUnlocked = true;
                ach.DateAchieved = DateTime.Now;

                // Refresh the main list display to show the change
                DisplayAchievements();
            }
        }

        // Creates and displays the AchievementControl list in the flowLayoutPanel1
        private void DisplayAchievements()
        {
            // Clear old controls before drawing the new list
            flowLayoutPanel1.Controls.Clear();

            foreach (Achievement ach in achievements)
            {
                AchievementControl achControl = new AchievementControl();

                // Set control width
                achControl.Width = flowLayoutPanel1.ClientSize.Width - 30;

                // Load the data into the custom control
                achControl.LoadAchievement(ach);
                flowLayoutPanel1.Controls.Add(achControl);
            }
            if (LoadedUser.UnlockedAchievements[0] == 1)
            {
                UnlockAchievement("firstQuestion");
            }
            if (LoadedUser.UnlockedAchievements[1] == 1)
            {
                UnlockAchievement("fiveQuestions");
            }
            if (LoadedUser.UnlockedAchievements[2] == 1)
            {
                UnlockAchievement("tenQuestions");
            }
            if (LoadedUser.UnlockedAchievements[3] == 1)
            {
                UnlockAchievement("fiftyQuestions");
            }
            if (LoadedUser.UnlockedAchievements[4] == 1)
            {
                UnlockAchievement("hundredQuestions");
            }
            if (LoadedUser.UnlockedAchievements[5] == 1)
            {
                UnlockAchievement("threehundredQuestions");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
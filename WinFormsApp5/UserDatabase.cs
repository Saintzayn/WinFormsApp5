using Newtonsoft.Json;

namespace RollandKnow
{

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public int highScore { get; set; }
        public int TotalScore { get; set; }
        public int TotalPlay { get; set; }
        public int AverageScore { get; set; }
        public int SolvedQuestions { get; set; }
        public int[] UnlockedAchievements = [ 0, 0, 0, 0, 0, 0];
        public int[] AchievementUnlockedDate = [ 0, 0, 0, 0, 0, 0];
    }

        public static class UserDatabase
    {

        public static List<User> Users = new List<User>();


        private static readonly string DataFilePath = "users.json";


        public static void LoadUsers()
        {
            if (File.Exists(DataFilePath))
            {
                try
                {
                    string json = File.ReadAllText(DataFilePath);
                    var loadedUsers = JsonConvert.DeserializeObject<List<User>>(json);

                    if (loadedUsers != null)
                    {
                        Users = loadedUsers;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kullanıcı verileri yüklenirken bir hata oluştu: {ex.Message}", "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Users = new List<User>();
            }
        }


        public static void SaveUsers()
        {
            try
            {

                string json = JsonConvert.SerializeObject(Users, Formatting.Indented);

                File.WriteAllText(DataFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kullanıcı verileri kaydedilirken bir hata oluştu: {ex.Message}", "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void UpdateUser(User updatedUser)
        {
            var existingUser = Users.FirstOrDefault(u => u.username == updatedUser.username);
            if (existingUser != null)
            {
                existingUser.highScore = updatedUser.highScore;
                existingUser.TotalScore = updatedUser.TotalScore;
                existingUser.TotalPlay = updatedUser.TotalPlay;
                existingUser.AverageScore = updatedUser.AverageScore;
                existingUser.UnlockedAchievements = updatedUser.UnlockedAchievements;
                existingUser.SolvedQuestions = updatedUser.SolvedQuestions;
                existingUser.AchievementUnlockedDate = updatedUser.AchievementUnlockedDate;
                SaveUsers();
            }
        }


        public static void AddUser(User newUser)
        {
            Users.Add(newUser);
            SaveUsers();
        }
    }
}
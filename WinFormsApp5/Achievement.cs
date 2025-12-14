namespace Achievements
{
    public class Achievement
    {
        // Identifier for internal use
        public string ID { get; set; }

        // Information that the User sees
        public string Name { get; set; }
        public string Description { get; set; }

        // Status
        public bool IsUnlocked { get; set; }

        // Date and time when the achievement was unlocked
        public DateTime? DateAchieved { get; set; }

        // Path to the image representing the achievement
        public string? ImagePath { get; set; }

        // Whether the achievement can be selected for badge display
        public bool SelectableForBadge { get; set; }

        // Base constructor of the Achievement
        public Achievement(string id, string name, string description, string imagePath)
        {
            ID = id;
            Name = name;
            Description = description;
            ImagePath = imagePath;

            IsUnlocked = false;
            DateAchieved = null;
            SelectableForBadge = false;
        }
    }
}

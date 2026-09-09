namespace IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Sumalino_Sophia.Models
{
    public class ExamViewModel
    {
        // 👤 PLAYER INFORMATION
        public string PlayerName { get; set; } = "Sumalinog, Sophia";

        public string ClassSection { get; set; } = "BSIT31E3";

        public string PlayerTitle { get; set; } = "MVC EXAM HUNTER";


        // ⚔️ LEVEL SYSTEM
        public int Level { get; set; } = 1;

        public string Rank { get; set; } = "E";


        // ⭐ EXPERIENCE SYSTEM
        public int CurrentExp { get; set; } = 0;

        public int ExpRequired { get; set; } = 100;


        // 📜 QUEST SYSTEM
        public int CurrentQuest { get; set; } = 1;

        public int TotalQuests { get; set; } = 20;

        public int CompletedQuests { get; set; } = 0;


        // 🏆 PROGRESS
        public int ProgressPercentage
        {
            get
            {
                if (TotalQuests == 0)
                    return 0;

                return (CompletedQuests * 100) / TotalQuests;
            }
        }


        // ⭐ EXP PROGRESS
        public int ExpPercentage
        {
            get
            {
                if (ExpRequired == 0)
                    return 0;

                return (CurrentExp * 100) / ExpRequired;
            }
        }


        // 👑 SYSTEM STATUS
        public string SystemStatus { get; set; } = "AWAKENING...";

        public string CurrentQuestStatus { get; set; } = "LOCKED";


        // ⚔️ QUEST MESSAGE
        public string SystemMessage { get; set; } =
            "The System has recognized the Player.";
    }
}

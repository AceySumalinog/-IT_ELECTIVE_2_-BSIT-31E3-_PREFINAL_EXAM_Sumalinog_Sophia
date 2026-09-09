namespace IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Sumalinog_Sophia.Models
{
    public class Question
    {
        public int Id { get; set; }

        public int QuestNumber { get; set; }

        public string QuestTitle { get; set; } = string.Empty;

        public string QuestionText { get; set; } = string.Empty;

        public string ChoiceA { get; set; } = string.Empty;

        public string ChoiceB { get; set; } = string.Empty;

        public string ChoiceC { get; set; } = string.Empty;

        public string ChoiceD { get; set; } = string.Empty;

        public string CorrectAnswer { get; set; } = string.Empty;

        public string Explanation { get; set; } = string.Empty;

        public int ExpReward { get; set; } = 5;

        public string Rank { get; set; } = "E";

        public bool IsBossQuest { get; set; } = false;
    }
}

using IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Sumalinog_Sophia.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Sumalino_Sophia.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var player = new ExamViewModel
            {
                PlayerName = "Sumalino Sophia",
                ClassSection = "BSIT31E3",
                PlayerTitle = "MVC EXAM HUNTER",

                Level = 1,
                Rank = "E",

                CurrentExp = 0,
                ExpRequired = 100,

                CurrentQuest = 1,
                TotalQuests = 20,
                CompletedQuests = 0,

                SystemStatus = "AWAKENING...",
                CurrentQuestStatus = "LOCKED",

                SystemMessage =
                    "The System has recognized the Player."
            };

            return View(player);
        }

        public IActionResult Question()
        {
            ViewData["Title"] = "Quest 01";
            return View();
        }
    }
}

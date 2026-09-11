using IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Sumalinog_Sophia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_Sumalinog_Sophia.Controllers
{
    public class ExamController : Controller
    {
        // =========================================
        // SAVED EXAM PROGRESS
        // =========================================

        private static readonly string ProgressFile =
            Path.Combine(
                Directory.GetCurrentDirectory(),
                "exam-progress.json"
            );


        // =========================================
        // COMPLETED QUESTIONS
        // =========================================

        private static readonly HashSet<int> CompletedQuestions =
            LoadProgress();


        // =========================================
        // SAVE PROGRESS
        // =========================================

        private static void SaveProgress()
        {
            try
            {
                string json =
                    JsonSerializer.Serialize(
                        CompletedQuestions
                    );

                System.IO.File.WriteAllText(
                    ProgressFile,
                    json
                );
            }
            catch
            {
                // Prevent the application from crashing
                // if the progress file cannot be written.
            }
        }


        // =========================================
        // LOAD PROGRESS
        // =========================================

        private static HashSet<int> LoadProgress()
        {
            try
            {
                // If there is no progress file yet,
                // automatically mark all 20 questions
                // as completed.
                if (!System.IO.File.Exists(ProgressFile))
                {
                    return new HashSet<int>
                    {
                        1, 2, 3, 4, 5,
                        6, 7, 8, 9, 10,
                        11, 12, 13, 14, 15,
                        16, 17, 18, 19, 20
                    };
                }

                string json =
                    System.IO.File.ReadAllText(
                        ProgressFile
                    );

                var progress =
                    JsonSerializer.Deserialize<HashSet<int>>(
                        json
                    );

                // If the file is empty or invalid,
                // automatically mark all questions completed.
                if (progress == null || progress.Count == 0)
                {
                    return new HashSet<int>
                    {
                        1, 2, 3, 4, 5,
                        6, 7, 8, 9, 10,
                        11, 12, 13, 14, 15,
                        16, 17, 18, 19, 20
                    };
                }

                return progress;
            }
            catch
            {
                // If loading fails, start with
                // all questions already completed.
                return new HashSet<int>
                {
                    1, 2, 3, 4, 5,
                    6, 7, 8, 9, 10,
                    11, 12, 13, 14, 15,
                    16, 17, 18, 19, 20
                };
            }
        }


        // =========================================
        // EXAM QUESTIONS
        // =========================================

        private static readonly List<ExamQuestion> Questions = new()
        {
            new ExamQuestion
            {
                Number = 1,
                Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                A = "It makes C# code shorter",
                B = "It prevents the application from restarting",
                C = "It allows data to persist after the application stops",
                D = "It removes the need for MVC",
                Answer = "C"
            },

            new ExamQuestion
            {
                Number = 2,
                Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                A = "Code-First",
                B = "Database-First",
                C = "Model-First",
                D = "Controller-First",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 3,
                Question = "What is the primary purpose of Entity Framework Core?",
                A = "To create HTML pages automatically",
                B = "To replace the MVC Controller",
                C = "To map objects in code to relational database data",
                D = "To replace the C# compiler",
                Answer = "C"
            },

            new ExamQuestion
            {
                Number = 4,
                Question = "Which EF Core component is primarily responsible for communicating with the database?",
                A = "DbContext",
                B = "DbSetView",
                C = "ControllerContext",
                D = "RazorContext",
                Answer = "A"
            },

            new ExamQuestion
            {
                Number = 5,
                Question = "What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                A = "Deletes the database",
                B = "Creates a new MVC project",
                C = "Generates EF Core models and a DbContext from an existing database",
                D = "Starts the MVC application",
                Answer = "C"
            },

            new ExamQuestion
            {
                Number = 6,
                Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                A = "Program.cs only",
                B = "appsettings.json",
                C = "Index.cshtml",
                D = "Student.cs",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 7,
                Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                A = "One-to-One",
                B = "One-to-Many",
                C = "Many-to-Many",
                D = "Many-to-One only",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 8,
                Question = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",
                A = "Primary key of Student",
                B = "Foreign key referencing Section",
                C = "Navigation property",
                D = "Database connection string",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 9,
                Question = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                A = "It stores the database password",
                B = "It represents a relationship to another entity",
                C = "It creates a new database",
                D = "It validates the student's name",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 10,
                Question = "What does .Include() generally allow EF Core to do?",
                A = "Delete the Section table",
                B = "Load related Section data together with Students",
                C = "Create a new Student",
                D = "Validate Student input",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 11,
                Question = "Why might a ViewModel be used when displaying Student and Section information?",
                A = "To replace the database",
                B = "To combine or shape the data specifically needed by the view",
                C = "To automatically create database tables",
                D = "To prevent controllers from using LINQ",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 12,
                Question = "Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); What is the main benefit of Include(s => s.Section)?",
                A = "It loads the related Section navigation property",
                B = "It creates a Section object manually",
                C = "It removes the foreign key",
                D = "It prevents the query from accessing the database",
                Answer = "A"
            },

            new ExamQuestion
            {
                Number = 13,
                Question = "Which type of validation occurs in the browser before a request is sent to the server?",
                A = "Database-level validation",
                B = "Client-side validation",
                C = "Server-side validation",
                D = "EF Core migration validation",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 14,
                Question = "Why is server-side validation still necessary if client-side validation exists?",
                A = "Client-side validation can be bypassed",
                B = "Client-side validation automatically modifies the database",
                C = "Server-side validation only works with SQLite",
                D = "Client-side validation cannot display messages",
                Answer = "A"
            },

            new ExamQuestion
            {
                Number = 15,
                Question = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                A = "Student Number should always be nullable",
                B = "Student Number should be unique",
                C = "Student Number should always be the same",
                D = "Student Number should contain only spaces",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 16,
                Question = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                A = "It protects data integrity even if application-level validation is bypassed",
                B = "It makes Razor Views render faster",
                C = "It removes the need for a Controller",
                D = "It automatically creates a ViewModel",
                Answer = "A"
            },

            new ExamQuestion
            {
                Number = 17,
                Question = "What is the purpose of a try...catch block in a controller?",
                A = "To create navigation properties",
                B = "To catch and handle exceptions that may occur during execution",
                C = "To generate database tables",
                D = "To perform client-side validation",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 18,
                Question = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                A = "UseDatabase()",
                B = "UseExceptionHandler()",
                C = "UseValidationHandler()",
                D = "UseMvcDatabase()",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 19,
                Question = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                A = "Display the student's information anyway",
                B = "Display a Not Found (404) response/page",
                C = "Delete Student 999",
                D = "Create Student 999 automatically",
                Answer = "B"
            },

            new ExamQuestion
            {
                Number = 20,
                Question = "A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?",
                A = "Data integrity",
                B = "HTML formatting",
                C = "CSS inheritance",
                D = "Razor syntax",
                Answer = "A"
            }
        };


        // =========================================
        // PLAYER STATUS
        // =========================================

        public IActionResult Index()
        {
            int completed = CompletedQuestions.Count;

            int nextQuest = 1;

            for (int i = 1; i <= Questions.Count; i++)
            {
                if (!CompletedQuestions.Contains(i))
                {
                    nextQuest = i;
                    break;
                }
            }

            if (completed == Questions.Count)
            {
                nextQuest = Questions.Count;
            }


            // =========================================
            // EXPERIENCE
            // =========================================

            int currentExp = completed * 5;


            // =========================================
            // LEVEL
            // =========================================

            int level = (completed / 5) + 1;

            if (level > 5)
            {
                level = 5;
            }


            // =========================================
            // RANK
            // =========================================

            string rank;

            if (completed >= 20)
            {
                rank = "S";
            }
            else if (completed >= 15)
            {
                rank = "A";
            }
            else if (completed >= 10)
            {
                rank = "B";
            }
            else if (completed >= 5)
            {
                rank = "C";
            }
            else
            {
                rank = "E";
            }


            // =========================================
            // SYSTEM STATUS
            // =========================================

            string status;

            if (completed == 0)
            {
                status = "AWAKENING...";
            }
            else if (completed < 20)
            {
                status = "SYSTEM ACTIVE";
            }
            else
            {
                status = "QUEST COMPLETE";
            }


            // =========================================
            // SYSTEM MESSAGE
            // =========================================

            string message;

            if (completed == 0)
            {
                message =
                    "The System has recognized the Player.";
            }
            else if (completed < 20)
            {
                message =
                    $"Player has completed {completed} quest(s). Continue the hunt.";
            }
            else
            {
                message =
                    "ALL QUESTS COMPLETED. THE PLAYER HAS CLEARED THE DUNGEON.";
            }


            // =========================================
            // PLAYER MODEL
            // =========================================

            var player = new ExamViewModel
            {
                PlayerName = "Sumalinog Sophia",
                ClassSection = "BSIT31E3",
                PlayerTitle = "MVC EXAM HUNTER",

                Level = level,
                Rank = rank,

                CurrentExp = currentExp,
                ExpRequired = 100,

                CurrentQuest = nextQuest,

                TotalQuests = Questions.Count,

                CompletedQuests = completed,

                SystemStatus = status,

                CurrentQuestStatus =
                    completed == Questions.Count
                        ? "COMPLETED"
                        : "READY",

                SystemMessage = message
            };

            return View(player);
        }


        // =========================================
        // DISPLAY QUESTION
        // =========================================

        public IActionResult Question(int id = 1)
        {
            if (id < 1 || id > Questions.Count)
            {
                return NotFound();
            }

            return View(Questions[id - 1]);
        }


        // =========================================
        // COMPLETE QUEST
        // =========================================

        public IActionResult Complete(int id)
        {
            if (id < 1 || id > Questions.Count)
            {
                return NotFound();
            }

            // Mark the question as completed
            CompletedQuestions.Add(id);

            // Save progress to exam-progress.json
            SaveProgress();


            // =========================================
            // GO TO NEXT QUESTION
            // =========================================

            if (id < Questions.Count)
            {
                return RedirectToAction(
                    "Question",
                    new
                    {
                        id = id + 1
                    }
                );
            }


            // =========================================
            // ALL QUESTIONS COMPLETED
            // =========================================

            return RedirectToAction("Index");
        }


        // =========================================
        // RESET EXAM PROGRESS
        // =========================================

        public IActionResult Reset()
        {
            CompletedQuestions.Clear();

            // After reset, automatically mark
            // all 20 questions as completed again.
            for (int i = 1; i <= Questions.Count; i++)
            {
                CompletedQuestions.Add(i);
            }

            SaveProgress();

            return RedirectToAction("Index");
        }
    }


    // =========================================
    // QUESTION MODEL
    // =========================================

    public class ExamQuestion
    {
        public int Number { get; set; }

        public string Question { get; set; } = "";

        public string A { get; set; } = "";

        public string B { get; set; } = "";

        public string C { get; set; } = "";

        public string D { get; set; } = "";

        public string Answer { get; set; } = "";
    }
}

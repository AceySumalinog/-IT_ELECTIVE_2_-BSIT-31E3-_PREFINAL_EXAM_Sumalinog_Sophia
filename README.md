# MVC EXAM HUNTER

## ASP.NET Core MVC Pre-Final Exam

**Name:** Sumalinog Sophia  
**Class/Section:** BSIT31E3  
**Project:** MVC EXAM HUNTER

---

## Project Description

MVC EXAM HUNTER is an ASP.NET Core MVC web application created for the IT Elective 2 Pre-Final Exam.

The application presents the exam questions as a Manhwa-inspired RPG leveling system. The player answers each quest and receives experience, level progression, rank progression, and quest completion progress.

---

## Features

- Player Profile / Status
- 20 Multiple Choice Questions
- Correct and Incorrect Answer Detection
- Automatic Quest Progress
- EXP System
- Level System
- Rank System
- Progress Bar
- Saved Exam Progress
- Automatic Return to Player Status after an incorrect answer
- Next Quest navigation
- Exam Completion Status
- Reset Exam Progress

---

## Level System

| Completed Quests | Level | Rank |
|---|---:|---|
| 0–4 | Level 1 | E |
| 5–9 | Level 2 | C |
| 10–14 | Level 3 | B |
| 15–19 | Level 4 | A |
| 20 | Level 5 | S |

---

## Technologies Used

- C#
- ASP.NET Core MVC
- Razor Views
- HTML
- CSS
- JavaScript
- Git
- GitHub

---

## Database

This project does **not** use a database, following the exam requirements.

Exam progress is stored locally using a JSON file.

---

## Project Structure

```text
Controllers/
    ExamController.cs

Models/
    ExamViewModel.cs

Views/
    Exam/
        Index.cshtml
        Question.cshtml

wwwroot/
    css/
        exam.css

README.md

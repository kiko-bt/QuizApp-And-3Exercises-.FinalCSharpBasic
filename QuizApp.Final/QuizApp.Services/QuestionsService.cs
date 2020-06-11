using QuizApp.DomainModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizApp.Services
{
    public class QuestionsService
    {
        public List<Questions> Question { get; set; }

        public QuestionsService()
        {
            Question = new List<Questions>()
            {
                new Questions
                {
                    Question = "Q: What is the capital of Tasmania?",
                    Answer = "a: Dodoma\nb: Hobart\nc: Launceston\nd: Wellington"
                },
                new Questions
                {
                    Question = "Q: What is the tallest building in the Republic of the Congo?",
                    Answer = "a: Kinshasa Democratic Republic of the Congo Temple\nb: Palais de la Nation\nc: Kongo Trade Centre\nd: Nabemba Tower"
                },
                new Questions
                {
                    Question = "Q: Which of these is not one of Pluto's moons?",
                    Answer = "a: Styx\nb: Benxi Lake\nc: Kivu Lake\nd: Wakatipu Lake"
                },
                new Questions
                {
                    Question = "Q: What is the smallest lake in the world?",
                    Answer = "a: Onega Lake\nb: Benxi Lake\nc: Kivu Lake\nd: Wakatipu Lake"
                },
                new Questions
                {
                    Question = "Q: What country has the largest population of alpacas?",
                    Answer = "a: Chad\nb: Peru\nc: Australia\nd: Niger"
                },
            };
        }

        public void GetQuestions(Student student)
        {
            int score = 0;
            while (true)
            {
                Console.WriteLine("Please answer the following questions:");
                Console.WriteLine();
                Console.WriteLine(Question[0].Question);
                Console.WriteLine(Question[0].Answer);
                string answers = Console.ReadLine();
                if (answers == "b")
                {
                    score += 1;
                }
                Console.Clear();
                Console.WriteLine(Question[1].Question);
                Console.WriteLine(Question[1].Answer);
                answers = Console.ReadLine();
                if (answers == "d")
                {
                    score += 1;
                }
                Console.Clear();
                Console.WriteLine(Question[2].Question);
                Console.WriteLine(Question[2].Answer);
                answers = Console.ReadLine();
                if (answers == "c")
                {
                    score += 1;
                }
                Console.Clear();
                Console.WriteLine(Question[3].Question);
                Console.WriteLine(Question[3].Answer);
                answers = Console.ReadLine();
                if (answers == "b")
                {
                    score += 1;
                }
                Console.Clear();
                Console.WriteLine(Question[4].Question);
                Console.WriteLine(Question[4].Answer);
                answers = Console.ReadLine();
                if (answers == "b")
                {
                    score += 1;
                }


                if (score < 1)
                {
                    student.Grade = 1;
                }
                else if (score == 1)
                {
                    student.Grade = 2;
                }
                else if (score == 2)
                {
                    student.Grade = 3;
                }
                else if (score == 3)
                {
                    student.Grade = 4;
                }
                else
                {
                    student.Grade = 5;
                }
                student.AnsweredQuestions = true;
                Console.WriteLine($"Your score is {score} of {Question.Count} questions. Your Grade is {student.Grade}");
                Console.WriteLine(new string('-', 50));

                break;
            }
        }
    }
}

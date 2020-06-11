using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises_03.June
{
    class EntryPoint
    {
        static void Main(string[] args)
        {

            //Task1
            #region Task1
            List<string> textStorage = new List<string>();
            List<string> nameStorage = new List<string>();
            string name;

            while (true)
            {
                Console.WriteLine("Enter person names: ");
                name = Console.ReadLine();

                if (name == "x")
                {
                    break;
                }
                nameStorage.Add(name);
            }

            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine().ToLower();
            textStorage.Add(text);

            int count = 0;
            foreach (var someText in textStorage)
            {
                foreach (var names in nameStorage)
                {
                    if (someText.Contains(names))
                    {
                        count += 1;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine($"{name} was included {count} times!");
            #endregion






            //Task2
            #region Task2
            while (true)
            {
                List<string> dates = new List<string>();
                dates.Add("01.01.2020");
                dates.Add("07.01.2020");
                dates.Add("20.04.2020");
                dates.Add("01.05.2020");
                dates.Add("25.05.2020");
                dates.Add("03.08.2020");
                dates.Add("08.09.2020");
                dates.Add("12.10.2020");
                dates.Add("23.10.2020");
                dates.Add("09.12.2020");

                Console.WriteLine("Enter a date and check is it working day or not");
                string date = Console.ReadLine();

                foreach (var item in dates)
                {
                    DateTime date1 = DateTime.Parse(item);

                    if (date == date1.ToString("dd/MM/yyyy"))
                    {
                        Console.Clear();
                        Console.WriteLine($"{date1} |  Non - Workig Day");
                        RunAgain();
                    }
                    else if (date == Weekend.Saturday.ToString().ToLower() || date == Weekend.Sunday.ToString().ToLower())
                    {
                        Console.Clear();
                        Console.WriteLine($"{date} |  Non - Working Day");
                        RunAgain();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Working Day");
                        RunAgain();
                    }
                }
                break;
            }

            #endregion



            #region Task3
            int user = 0;
            int counter = 0;
            int counter1 = 0;

            while (user != 3)
            {
                Console.WriteLine(new string('-', 60));
                Console.WriteLine("WELCOME TO >THE ROCK PAPER SCISSOR< GAME");
                Console.WriteLine("Press \n 1.Play \n 2.Stats \n 3.Exit");
                user = Convert.ToInt32(Console.ReadLine());

                if (user == 1)
                {
                    Console.Clear();
                    PlayGame:
                    Console.WriteLine("Select any one:\n1->ROCK\n2->PAPER\n3->SCISSOR");
                    string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                    Random rnd = new Random();
                    int n = rnd.Next(0, 3);
                    Console.WriteLine("Enter your choice:");
                    int userAgain = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Computer:" + choices[n]);

                    if (userAgain == 1 && choices[n] == "SCISSOR")
                    {
                        Console.WriteLine("User wins");
                        counter += 1;
                    }
                    else if (userAgain == 1 && choices[n] == "PAPER")
                    {
                        Console.WriteLine("Computer wins");
                        counter1 += 1;
                    }
                    else if (userAgain == 2 && choices[n] == "ROCK")
                    {
                        Console.WriteLine("User wins");
                        counter += 1;
                    }
                    else if (userAgain == 1 && choices[n] == "SCISSOR")
                    {
                        Console.WriteLine("Computer Wins");
                        counter1 += 1;
                    }
                    else if (userAgain == 3 && choices[n] == "ROCK")
                    {
                        Console.WriteLine("Computer Wins");
                        counter1 += 1;
                    }
                    else if (userAgain == 3 && choices[n] == "PAPER")
                    {
                        Console.WriteLine("User wins");
                        counter += 1;
                    }
                    Console.WriteLine("Do u want to continue(YES/NO):");
                    string ans = Console.ReadLine().ToLower();
                    if (ans == "yes")
                    {
                        Console.Clear();
                        goto PlayGame;
                    }
                    else if (ans == "no")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong!");
                    }
                }
                else if (user == 2)
                {
                    Console.Clear();
                    Console.WriteLine("User wins " + counter + " times");
                    Console.WriteLine("Computer wins " + counter1 + " times");
                }
                else if (user == 3)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR!");
                }
            }
            #endregion




            Console.ReadLine();
        }
        static bool RunAgain()
        {
            while (true)
            {
                Console.WriteLine("Would you like to check another date? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
            }
        }
    }
}

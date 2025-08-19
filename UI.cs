using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    class UI
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Quizzer!");
        }

        public static void PrintCreateQuestions()
        {
            Console.WriteLine("Create Quiz questions.");
        }

        public static void PrintGameOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Choose an option. Enter number 1 or 2:");
            Console.WriteLine($"{Constants.QUIZ_MAKER} - Make a quiz");
            Console.WriteLine($"{Constants.QUIZ_PLAYER} - Play a quiz");
            Console.WriteLine();
        }

        public static int CheckUserInput()
        {
            while (true)
            {
                string userChoice = Console.ReadLine();
                int gameChoice = 0;
                if (int.TryParse(userChoice, out gameChoice) && gameChoice == Constants.QUIZ_MAKER || gameChoice == Constants.QUIZ_PLAYER)
                {
                    return gameChoice;
                }

                else
                {
                    Console.WriteLine("Incorrect input. Please enter 1 or 2 for an option.");
                }
            }
        }

        public static string AskForAQuestion()
        {
            Console.WriteLine("Enter your quiz question: ");
            string questionText = Console.ReadLine();
            return questionText;
        }

        public static List<string> AskForAnswers()
        {
            while (true)
            {
                Console.WriteLine("Enter 3 possible answers, separate them with commas: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    List<string> answers = input.Split(',').Select(s => s.Trim()).ToList();
                    if (answers.Count == 3)
                    {
                        return answers;
                    }

                    else
                    {
                        Console.WriteLine("Make sure you add 3 answer options. Try again.");
                    }
                }

                else
                {
                    Console.WriteLine("Check your input.Try again.");
                }

            }
        }

        public static char AskForCorrectAnswer()
        {
            Console.WriteLine("Enter the correct answer (A, B or C)");
            string input = Console.ReadLine();
            char correctAnswer = !string.IsNullOrEmpty(input) ? Char.ToUpper(input[0]) : ' ';
            return correctAnswer;
        }

        public static char AskIfMoreQuestions()
        {
            Console.WriteLine("Add another question? Y/N");
            string input = Console.ReadLine();
            char moreQuestions = !string.IsNullOrEmpty(input) ? Char.ToUpper(input[0]) : ' ';
            return moreQuestions;
        }
    }
}

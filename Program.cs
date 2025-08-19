using System.Xml.Serialization;

namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.PrintWelcomeMessage();
            //Ask user to create questions, 3 possible answers and list the correct answer
            UI.PrintCreateQuestions();
            while (true)
            {
                UI.AskForAQuestion();
                UI.AskForAnswers();
                UI.AskForCorrectAnswer();

                char moreQuestions = UI.AskIfMoreQuestions();
                if (char.ToUpper(moreQuestions) != 'Y')
                {
                    break;
                }

            }

            UI.PrintGameOptions();

            int gameChoice = 0;
            gameChoice = UI.CheckUserInput();




        }
    }
}

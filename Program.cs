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


            UI.PrintGameOptions();

            int gameChoice = 0;
            gameChoice = UI.CheckUserInput();

            
            
           
        }
    }
}

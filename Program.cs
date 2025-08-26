using System.Xml.Serialization;

namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.PrintWelcomeMessage();
            while (true)
            {
                //Ask the user if they want to play the quiz or create questions
                while (true)
                {
                    UI.PrintGameOptions();
                    int gameChoice = UI.CheckUserOptionChoice();

                    if (gameChoice == Constants.QUIZ_MAKER)
                    {
                        //QUESTION MODE - Ask user to create questions, 3 possible answers and list the correct answer
                        UI.PrintCreateQuestions();

                        List<QuizForm> QuizList = new List<QuizForm>();
                        while (true)
                        {
                            QuizForm quizForm = new QuizForm();

                            quizForm.Question = UI.AskForAQuestion();
                            quizForm.Answers = UI.AskForAnswers();
                            quizForm.CorrectAnswer = UI.AskForCorrectAnswer();

                            QuizList.Add(quizForm);

                            //Break the loop if user doesn't want to create more questions
                            char moreQuestions = UI.AskIfMoreQuestions();
                            if (char.ToUpper(moreQuestions) != 'Y')
                            {
                                break;
                            }
                        }

                        //Save created questions/answers to .xml
                        Logic.SaveQuizQuestions(QuizList);
                    }

                    if (gameChoice == Constants.QUIZ_PLAYER)
                    {
                        //Read questions from the file
                        List<QuizForm> QuizList = Logic.ReadQuizQuestions();

                        //GAME MODE - Quiz starting message
                        UI.PrintAnswerQuestions();

                        //Generate a random question
                        QuizForm randomQuestion = Logic.GenerateRandomQuestion(QuizList);
                        Console.WriteLine(randomQuestion.Question);
                        




                    }
                }
            }
        }
    }
}

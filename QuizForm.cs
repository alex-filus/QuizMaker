using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QuizForm
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public char CorrectAnswer { get; set; }

        public QuizForm()
        {
            Question = UI.AskForAQuestion();
            Answers = UI.AskForAnswers();
            CorrectAnswer = UI.AskForCorrectAnswer();
        }

    }
}

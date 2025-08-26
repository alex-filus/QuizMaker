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
        public string CorrectAnswer { get; set; }


        public override string ToString()
        {
            return $"Question: {Question}\nAnswers: {string.Join(", ", Answers)}\nCorrect Answer: {CorrectAnswer}";

        }
    }
}

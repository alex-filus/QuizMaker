using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuizMaker
{
    class Logic
    {
        public static void CreateQuiz()
        {
            //method here
        }

        public static void PlayQuiz()
        {
            //method here
        }

        public static void SaveQuizQuestions()
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<QuizForm>));
            var path = @"C:\Users\alexs\source\repos\QuizMaker\QuizList.xml";
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, QuizList);
            }
        }

    }
}

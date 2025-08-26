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
        static readonly Random random = new Random();

        public static string path = @"C:\Users\alexs\source\repos\QuizMaker\QuizList.xml";
        private static XmlSerializer writer = new XmlSerializer(typeof(List<QuizForm>));
        public static void SaveQuizQuestions(List<QuizForm> QuizList)
        {
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, QuizList);
            }
        }
        public static List<QuizForm> ReadQuizQuestions()
        {
           using (FileStream file = File.OpenRead(path))
            {
                var QuizList = writer.Deserialize(file) as List<QuizForm>;
                return QuizList;
            }
        }

        //Generate a random index from a list of questions
        public static QuizForm GenerateRandomQuestion(List<QuizForm> QuizList)
        {
            int index = random.Next(QuizList.Count);
            return QuizList[index];
        }
    }
}

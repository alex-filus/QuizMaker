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
        public static string path = @"C:\Users\alexs\source\repos\QuizMaker\QuizList.xml";
        private static XmlSerializer writer = new XmlSerializer(typeof(List<QuizForm>));
        public static void SaveQuizQuestions(List<QuizForm> QuizList)
        {
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, QuizList);
            }
        }
        public static void ReadQuizQuestions(List<QuizForm> QuizList)
        {
           using (FileStream file = File.OpenRead(path))
            {
                QuizList = writer.Deserialize(file) as List<QuizForm>;
            }
        }
    }
}

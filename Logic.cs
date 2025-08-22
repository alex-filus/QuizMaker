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
        public static void SaveQuizQuestions(List<QuizForm> QuizList)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<QuizForm>));
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, QuizList);
            }
        }

    }
}

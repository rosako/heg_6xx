using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Windows.Markup;

namespace Exam
{
    public class Question
    {
        public string number { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string imgPath { get; set; }

        public Question(string number, string title, string description, string imgPath)
        {
            this.number = number;
            this.title = title;
            this.description = description;
            this.imgPath = imgPath;
        }


        public static Dictionary<string, Question> loadCSV(string filePath)
        {
            var questions = new Dictionary<string, Question>();

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {

                string[] values = lines[i].Split(';');
                if (values.Length >= 4)
                {
                    //string path = $"{values[2]}.png";
                    //var Question = new Question(values[0], values[1], values[2], path);
                    var Question = new Question(values[0], values[1], values[2], values[3]);
                    questions.Add(values[0], Question);
                }
                else
                {

                }
                //string path = $"{values[2]}.png";
                //var Question = new Question(values[0], values[1], values[2], values[3]);

            }


            return questions;
        }


        public static void excludeQuestionFromNb(string nb, Dictionary<string, Question> questions)
        {
            foreach (var q in questions)
            {
                if (q.Value.number == nb)
                {
                    questions.Remove(q.Key);
                }
            }
        }


        public static void excludeQuestion(Question question, Dictionary<string, Question> questions)
        {
            foreach (var q in questions)
            {
                if (q.Equals(question))
                {
                    questions.Remove(q.Key);
                }
            }
        }

        public string toString()
        {
            return $"{this.number} : {this.title} {this.description} {this.imgPath}";
        }


        public string toListItem()
        {
            return $"{this.number} : {this.title} / {this.description}";
        }

        public string toCSV()
        {
            return $"{this.number},{this.title},{this.description},{this.imgPath}";
        }
    }
}

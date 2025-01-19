using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exam
{
    public class Tools
    {
        public static (int, int) getTwoUniqueRandomNumbers(int min, int max, HashSet<int> exclusions)
        {
            List<int> validNumbers = Enumerable.Range(min, max - min + 1).Where(n => !exclusions.Contains(n)).ToList();

            if (validNumbers.Count < 2)
            {
                System.Console.WriteLine("oups no more questions available, resort to hardcoded first and last question");
                return (min, max);
            }

            Random random = new Random(max);
            int first = validNumbers[random.Next(validNumbers.Count)];

            int second = validNumbers[random.Next(validNumbers.Count)];

            return (first, second);
        }

        public static Question randomQuestion(Dictionary<string, Question> questions)
        {
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            int seed = (int)(milliseconds & 0xFFFFFFFF);
            Random random = new Random(seed);
            var keys = questions.Keys.ToList();

            var randomKey = keys[random.Next(keys.Count)];
            var randq = questions[randomKey];
            random.Next(keys.Count);

            //Console.WriteLine(randq.title);

            return randq;
        }

        public static (Question, Question) randomTwoQuestions(Dictionary<string, Question> questions)
        {
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            int seed = (int)(milliseconds & 0xFFFFFFFF);
            Random random = new Random(seed);

            var keys = questions.Keys.ToList();

            var firstRandomKey = keys[random.Next(keys.Count)];
            var firstQuestion = questions[firstRandomKey];

            keys.Remove(firstRandomKey);

            var secondRandomKey = keys[random.Next(keys.Count)];
            var secondQuestion = questions[secondRandomKey];

            return (firstQuestion, secondQuestion);

        }


    }
}
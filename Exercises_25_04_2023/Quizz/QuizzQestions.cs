using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public static class QuizzQestions
    {
        public static Question[] Questions { get; private set; }

        public static void SetGeographyQuestions()
        {
            Questions = new Question[]
            {
                new Question(
                    "What is the name of the tallest mountain in the world?",
                    "Mount Everest",
                    new string[] { "Himalayas ", "Mount Everest", "Alps", "Lhotse" }),
                new Question(
                    "What is the biggest continent of the world?",
                    "Asia",
                    null)
            };
        }

        public static Question[] SetMathQuestions()
        {
            Question[] result = new Question[] { };

            return result;
        }
    }
}

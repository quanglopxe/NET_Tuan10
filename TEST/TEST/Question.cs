using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Question
    {
        public string questionText { get; set; }
        public string answer { get; set; }
        public List<string> answers { get; set; }
        public Question(string QuestionText, string Answer, List<string> Answers)
        {
            questionText = QuestionText;
            answer = Answer;
            answers = Answers;
        }
    }
}

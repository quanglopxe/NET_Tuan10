using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string questionText, string answerA, string answerB, string answerC, string answerD, string correctAnswer)
        {
            QuestionText = questionText;
            AnswerA = answerA;
            AnswerB = answerB;
            AnswerC = answerC;
            AnswerD = answerD;
            CorrectAnswer = correctAnswer;
        }
    }
}

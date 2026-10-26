using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_App_med_AI_stöd
{
    internal class QuizQuestion


    {

        public string question {  get; set; }

        public string correctAnswer { get; set; }

        public QuizQuestion(string question, string correctAnswer)
        {
            this.question = question;
            this.correctAnswer = correctAnswer;
        }
    }
}

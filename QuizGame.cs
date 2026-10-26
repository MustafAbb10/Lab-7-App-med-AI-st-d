using System;
using System.Collections.Generic;

namespace Lab_7_App_med_AI_stöd
{
    internal class QuizGame
    {
        private List<QuizQuestion> quiz = new List<QuizQuestion>();

        public QuizGame()
        {
           
            quiz.Add(new QuizQuestion("Vilken datatyp används för heltal?", "int"));
            quiz.Add(new QuizQuestion("Vilket nyckelord används för att skapa en klass?", "class"));
            quiz.Add(new QuizQuestion("Vilken datatyp används för text?", "string"));
            quiz.Add(new QuizQuestion("Vilket nyckelord används för att skapa ett nytt objekt?", "new"));
        }

        public void StartQuiz()
        {
            int score = 0;

            foreach (QuizQuestion question in quiz)
            {
                Console.WriteLine(question.question);
                Console.Write("Ditt svar: ");

                string answer = Console.ReadLine() ?? "";

                if (answer.Trim().Equals(question.correctAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Rätt svar!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Fel svar! Rätt svar är {question.correctAnswer}.");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Du fick {score} av {quiz.Count} poäng!");
        }
    }
}
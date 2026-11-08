using System;
using System.Collections.Generic;

namespace Lab_7_App_med_AI_stöd
{
    internal class QuizGame
    {
        private List<QuizQuestion> quiz = new List<QuizQuestion>();

        public QuizGame()
        {
            // AI-assisted idea: Store quiz questions in a List.
            // The questions were adapted to focus on C# programming.
            quiz.Add(new QuizQuestion("Vilken datatyp används för heltal?", "int"));
            quiz.Add(new QuizQuestion("Vilket nyckelord används för att skapa en klass?", "class"));
            quiz.Add(new QuizQuestion("Vilken datatyp används för text?", "string"));
            quiz.Add(new QuizQuestion("Vilket nyckelord används för att skapa ett nytt objekt?", "new"));
        }

        public void StartQuiz()
        {
            int score = 0;

            // AI-assisted idea: foreach goes through all quiz questions.
            foreach (QuizQuestion question in quiz)
            {
                Console.WriteLine(question.Question);
                Console.Write("Ditt svar: ");

                string answer = Console.ReadLine() ?? "";

                // AI-assisted improvement: Trim removes extra spaces.
                // OrdinalIgnoreCase ignores uppercase and lowercase differences.
                if (answer.Trim().Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Rätt svar!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Fel svar! Rätt svar är {question.CorrectAnswer}.");
                }

                Console.WriteLine();
            }

            // Display the final quiz score.
            Console.WriteLine($"Du fick {score} av {quiz.Count} poäng!");
        }
    }
}
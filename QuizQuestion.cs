namespace Lab_7_App_med_AI_stöd
{
    internal class QuizQuestion
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }

        // AI-assisted structure: Constructor stores the question and correct answer.
        public QuizQuestion(string question, string correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
        }
    }
}
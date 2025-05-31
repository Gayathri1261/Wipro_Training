using System;
using System.Collections.Generic;

class Question
{
    public string Text { get; set; }
    public Dictionary<string, string> Options { get; set; }
    public string CorrectOption { get; set; }

    public Question(string text, Dictionary<string, string> options, string correctOption)
    {
        Text = text;
        Options = options;
        CorrectOption = correctOption;
    }

    public void Display()
    {
        Console.WriteLine(Text);
        foreach (var option in Options)
        {
            Console.WriteLine($"{option.Key}. {option.Value}");
        }
    }

    public bool CheckAnswer(string userAnswer)
    {
        return userAnswer.ToUpper() == CorrectOption.ToUpper();
    }
}

class Program
{
    static void Main()
    {
        List<Question> questions = new List<Question>
        {
            new Question("What is the capital of India?",
                new Dictionary<string, string> {
                    {"A", "Mumbai"},
                    {"B", "New Delhi"},
                    {"C", "Hyderabad"},
                    {"D", "Chennai"}
                }, "B"),

            new Question("Which planet is known as the Red Planet?",
                new Dictionary<string, string> {
                    {"A", "Earth"},
                    {"B", "Venus"},
                    {"C", "Mars"},
                    {"D", "Jupiter"}
                }, "C"),

            new Question("Who wrote the national anthem of India?",
                new Dictionary<string, string> {
                    {"A", "Rabindranath Tagore"},
                    {"B", "Mahatma Gandhi"},
                    {"C", "Subhash Chandra Bose"},
                    {"D", "Jawaharlal Nehru"}
                }, "A"),

            new Question("Which number is even?",
                new Dictionary<string, string> {
                    {"A", "3"},
                    {"B", "5"},
                    {"C", "8"},
                    {"D", "9"}
                }, "C")
        };

        Random rnd = new Random();
        int score = 0;
        int totalQuestions = 3;

        Console.WriteLine("Welcome to the Quiz!\n");

        for (int i = 0; i < totalQuestions; i++)
        {
            int index = rnd.Next(questions.Count);
            Question q = questions[index];
            questions.RemoveAt(index); 

            q.Display();
            Console.Write("\nEnter your answer (A/B/C/D): ");
            string userAnswer = Console.ReadLine();

            if (q.CheckAnswer(userAnswer))
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong! Correct answer is: {q.CorrectOption}\n");
            }
        }

        Console.WriteLine($"Your score: {score}/{totalQuestions}");
    }
}
using System;

public class ChatBot
{
    public string Respond(string greeting)
    {
        return greeting + "Hello! Good morning: ";
    }
    public string Respond(string question,bool isFormal)
    {
        if(isFormal)
            return  question + " Thank you for your question. I will try to answer: " ;
        else
        return question + " Cool question! This is Gayathri:";  
    }
    public string Respond(int number)
    {
        return  " You entered the number " + number + ".Fun fact:its square is "+ (number * number) ;
    }
}
class Program
{
    static void Main()
    {
        ChatBot bot = new ChatBot();

        // Greeting
        string response1 = bot.Respond("Hi there!");
        Console.WriteLine(response1);

        // Casual question
        string response2 = bot.Respond("What's your name?", false);
        Console.WriteLine(response2);

        // Formal question
        string response3 = bot.Respond("Can you assist with my homework?", true);
        Console.WriteLine(response3);

        // Number input
        string response4 = bot.Respond(7);
        Console.WriteLine(response4);
    }
}
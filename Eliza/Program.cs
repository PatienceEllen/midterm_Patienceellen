using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (input == "exit") break;
            string response = CreateElizaResponse(input);
            Console.WriteLine(response);
        }
    }

    static string CreateElizaResponse(string statement)
    {
        if (statement.Contains("my"))
        {
            int startIndex = statement.IndexOf("my") + 3;
            int endIndex = statement.IndexOf(" ", startIndex);
            if (endIndex == -1) endIndex = statement.Length;
            string noun = statement.Substring(startIndex, endIndex - startIndex);
            return "Tell me more about your " + noun;
        }
        else if (statement.Contains("love") || statement.Contains("hate"))
        {
            return "You have strong feelings about that!";
        }
        else
        {
            string[] responses = { "Please go on.", "Tell me more.", "Continue." };
            return responses[new Random().Next(responses.Length)];
        }
    }

}
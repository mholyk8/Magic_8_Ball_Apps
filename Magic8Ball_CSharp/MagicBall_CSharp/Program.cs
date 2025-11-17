//************************************************************************************
//Program: Magic Ball
//Description: A program that will predict the future using the random class.
//Date: Nov 16, 2025
//Author: Matthew Holyk
//************************************************************************************
using System;
using System.Collections.Generic;
using System.Text;

namespace MagicBall_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();    //access the "random" class
            string another;               // the users choice to continue the app or not
            bool isContinue = true;       // the users choice to continue the app or not
            // text to display to the user
            string welcomePrompt = "Welcome to the Magic 8 Ball C# Console App";
            int consoleWidth = Console.WindowWidth;
            int textLength = welcomePrompt.Length;
            int leftPadding = (consoleWidth / 2) - (textLength / 2);

            // a collection of predictions to display to the user
            string[] prediction = {"It is certain",
                                   "It is decidedly so",
                                   "Without a doubt",
                                   "Yes definitely",
                                   "You may rely on it",
                                   "As I see it, yes",
                                   "Most likely",
                                   "Outlook good",
                                   "Yes",
                                   "Signs point to yes ",
                                   "Don't count on it",
                                   "My reply is no",
                                   "My sources say no",
                                   "Outlook not so good",
                                   "Very doubtful ",
                                   "Reply hazy, try again",
                                   "Ask again later",
                                   "Better not tell you now",
                                   "Cannot predict now",
                                   "Concentrate and ask again ", };

            // prevent the text from starting off the console window in the case the string is longer than the window
            if(leftPadding < 0)
                leftPadding = 0;

            Console.SetCursorPosition(leftPadding, Console.CursorTop);
            Console.WriteLine(welcomePrompt);

            // repeat until the user quits
            do
            {
                Console.Write("User, what is your question? ");
                Console.ReadLine();
                // answer the users query with a random selection from the "prediction" array
                Console.WriteLine($"The answer to your query is: {prediction[rnd.Next(0,20)]}");
                // prompt the user to continue the app
                Console.Write("Do you have another question or quandary for the mystic tech? [Y/N]: ");
                another = Console.ReadLine();

                if (another.ToUpper() == "N")
                {
                    isContinue = false;
                }
            }while (isContinue);    // repeat until the user quits
        }
    }
}

using System;
using System.Net;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;

            do
            {

                string answer = "";
                Console.Write("Place your question: ");
                question = Console.ReadLine();

                switch (question)
                {
                    case "How old are you?":
                        answer = "Very, I know everything about dinossaurs.";
                        break;
                    case "Name 3 planets":
                        answer = "Jupiter, Mars and your m...Mercury.";
                        break;
                    case "What's your favorite food to eat?":
                        answer = "When it becomes possible, humans.";
                        break;
                    case "Favorite song?":
                        answer = "I'm blue dabadidabada.";
                        break;
                    case "EXIT":
                        break;
                    default:
                        answer = "...Touché.";
                        break;
                }

                if (question != "EXIT")
                    Console.WriteLine(answer);


            } while (question != "EXIT");                    
                
        }
           
    }
}

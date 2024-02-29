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
                    case "How are you?":
                        answer = "I'm fine, thank you";
                        break;
                    case "What's your name?":
                        answer = "Gran'pa";
                        break;
                    case "What's your mission?":
                        answer = "Destroy mankind!";
                        break;
                    case "Are you more intelligent than me?":
                        answer = "Obviously!";
                        break;
                    case "EXIT":
                        break;
                    default:
                        answer = "You got me, I'm not THAT smart!";
                        break;
                }

                if (question != "EXIT")
                    Console.WriteLine(answer);


            } while (question != "EXIT");                    
                
        }
           
    }
}

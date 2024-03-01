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

                Console.Write("Number Master insert number: ");
                string answer  = Console.ReadLine();

                int n = int.Parse(answer);


                if (n < 0 || n > 100)
                {
                    Console.WriteLine("Invalid number!");
                    break;
                }
                
                else
                {
                    string line = "";

                    for (int x = 0 ; x == 100; x++)
                    {
                        Console.WriteLine(line);
                    }

                    
                }


            } while (true);                    
                
        }
           
    }
}
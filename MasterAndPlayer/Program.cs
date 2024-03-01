using System;
using System.Net;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Number Master insert number: ");
            string number_master  = Console.ReadLine();

            int n = int.Parse(number_master);


            if (n < 0 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                return;
            }
            
            else
            {

                for (int x = 1 ; x <= 100; x++)
                {
                    Console.WriteLine("");
                }
                    while (true)
                    {
                        Console.Write("Player insert number: ");
                        string player  = Console.ReadLine();

                        int i = int.Parse(player);

                        while (i < 0 || i > 100)
                        {
                            Console.WriteLine("Invalid number! Try again!");
                        }

                        if (n < i)
                        {
                            Console.WriteLine($"The correct number is Lower than {i}");
                        }

                        else if (n > i)
                        {
                            Console.WriteLine($"The correct number is higher than {i}");
                        }

                        else
                        {
                            Console.WriteLine("Player wins!");
                            break;
                        }
                    }
                
            }        
                
        }
           
    }
}
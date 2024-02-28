using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            //ask user for number
            Console.Write("Insere número inteiro não-negativo: ");
            

            //get number from user and convert it to byte
            string s = Console.ReadLine();
            byte n = byte.Parse(s);

            //increment and decrement number received

            byte decrement = n--;
            byte increment = n++;

            Console.WriteLine(increment);
            Console.WriteLine(decrement);

            




       
            
            
        }
    }
}

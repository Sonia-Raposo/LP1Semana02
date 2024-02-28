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
            byte n_decrement = n--;
            byte n_increment = n++;

            Console.WriteLine(n_increment);
            Console.WriteLine(n_decrement);

            // divide n by 2; shift left n by 3; xor n with 5; condition if n is higher than 10
            int n_divide = n / 2;
            int n_shift = n << 3;
            int n_xor = n ^ 5;
            bool n_higher = n > 10;


            Console.WriteLine(n_divide);
            Console.WriteLine(n_shift);
            Console.WriteLine(n_xor);
            Console.WriteLine(n_higher);






       
            
            
        }
    }
}

using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask height and save it as a float
            Console.Write("Insira a altura do cilindro em cm: ");

            string altura = Console.ReadLine();
            float a = float.Parse(altura);


            //ask radius and save it as a float
            Console.Write("Insira o raio do cilindro em cm: ");

            string raio = Console.ReadLine();
            float r = float.Parse(raio);


            //calculate cilinder volume
            float v = MathF.PI * MathF.Pow(r, 2) * a;

            //calculate cilinder area
            float s = 2*MathF.PI * r*(r+ a);


            //print the result of volume and area
            Console.WriteLine("Volume do Cilindro em cm3: ");
            Console.WriteLine(v);
            Console.WriteLine("Área do Cilindro em cm2: ");
            Console.WriteLine(s);

            
        }
    }
}

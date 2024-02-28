using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a altura do cilindro em cm: ");

            string altura = Console.ReadLine();
            float a = float.Parse(altura);

            Console.Write("Insira o raio do cilindro em cm: ");

            string raio = Console.ReadLine();
            float r = float.Parse(raio);

            
            float v = MathF.PI * MathF.Pow(r, 2) * a;

            float s = 2*MathF.PI * r*(r+ a);


            Console.WriteLine("Volume do Cilindro em cm3: ");
            Console.WriteLine(v);
            Console.WriteLine("Área do Cilindro em cm2: ");
            Console.WriteLine(s);


            
        }
    }
}

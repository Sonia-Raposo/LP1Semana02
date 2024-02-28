using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        
        {
            //Min and max values of all types
            sbyte sb_min = sbyte.MinValue;
            sbyte sb_max = sbyte.MaxValue;

            short s_min = short.MinValue;
            short s_max = short.MaxValue;

            int i_min = int.MinValue;
            int i_max = int.MaxValue;

            long l_min = long.MinValue;
            long l_max = long.MaxValue;

            byte b_min = byte.MinValue;
            byte b_max = byte.MaxValue;

            ushort us_min = ushort.MinValue;
            ushort us_max = ushort.MaxValue;

            uint ui_min = uint.MinValue;
            uint ui_max = uint.MaxValue;

            ulong ul_min = ulong.MinValue;
            ulong ul_max = ulong.MaxValue;
            

            //print all the values above
            Console.WriteLine(sb_min);
            Console.WriteLine(sb_max);

            Console.WriteLine(s_min);
            Console.WriteLine(s_max);

            Console.WriteLine(i_min);
            Console.WriteLine(i_max);

            Console.WriteLine(l_min);
            Console.WriteLine(l_max);

            Console.WriteLine(b_min);
            Console.WriteLine(b_max);

            Console.WriteLine(us_min);
            Console.WriteLine(us_max);

            Console.WriteLine(ui_min);
            Console.WriteLine(ui_max);

            Console.WriteLine(ul_min);
            Console.WriteLine(ul_max);


        }
    }
}

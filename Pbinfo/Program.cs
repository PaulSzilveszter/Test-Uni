using System;

namespace Pbinfo
{
    class Program
    {
        static void Main()
        {
           uint C = uint.Parse(Console.ReadLine());

            uint P = 2 * C;
            uint G = 2 * P;

            uint animaleInCurte = C + P + G;

            Console.WriteLine(animaleInCurte);


        }
    }
}
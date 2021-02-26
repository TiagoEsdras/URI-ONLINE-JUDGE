using System;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, n = 3.14159, area;

            raio = Convert.ToDouble(Console.ReadLine());

            area = n * Math.Pow(raio, 2);

            Console.WriteLine("A={0}", area.ToString("F4"));
        }
    }
}

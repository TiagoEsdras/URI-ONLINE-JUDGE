using System; 

class URI {

    static void Main(string[] args) { 

        double A, B;
        A = Convert.ToDouble(Console.ReadLine());
        B = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("MEDIA = {0}", ((A * 3.5 + B * 7.5) / 11).ToString("F5"));
    }
}

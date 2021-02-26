using System; 

class URI {

    static void Main(string[] args) { 

        double A, B, C;

        A = Convert.ToDouble(Console.ReadLine());
        B = Convert.ToDouble(Console.ReadLine());
        C = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("MEDIA = {0}", ((A * 2 + B * 3 + C * 5) / 10).ToString("F1"));

    }
}

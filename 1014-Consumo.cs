using System; 

class URI {

    static void Main(string[] args) { 

        int X;
        double Y, media;

        X = Convert.ToInt32(Console.ReadLine());
        Y = Convert.ToDouble(Console.ReadLine());

        media = X / Y;

        Console.WriteLine("{0} km/l", media.ToString("F3"));

    }
}

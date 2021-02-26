using System; 

class URI {

    static void Main(string[] args) { 

        double R, V;
        R = Convert.ToDouble(Console.ReadLine());

        V = (4.0 / 3) * 3.14159 * (Math.Pow(R, 3));

        Console.WriteLine("VOLUME = {0}", V.ToString("F3"));

    }
}

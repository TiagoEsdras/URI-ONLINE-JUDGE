using System; 

class URI {

    static void Main(string[] args) { 

        double x1, y1, x2, y2, distacia;
        string[] vet, vet1;

        vet = Console.ReadLine().Split(' ');
        x1 = Convert.ToDouble(vet[0]);
        y1 = Convert.ToDouble(vet[1]);

        vet1 = Console.ReadLine().Split(' ');
        x2 = Convert.ToDouble(vet1[0]);
        y2 = Convert.ToDouble(vet1[1]);

        distacia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine("{0}", distacia.ToString("F4"));

    }
}

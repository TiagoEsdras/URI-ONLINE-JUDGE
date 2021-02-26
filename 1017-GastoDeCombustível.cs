using System; 

class URI {

    static void Main(string[] args) { 

        int horas, velocidadeMedia;
        double consumoFinal, distancia;

        horas = Convert.ToInt32(Console.ReadLine());
        velocidadeMedia = Convert.ToInt32(Console.ReadLine());

        distancia = (double)velocidadeMedia * horas;
        consumoFinal = distancia / 12;

        Console.WriteLine("{0}", consumoFinal.ToString("F3"));

    }
}

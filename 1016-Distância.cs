using System; 

class URI {

    static void Main(string[] args) { 

        int distancia, minuto, X = 60, Y = 90;                 

        distancia = Convert.ToInt32(Console.ReadLine());

        minuto = (60 / (Y - X)) * distancia;

        Console.WriteLine("{0} minutos", minuto);

    }
}

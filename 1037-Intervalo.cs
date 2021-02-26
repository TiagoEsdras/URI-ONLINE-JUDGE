using System; 

class URI {

    static void Main(string[] args) { 

        double A;

        A = Convert.ToDouble(Console.ReadLine());

        if (A >= 0 && A <= 25)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (A > 25 && A <= 50)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (A > 50 && A <= 75)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (A > 75 && A <= 100)
        {
            Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }
    }
}

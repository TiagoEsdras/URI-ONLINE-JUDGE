using System; 

class URI {

    static void Main(string[] args) { 

        double N, x, y;
        int resto, moedas, notas;

        N = Convert.ToDouble(Console.ReadLine());
        x = Math.Floor(N);
        y = N - x;
        y *= 100;


        Console.WriteLine("NOTAS:");
        notas = (int)(x / 100);
        resto = (int)(x % 100);
        Console.WriteLine("{0} nota(s) de R$ 100.00", notas);                
        notas = (resto / 50);
        resto = (resto % 50);
        Console.WriteLine("{0} nota(s) de R$ 50.00", notas);                
        notas = (resto / 20);
        resto = (resto % 20);
        Console.WriteLine("{0} nota(s) de R$ 20.00", notas);                
        notas = (resto / 10);
        resto = (resto % 10);
        Console.WriteLine("{0} nota(s) de R$ 10.00", notas);                
        notas = (resto / 5);
        resto = (resto % 5);
        Console.WriteLine("{0} nota(s) de R$ 5.00", notas);                
        notas = (resto / 2);
        resto = (resto % 2);
        Console.WriteLine("{0} nota(s) de R$ 2.00", notas);
        Console.WriteLine("MOEDAS:");
        moedas = resto;
        Console.WriteLine("{0} moeda(s) de R$ 1.00", moedas);
        moedas = (int)(y / 50);
        resto = (int)(y % 50);
        Console.WriteLine("{0} moeda(s) de R$ 0.50", moedas);
        moedas = (resto / 25);
        resto = (resto % 25);
        Console.WriteLine("{0} moeda(s) de R$ 0.25", moedas);
        moedas = (resto / 10);
        resto = (resto % 10);
        Console.WriteLine("{0} moeda(s) de R$ 0.10", moedas);
        moedas = (resto / 05);
        resto = (resto % 05);
        Console.WriteLine("{0} moeda(s) de R$ 0.05", moedas);
        moedas = resto;
        Console.WriteLine("{0} moeda(s) de R$ 0.01", moedas);

    }

}

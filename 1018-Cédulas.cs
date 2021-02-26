using System; 

class URI {

    static void Main(string[] args) { 

        int N, nota100, nota50, nota20, nota10, nota5, nota2, nota1;
        N = Convert.ToInt32(Console.ReadLine());

        nota100 = N / 100;
        nota50 = (N - (nota100 * 100)) / 50;
        nota20 = (N - (nota100 * 100) - (nota50 * 50)) / 20;
        nota10 = (N - (nota100 * 100) - (nota50 * 50) - (nota20 * 20)) / 10;
        nota5 = (N - (nota100 * 100) - (nota50 * 50) - (nota20 * 20) - (nota10 * 10)) / 5;
        nota2 = (N - (nota100 * 100) - (nota50 * 50) - (nota20 * 20) - (nota10 * 10) - (nota5 * 5)) / 2;
        nota1 = (N - (nota100 * 100) - (nota50 * 50) - (nota20 * 20) - (nota10 * 10) - (nota5 * 5) - (nota2 * 2));


        Console.WriteLine("{0}", N);
        Console.WriteLine("{0} nota(s) de R$ 100,00", nota100);
        Console.WriteLine("{0} nota(s) de R$ 50,00", nota50);
        Console.WriteLine("{0} nota(s) de R$ 20,00", nota20);
        Console.WriteLine("{0} nota(s) de R$ 10,00", nota10);
        Console.WriteLine("{0} nota(s) de R$ 5,00", nota5);
        Console.WriteLine("{0} nota(s) de R$ 2,00", nota2);
        Console.WriteLine("{0} nota(s) de R$ 1,00", nota1);

    }
}

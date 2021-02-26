using System; 

class URI {

    static void Main(string[] args) { 

        int cod1, cod2, qnt1, qnt2;
        double valor1, valor2, result;
        string[] vet;

        vet = Console.ReadLine().Split(' ');
        cod1 = Convert.ToInt32(vet[0]);
        qnt1 = Convert.ToInt32(vet[1]);
        valor1 = Convert.ToDouble(vet[2]);

        vet = Console.ReadLine().Split(' ');
        cod2 = Convert.ToInt32(vet[0]);
        qnt2 = Convert.ToInt32(vet[1]);
        valor2 = Convert.ToDouble(vet[2]);

        result = qnt1 * valor1 + qnt2 * valor2;

        Console.WriteLine("VALOR A PAGAR: R$ {0}",  result.ToString("F2"));
    }

}

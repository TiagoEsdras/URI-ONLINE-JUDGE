using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, C, D, somaCD, somaAB;
        string[] vet;

        vet = Console.ReadLine().Split(' ');

        A = Convert.ToInt32(vet[0]);
        B = Convert.ToInt32(vet[1]);
        C = Convert.ToInt32(vet[2]);
        D = Convert.ToInt32(vet[3]);

        somaAB = A + B;
        somaCD = C + D;

        if (B > C && D > A && somaCD > somaAB && C > 0 && D > 0 && A % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}

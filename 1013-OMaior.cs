using System; 

class URI {

    static void Main(string[] args) { 

        int A, B, C;
        int maior1, maior2;
        string[] vet;

        vet = Console.ReadLine().Split(' ');
        A = Convert.ToInt32(vet[0]);
        B = Convert.ToInt32(vet[1]);
        C = Convert.ToInt32(vet[2]);

        maior1 = (A + B + Math.Abs(A - B)) / 2;
        maior2 = (maior1 + C + Math.Abs(maior1 - C)) / 2;

        Console.WriteLine("{0} eh o maior", maior2);

    }
}

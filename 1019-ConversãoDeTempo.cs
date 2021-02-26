using System; 

class URI {

    static void Main(string[] args) { 

        int N, hora, min, segundo;
        N = Convert.ToInt32(Console.ReadLine());

        hora = N / 3600;
        min = (N - (hora * 3600)) / 60;
        segundo = N - (hora * 3600) - (min * 60);

        Console.WriteLine("{0}:{1}:{2}", hora, min, segundo);

    }
}

using System; 

class URI {

    static void Main(string[] args) { 

        double A, B, C, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
        string[] vet;

        vet = Console.ReadLine().Split(' ');
        A = Convert.ToDouble(vet[0]);
        B = Convert.ToDouble(vet[1]);
        C = Convert.ToDouble(vet[2]);


        areaTriangulo = (A * C) / 2;
        areaCirculo = 3.14159 * (Math.Pow(C, 2));
        areaTrapezio = ((A + B) * C) / 2;
        areaQuadrado = B * B;
        areaRetangulo = A * B;

        Console.WriteLine("TRIANGULO: {0}", areaTriangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: {0}", areaCirculo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: {0}", areaTrapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: {0}", areaQuadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: {0}", areaRetangulo.ToString("F3"));
    }
}

using System; 

class URI {

    static void Main(string[] args) { 

        string nome;
        double salario, totalVendas, salarioFinal;

        nome = Console.ReadLine();
        salario = Convert.ToDouble(Console.ReadLine());
        totalVendas = Convert.ToDouble(Console.ReadLine());

        salarioFinal = (totalVendas * 0.15) + salario;

        Console.WriteLine("TOTAL = R$ {0}", salarioFinal.ToString("F2"));

    }
}

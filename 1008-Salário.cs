using System; 

class URI {

    static void Main(string[] args) { 

        int numeroFuncionario;
        double horasTrabalhadas, salario, valorHora;

        numeroFuncionario = Convert.ToInt32(Console.ReadLine());
        horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
        valorHora = Convert.ToDouble(Console.ReadLine());

        salario = horasTrabalhadas * valorHora;

        Console.WriteLine("NUMBER = {0}", numeroFuncionario);
        Console.WriteLine("SALARY = U$ {0}", salario.ToString("F2"));

    }
}

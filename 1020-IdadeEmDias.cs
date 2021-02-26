using System; 

class URI {

    static void Main(string[] args) { 

        int N, ano, mes, dia;
        N = Convert.ToInt32(Console.ReadLine());

        ano = N / 365;
        mes = (N - (ano * 365)) / 30;
        dia = N - (ano * 365) - (mes * 30);

        Console.WriteLine("{0} ano(s)", ano);
        Console.WriteLine("{0} mes(es)", mes);
        Console.WriteLine("{0} dia(s)", dia);

    }
}

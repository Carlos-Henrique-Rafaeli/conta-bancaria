namespace ContaBancaria.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente(1000.0, 0.0, 12);
        ContaCorrente conta2 = new ContaCorrente(300.0, 0.0, 13);

        Console.WriteLine($"{conta1.saldo} {conta2.saldo}");

        conta1.Sacar(200.0);
        
        conta1.Depositar(300.0);
        
        conta1.Depositar(500.0);
        
        conta1.Sacar(200.0);

        conta1.TransferirPara(conta2, 400.0);

        Console.WriteLine($"{conta1.saldo} {conta2.saldo}");

        Console.ReadLine();
    }
}

namespace ContaBancaria.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente(1000.0, 0.0, 12, 10);
        ContaCorrente conta2 = new ContaCorrente(300.0, 0.0, 13, 10);


        conta1.Sacar(200.0);
        
        conta1.Depositar(300.0);
        
        conta1.Depositar(500.0);
        
        conta1.Sacar(200.0);

        conta1.TransferirPara(conta2, 400.0);

        string[] extratoConta1 = conta1.RetornarExtrato();
        string[] extratoConta2 = conta2.RetornarExtrato();

        Menu.ExibirExtrato(extratoConta1);
        Menu.ExibirExtrato(extratoConta2);

        Console.ReadLine();
    }
}

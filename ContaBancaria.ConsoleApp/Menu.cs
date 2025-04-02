namespace ContaBancaria.ConsoleApp;

public static class Menu
{
    public static void ExibirExtrato(string[] extrato)
    {
        foreach (string i in extrato)
        {
            if (!String.IsNullOrEmpty(i))
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();
    }

}

namespace ContaBancaria.ConsoleApp;

public class ContaCorrente
{
    public double saldo;
    public double limite;
    public int numero;

    public ContaCorrente(double saldo, double limite, int numero)
    {
        this.saldo = saldo;
        this.limite = limite;
        this.numero = numero;
    }

    public void Sacar(double valor)
    {
        double limitePermitido = saldo + limite;
        
        if (valor > 0)
        {
            if (valor <= limitePermitido)
                saldo -= valor;
        }
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
            saldo += valor;
    }

    public void TransferirPara(ContaCorrente contaParaTransferir, double valor)
    {
        double limitePermitido = saldo + limite;

        if (valor > 0)
        {
            if (valor <= limitePermitido)
            {
                contaParaTransferir.Depositar(valor);
                saldo -= valor;
            }
        }
    }

    public void ExibirExtrato()
    {

    }
}

namespace ContaBancaria.ConsoleApp;

public class ContaCorrente
{
    public double saldo;
    public double limite;
    public int numero;
    Movimentacao[] movimentacoes;
    private int indiceMovimentacao = 0;
    private int maximoMovimentacoes;


    public ContaCorrente(double saldo, double limite, int numero, int maximoMovimentacoes)
    {
        this.saldo = saldo;
        this.limite = limite;
        this.numero = numero;
        movimentacoes = new Movimentacao[maximoMovimentacoes];
        this.maximoMovimentacoes = maximoMovimentacoes;
    }

    public void Sacar(double valor)
    {
        double limitePermitido = saldo + limite;
        
        if (valor > 0 && valor <= limitePermitido)
        {
            saldo -= valor;
            VerificarIndiceMovimentacao();
            Movimentacao novaMovimentacao = new Movimentacao(valor, "Débito");
            movimentacoes[indiceMovimentacao] = novaMovimentacao;
            indiceMovimentacao++;
        }
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            VerificarIndiceMovimentacao();
            Movimentacao novaMovimentacao = new Movimentacao(valor, "Crédito");
            movimentacoes[indiceMovimentacao] = novaMovimentacao;
            indiceMovimentacao++;
        }
    }

    public void TransferirPara(ContaCorrente contaParaTransferir, double valor)
    {
        double limitePermitido = saldo + limite;

        if (valor > 0 && valor <= limitePermitido)
        {
            contaParaTransferir.Depositar(valor);
            saldo -= valor;
            VerificarIndiceMovimentacao();
            Movimentacao novaMovimentacao = new Movimentacao(valor, "Transferência", contaParaTransferir.numero);
            movimentacoes[indiceMovimentacao] = novaMovimentacao;
            indiceMovimentacao++;
        }
    }

    private void VerificarIndiceMovimentacao()
    {
        if (indiceMovimentacao >= maximoMovimentacoes)
            indiceMovimentacao = 0;
    }

    public string[] RetornarExtrato()
    {
        int tamanhoExtrato = movimentacoes.Length + 8;
        string[] extrato = new string[tamanhoExtrato];

        extrato[0] = "----------------------------------";
        extrato[1] = $"Extrato da conta #{numero}";
        extrato[2] = "----------------------------------";
        extrato[3] = "Movimentações:";
        extrato[4] = "----------------------------------";

        int indice = 5;

        for (int i = 0; i < movimentacoes.Length; i++)
        {
            if (movimentacoes[i] != null)
            {
                if (movimentacoes[i].tipo != "")
                {
                    extrato[i + 5] = movimentacoes[i].ObterDescricao();
                    indice++;
                }
            }
        }

        extrato[indice] = "----------------------------------";
        extrato[indice + 1] = $"Saldo atual: R$ {saldo:F2}";
        extrato[indice + 2] = "----------------------------------";

        return extrato;
    }
}

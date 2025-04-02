namespace ContaBancaria.ConsoleApp;

class Movimentacao
{
    public double valor;
    public string tipo;
    public int conta;

    public Movimentacao(double valor, string tipo, int conta = -1)
    {
        this.valor = valor;
        this.tipo = tipo;
        this.conta = conta;
    }

    public string ObterDescricao()
    {
        string descricao;
        if (conta == -1)
            descricao = $"{tipo} de R$ {valor:F2}";
        else
            descricao = $"{tipo} de R$ {valor:F2} para a conta #{conta}";

        return descricao;
    }

}

using System;
class Extrato
{
    private string data;
    private double valor;
    public Extrato(string data, double valor)
    {
        this.data = data;
        this.valor = valor;
    }
    public string GetData() { return data; }
    public double GetValor() { return valor; }
}
class Cartao
{
    private string numero;
    private string validade;
    public Cartao(string numero, string validade)
    {
        this.numero = numero;
        this.validade = validade;
    }
    public string GetNumero() { return numero; }
    public string GetValidade() { return validade; }
    public void SetNumero(string numero) { this.numero = numero; }
    public void SetValidade(string validade) { this.validade = validade; }
}
class Conta
{
    private string nomeCliente;
    private int numero;
    private double saldo;
    private Extrato[] extratos;
    private int totalExtratos;
    private Cartao cartao;
    public Conta(string nomeCliente, int numero, double saldo)
    {
        this.nomeCliente = nomeCliente;
        this.numero = numero;
        this.saldo = saldo;
        this.extratos = new Extrato[1000];
        this.totalExtratos = 0;
        this.cartao = null;
    }
    public double ObterSaldo() { return saldo; }
    public int ObterNumero() { return numero; }
    public string ObterNomeCliente() { return nomeCliente; }
    public Cartao GetCartao() { return cartao; }
    public void SetCartao(Cartao cartao) { this.cartao = cartao; }
    public void Depositar(double valor, string data)
    {
        saldo += valor;
        // Registrar no extrato
        if (totalExtratos < 1000)
        {
            extratos[totalExtratos] = new Extrato(data, valor);
            totalExtratos++;
        }
        Console.WriteLine($"Deposito de R${valor} realizado na conta {numero}");
    }
    public void Sacar(double valor, string data)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            // Registrar no extrato (valor negativo = saque)
            if (totalExtratos < 1000)
            {
                extratos[totalExtratos] = new Extrato(data, -valor);
                totalExtratos++;
            }
            Console.WriteLine($"Saque de R${valor} realizado na conta {numero}");
        }
        else
        {
            Console.WriteLine($"Saldo insuficiente na conta {numero}");
        }
    }
    public void SacarComCartao(string numeroCartao, string validadeCartao, double valor, string data)
    {
        if (cartao == null)
        {
            Console.WriteLine("Esta conta nao possui cartao.");
            return;
        }
        if (cartao.GetNumero() == numeroCartao && cartao.GetValidade() == validadeCartao)
        {
            Sacar(valor, data);
        }
        else
        {
            Console.WriteLine("Dados do cartao invalidos.");
        }
    }
    public void ExibirRelatorio()
    {
        Console.WriteLine($"\n--- Conta {numero} ---");
        Console.WriteLine($"Titular: {nomeCliente}");
        Console.WriteLine($"Saldo atual: R${saldo}");
        if (cartao != null)
        {
            Console.WriteLine($"Cartao: {cartao.GetNumero()} (Validade: {cartao.GetValidade()})");
        }
        Console.WriteLine("Extrato:");
        for (int i = 0; i < totalExtratos; i++)
        {
            string tipo = extratos[i].GetValor() >= 0 ? "Deposito" : "Saque";
            Console.WriteLine($"  {extratos[i].GetData()} | {tipo} | R${Math.Abs(extratos[i].GetValor())}");
        }
    }
}
class Program
{
    static void Main()
    {
        // Criar 3 contas
        Conta conta1 = new Conta("Maria Silva", 1001, 500);
        Conta conta2 = new Conta("Joao Santos", 1002, 1000);
        Conta conta3 = new Conta("Ana Oliveira", 1003, 250);
        // Criar cartoes e associar as contas
        Cartao cartao1 = new Cartao("4111-1111-1111-1111", "12/2028");
        Cartao cartao2 = new Cartao("5222-2222-2222-2222", "06/2027");
        Cartao cartao3 = new Cartao("3333-3333-3333-3333", "09/2029");
        conta1.SetCartao(cartao1);
        conta2.SetCartao(cartao2);
        conta3.SetCartao(cartao3);
        // Operacoes de deposito e saque
        conta1.Depositar(200, "22/02/2026");
        conta1.Sacar(100, "22/02/2026");
        conta1.Depositar(350, "23/02/2026");
        conta2.Depositar(500, "22/02/2026");
        conta2.Sacar(300, "23/02/2026");
        conta3.Depositar(100, "22/02/2026");
        conta3.Sacar(50, "22/02/2026");
        // Saque com cartao
        Console.WriteLine("\n=== SAQUE COM CARTAO ===");
        conta1.SacarComCartao("4111-1111-1111-1111", "12/2028", 150, "24/02/2026");
        conta2.SacarComCartao("0000-0000-0000-0000", "01/2025", 100, "24/02/2026"); // cartao invalido
        // Relatorio de todas as contas
        Console.WriteLine("\n=== RELATORIO DAS CONTAS ===");
        conta1.ExibirRelatorio();
        conta2.ExibirRelatorio();
        conta3.ExibirRelatorio();
    }
}

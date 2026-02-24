using System;
using System.Collections.Generic;
class Produto
{
	private string nome;
	private double preco;
	private int estoque;
	public Produto(string nome, double preco, int estoque)
	{
		this.nome = nome;
		this.preco = preco;
		this.estoque = estoque;
	}
	public string GetNome() { return nome; }
	public double GetPreco() { return preco; }
	public int GetEstoque() { return estoque; }
	public void SetNome(string nome) { this.nome = nome; }
	public void SetPreco(double preco) { this.preco = preco; }
	public void SetEstoque(int estoque) { this.estoque = estoque; }
}
class ItemPedido
{
	private Produto produto;
	private int quantidade;
	public ItemPedido(Produto produto, int quantidade)
	{
		this.produto = produto;
		this.quantidade = quantidade;
	}
	public Produto GetProduto() { return produto; }
	public int GetQuantidade() { return quantidade; }
}
class Pedido
{
	private List<ItemPedido> itens;
	private string formaPagamento;
	public Pedido(string formaPagamento)
	{
		this.itens = new List<ItemPedido>();
		this.formaPagamento = formaPagamento;
	}
	public string GetFormaPagamento() { return formaPagamento; }
	public void AdicionarItem(Produto produto, int quantidade)
	{
		if (produto.GetEstoque() >= quantidade)
		{
			itens.Add(new ItemPedido(produto, quantidade));
			produto.SetEstoque(produto.GetEstoque() - quantidade);
		}
		else
		{
			Console.WriteLine($"Estoque insuficiente para {produto.GetNome()}");
		}
	}
	public double CalcularTotal()
	{
		double total = 0;
		foreach (ItemPedido item in itens)
		{
			total += item.GetProduto().GetPreco() * item.GetQuantidade();
		}
		return total;
	}
	public void ExibirPedido()
	{
		Console.WriteLine("=== PEDIDO ===");
		foreach (ItemPedido item in itens)
		{
			double subtotal = item.GetProduto().GetPreco() * item.GetQuantidade();
			Console.WriteLine($"{item.GetProduto().GetNome()} x{item.GetQuantidade()} = R${subtotal}");
		}
		Console.WriteLine($"Pagamento: {formaPagamento}");
		Console.WriteLine($"Total: R${CalcularTotal()}");
	}
}
class Program
{
	static void Main()
	{
		Produto arroz = new Produto("Arroz 5kg", 22.90, 50);
		Produto feijao = new Produto("Feijao 1kg", 8.50, 30);
		Produto leite = new Produto("Leite 1L", 5.99, 100);
		Pedido pedido = new Pedido("cartao");
		pedido.AdicionarItem(arroz, 2);
		pedido.AdicionarItem(feijao, 3);
		pedido.AdicionarItem(leite, 6);
		pedido.ExibirPedido();
	}
}
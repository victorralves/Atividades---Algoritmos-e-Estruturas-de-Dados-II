using System;
using System.Collections.Generic;
class Livro
{
    private string titulo;
    private string autor;
    private bool disponivel;
    public Livro(string titulo, string autor)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.disponivel = true;
    }
    public string GetTitulo() { return titulo; }
    public string GetAutor() { return autor; }
    public bool GetDisponivel() { return disponivel; }
    public void SetDisponivel(bool disponivel) { this.disponivel = disponivel; }
}
class Pessoa
{
    private string nome;
    public Pessoa(string nome)
    {
        this.nome = nome;
    }
    public string GetNome() { return nome; }
    public void SetNome(string nome) { this.nome = nome; }
}
class Emprestimo
{
    private Livro livro;
    private Pessoa pessoa;
    private string data;
    public Emprestimo(Livro livro, Pessoa pessoa, string data)
    {
        this.livro = livro;
        this.pessoa = pessoa;
        this.data = data;
        livro.SetDisponivel(false);
    }
    public Livro GetLivro() { return livro; }
    public Pessoa GetPessoa() { return pessoa; }
    public string GetData() { return data; }
    public void Devolver()
    {
        livro.SetDisponivel(true);
        Console.WriteLine($"Livro '{livro.GetTitulo()}' devolvido por {pessoa.GetNome()}");
    }
}
class Program
{
    static void Main()
    {
        Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis");
        Livro livro2 = new Livro("O Cortico", "Aluisio Azevedo");
        Pessoa pessoa1 = new Pessoa("Ana");
        Pessoa pessoa2 = new Pessoa("Bruno");
        List<Emprestimo> emprestimos = new List<Emprestimo>();
        // Realizar emprestimo
        if (livro1.GetDisponivel())
        {
            emprestimos.Add(new Emprestimo(livro1, pessoa1, "22/02/2026"));
            Console.WriteLine($"Emprestimo: '{livro1.GetTitulo()}' para {pessoa1.GetNome()}");
        }
        if (livro2.GetDisponivel())
        {
            emprestimos.Add(new Emprestimo(livro2, pessoa2, "22/02/2026"));
            Console.WriteLine($"Emprestimo: '{livro2.GetTitulo()}' para {pessoa2.GetNome()}");
        }
        // Tentar emprestar livro ja emprestado
        if (livro1.GetDisponivel())
        {
            emprestimos.Add(new Emprestimo(livro1, pessoa2, "22/02/2026"));
        }
        else
        {
            Console.WriteLine($"Livro '{livro1.GetTitulo()}' nao esta disponivel.");
        }
        // Devolver
        emprestimos[0].Devolver();
        // Listar livros
        Console.WriteLine("\n=== LIVROS ===");
        List<Livro> livros = new List<Livro>();
        livros.Add(livro1);
        livros.Add(livro2);
        foreach (Livro livro in livros)
        {
            string status = livro.GetDisponivel() ? "Disponivel" : "Emprestado";
            Console.WriteLine($"{livro.GetTitulo()} - {status}");
        }
    }
}
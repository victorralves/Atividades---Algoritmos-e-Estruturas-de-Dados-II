using System;
using System.Collections.Generic;
class Contato
{
    private string nome;
    private string telefone;
    public Contato(string nome, string telefone)
    {
        this.nome = nome;
        this.telefone = telefone;
    }
    public string GetNome() { return nome; }
    public string GetTelefone() { return telefone; }
    public void SetNome(string nome) { this.nome = nome; }
    public void SetTelefone(string telefone) { this.telefone = telefone; }
}
class Agenda
{
    private List<Contato> contatos;
    public Agenda()
    {
        contatos = new List<Contato>();
    }
    public void Adicionar(string nome, string telefone)
    {
        contatos.Add(new Contato(nome, telefone));
        Console.WriteLine($"Contato adicionado: {nome}");
    }
    public void Remover(string nome)
    {
        foreach (Contato c in contatos)
        {
            if (c.GetNome() == nome)
            {
                contatos.Remove(c);
                Console.WriteLine($"Contato removido: {nome}");
                return;
            }
        }
        Console.WriteLine("Contato nao encontrado.");
    }
    public void Buscar(string nome)
    {
        foreach (Contato c in contatos)
        {
            if (c.GetNome() == nome)
            {
                Console.WriteLine($"Encontrado: {c.GetNome()} - {c.GetTelefone()}");
                return;
            }
        }
        Console.WriteLine("Contato nao encontrado.");
    }
    public void Listar()
    {
        Console.WriteLine("=== AGENDA ===");
        foreach (Contato c in contatos)
        {
            Console.WriteLine($"{c.GetNome()} - {c.GetTelefone()}");
        }
    }
}
class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        agenda.Adicionar("Maria", "(11) 99999-1111");
        agenda.Adicionar("Joao", "(21) 98888-2222");
        agenda.Adicionar("Ana", "(31) 97777-3333");
        agenda.Listar();
        agenda.Buscar("Joao");
        agenda.Remover("Maria");
        agenda.Listar();
    }
}
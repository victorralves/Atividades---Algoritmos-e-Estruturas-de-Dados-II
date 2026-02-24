using System;
class Animal
{
    private string nome;
    private string tipo;
    public Animal(string nome, string tipo)
    {
        this.nome = nome;
        // Tipos validos: cachorro, gato, peixe
        // Se for diferente, define como peixe
        if (tipo == "cachorro" || tipo == "gato" || tipo == "peixe")
        {
            this.tipo = tipo;
        }
        else
        {
            this.tipo = "peixe";
        }
    }
    public string GetNome() { return nome; }
    public string GetTipo() { return tipo; }
    public void SetNome(string nome) { this.nome = nome; }
    public void SetTipo(string tipo) { this.tipo = tipo; }
}
class Program
{
    static void Main()
    {
        Animal[] animais = new Animal[5];
        // Ler dados dos 5 animais
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"--- Animal {i + 1} ---");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Tipo (cachorro, gato ou peixe): ");
            string tipo = Console.ReadLine();
            animais[i] = new Animal(nome, tipo);
            Console.WriteLine();
        }
        // Contar quantos de cada tipo
        int cachorros = 0;
        int gatos = 0;
        int peixes = 0;
        foreach (Animal a in animais)
        {
            if (a.GetTipo() == "cachorro")
            {
                cachorros++;
            }
            else if (a.GetTipo() == "gato")
            {
                gatos++;
            }
            else if (a.GetTipo() == "peixe")
            {
                peixes++;
            }
        }
        // Exibir resultado
        Console.WriteLine("=== RESULTADO ===");
        Console.WriteLine($"Cachorros: {cachorros}");
        Console.WriteLine($"Gatos: {gatos}");
        Console.WriteLine($"Peixes: {peixes}");
    }
}

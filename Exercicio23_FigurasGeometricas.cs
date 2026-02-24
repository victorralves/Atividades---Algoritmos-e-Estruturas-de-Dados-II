using System;
// Classe base
class FiguraGeometrica
{
    private string nome;
    public FiguraGeometrica(string nome)
    {
        this.nome = nome;
    }
    public string GetNome() { return nome; }
    public virtual double CalcularArea()
    {
        return 0;
    }
}
// Heranca: Quadrado
class Quadrado : FiguraGeometrica
{
    private double lado;
    public Quadrado(double lado) : base("Quadrado")
    {
        this.lado = lado;
    }
    public double GetLado() { return lado; }
    public override double CalcularArea()
    {
        return lado * lado;
    }
}
// Heranca: Retangulo
class Retangulo : FiguraGeometrica
{
    private double largura;
    private double altura;
    public Retangulo(double largura, double altura) : base("Retangulo")
    {
        this.largura = largura;
        this.altura = altura;
    }
    public double GetLargura() { return largura; }
    public double GetAltura() { return altura; }
    public override double CalcularArea()
    {
        return largura * altura;
    }
}
// Heranca: Triangulo
class Triangulo : FiguraGeometrica
{
    private double baseTriangulo;
    private double altura;
    public Triangulo(double baseTriangulo, double altura) : base("Triangulo")
    {
        this.baseTriangulo = baseTriangulo;
        this.altura = altura;
    }
    public double GetBaseTriangulo() { return baseTriangulo; }
    public double GetAltura() { return altura; }
    public override double CalcularArea()
    {
        return (baseTriangulo * altura) / 2;
    }
}
// Heranca: Circulo
class Circulo : FiguraGeometrica
{
    private double raio;
    public Circulo(double raio) : base("Circulo")
    {
        this.raio = raio;
    }
    public double GetRaio() { return raio; }
    public override double CalcularArea()
    {
        return 3.14 * raio * raio;
    }
}
class Program
{
    static void Main()
    {
        // Polimorfismo: todos sao FiguraGeometrica, mas cada um calcula a area diferente
        FiguraGeometrica[] figuras = new FiguraGeometrica[4];
        figuras[0] = new Quadrado(5);
        figuras[1] = new Retangulo(8, 4);
        figuras[2] = new Triangulo(6, 3);
        figuras[3] = new Circulo(7);
        Console.WriteLine("=== AREAS DAS FIGURAS ===");
        foreach (FiguraGeometrica figura in figuras)
        {
            Console.WriteLine($"{figura.GetNome()}: Area = {figura.CalcularArea()}");
        }
    }
}
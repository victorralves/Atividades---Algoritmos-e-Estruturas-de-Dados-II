using System;
class CorpoCeleste
{
    private double massa;
    private double densidade;
    private double posicaoX;
    private double posicaoY;
    public CorpoCeleste(double massa, double densidade, double posicaoX, double posicaoY)
    {
        this.massa = massa;
        this.densidade = densidade;
        this.posicaoX = posicaoX;
        this.posicaoY = posicaoY;
    }
    public double GetMassa() { return massa; }
    public double GetDensidade() { return densidade; }
    public double GetPosicaoX() { return posicaoX; }
    public double GetPosicaoY() { return posicaoY; }
    public void SetMassa(double massa) { this.massa = massa; }
    public void SetDensidade(double densidade) { this.densidade = densidade; }
    public void SetPosicaoX(double posicaoX) { this.posicaoX = posicaoX; }
    public void SetPosicaoY(double posicaoY) { this.posicaoY = posicaoY; }
    // Raio calculado a partir da massa e da densidade
    // Volume = massa / densidade
    // Volume da esfera = (4/3) * pi * r^3
    // r = raiz cubica de (3 * volume) / (4 * pi)
    public double CalcularRaio()
    {
        double volume = massa / densidade;
        double raio = Math.Pow((3 * volume) / (4 * Math.PI), 1.0 / 3.0);
        return raio;
    }
}
class Program
{
    static void Main()
    {
        CorpoCeleste[] corpos = new CorpoCeleste[10];
        // Preencher os dados dos 10 corpos celestes
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"--- Corpo Celeste {i + 1} ---");
            Console.Write("Massa: ");
            double massa = double.Parse(Console.ReadLine());
            Console.Write("Densidade: ");
            double densidade = double.Parse(Console.ReadLine());
            Console.Write("Posicao X: ");
            double posX = double.Parse(Console.ReadLine());
            Console.Write("Posicao Y: ");
            double posY = double.Parse(Console.ReadLine());
            corpos[i] = new CorpoCeleste(massa, densidade, posX, posY);
            Console.WriteLine();
        }
        // Encontrar o corpo de maior massa
        int indiceMaiorMassa = 0;
        for (int i = 1; i < 10; i++)
        {
            if (corpos[i].GetMassa() > corpos[indiceMaiorMassa].GetMassa())
            {
                indiceMaiorMassa = i;
            }
        }
        // Encontrar o corpo de maior raio
        int indiceMaiorRaio = 0;
        for (int i = 1; i < 10; i++)
        {
            if (corpos[i].CalcularRaio() > corpos[indiceMaiorRaio].CalcularRaio())
            {
                indiceMaiorRaio = i;
            }
        }
        // Encontrar os dois mais distantes entre si no eixo X
        int indiceA = 0;
        int indiceB = 1;
        double maiorDistancia = 0;
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                double distancia = Math.Abs(corpos[i].GetPosicaoX() - corpos[j].GetPosicaoX());
                if (distancia > maiorDistancia)
                {
                    maiorDistancia = distancia;
                    indiceA = i;
                    indiceB = j;
                }
            }
        }
        // Resultados
        Console.WriteLine("=== RESULTADOS ===");
        Console.WriteLine($"Corpo de maior massa: Corpo {indiceMaiorMassa + 1} (massa = {corpos[indiceMaiorMassa].GetMassa()})");
        Console.WriteLine($"Corpo de maior raio: Corpo {indiceMaiorRaio + 1} (raio = {corpos[indiceMaiorRaio].CalcularRaio()})");
        Console.WriteLine($"Mais distantes no eixo X: Corpo {indiceA + 1} e Corpo {indiceB + 1} (distancia = {maiorDistancia})");
    }
}
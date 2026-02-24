////====================================================== lista 1 =========================================================


//////Exercicio 1
////Console.WriteLine("Digite o valor de a");
////double a = double.Parse(Console.ReadLine());
////Console.WriteLine("Digite o valor de b");
////double b = double.Parse(Console.ReadLine());
////Console.WriteLine("Digite o valor de c");
////double c = double.Parse(Console.ReadLine());

////Console.WriteLine($"Equação: {a}x^2 + {b}x +{c} = 0");
////double delta = Math.Pow(b, 2) - 4 * a * c;
////if (delta < 0)
////{
////    Console.WriteLine("A equação não possui raízes reais.");
////    return;
////}
////double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
////double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
////Console.WriteLine($"Primeira raiz: {raiz1}\n Segunda raiz: {raiz2}");



//////Exercicio 2
////double[] pontoA = new double[3];
////double[] pontoB = new double[3];
////Console.WriteLine("digite as coordenadas do ponto A nessa ordem: x,y,z e separados por virgla!");
////String entrada = Console.ReadLine();
////String[] entradaVet = entrada.Split(',');
////for (int i = 0; i < pontoA.Length; i++)
////{
////    pontoA[i] = double.Parse(entradaVet[i]);
////}
////Console.WriteLine("digite as coordenadas do ponto B nessa ordem: x,y,z e separados por virgla!");
////entrada = Console.ReadLine();
////entradaVet = entrada.Split(',');
////for (int i = 0; i < pontoB.Length; i++)
////{
////    pontoB[i] = double.Parse(entradaVet[i]);
////}

////double distancia = Math.Sqrt(Math.Pow(pontoA[0] - pontoB[0], 2) + Math.Pow(pontoA[1] - pontoB[1], 2) + Math.Pow(pontoA[2] - pontoB[2], 2));
////Console.WriteLine($"a distancia é: {distancia}");



//////Exercicio 3
////o erro esta nessa linha de código:
////"distancia = Math.pow(Math.pow(x2-x1, 2) + Math.pow(y2-y1, 2), 1/2);"
////já que no java 1/2 é uma divisão inteira então não vai dar 0,5 mas sim 0 como resultado.
////o  trecho do codigo corrigido:
////"distancia = Math.pow(Math.pow(x2-x1, 2) + Math.pow(y2-y1, 2), 0.5);"



//////Exercicio 4
////Console.WriteLine("digite o nome, o preco e a quantidade do produto comprado nessa ordem e separados por espacos!");
////Console.WriteLine("OBS.: se for numero quebrado separar com virgula ex: 1,5");
////string[] entrada = Console.ReadLine().Split(" ");
////string nome = entrada[0];
////double preco = double.Parse(entrada[1]);
////int quant = int.Parse(entrada[2]);
////if (quant <= 10)
////{
////    Console.WriteLine($"o valor a ser pago por {quant} unidade de {nome} e: {preco * quant}");
////}
////else if (quant > 10 && quant < 20)
////{
////    double valor = (quant * preco);
////    Console.WriteLine($"o valor a ser pago por {quant} unidade de {nome} e: {valor - (valor * 0.1)}");
////}
////else if (quant > 20 && quant <= 50)
////{
////    double valor = (quant * preco);
////    Console.WriteLine($"o valor a ser pago por {quant} unidade de {nome} e: {valor - (valor * 0.2)}");
////}
////else if (quant > 50)
////{
////    double valor = (quant * preco);
////    Console.WriteLine($"o valor a ser pago por {quant} unidade de {nome} e: {valor - (valor * 0.25)}");
////}



//////Exercício 5
////for (int i = 1; i <= 10; i++)
////{
////    for (int j = 1; j <= 10; j++)
////    {
////        Console.WriteLine($"{i} x {j} = {i * j}");
////    }
////    Console.WriteLine();
////}



//////Exercício 6
////Console.WriteLine("digite um numero");
////string numero = Console.ReadLine();
////char[] numeroVet = numero.ToCharArray();
////int cont = 0;
////foreach (char c in numeroVet)
////{
////    cont++;
////}
////Console.WriteLine($"qtd de digitos: {cont}");


//======================================== Atividade diagnostica exercício 1 ============================================




//class Veiculo
//{
//    private int qtdOcupantes;
//    private int qtdRodas;
//    private double capacidadeDoTanque;
//    private double nivelDoTanque;
//    private double consumo;
//    private float quilometragem;
//    private double autonomia;

//    public Veiculo()
//    {
//        qtdOcupantes = 0;
//        qtdRodas = 4;
//        capacidadeDoTanque = 0;
//        nivelDoTanque = 0;
//        consumo = 0;
//        quilometragem = 0;
//        autonomia = 0;
//    }
//    public Veiculo(int ocupantes, int rodas, double capTanque,
//                   double nivelDoTanque, double consumo,
//                   float quilometragem, double autonomia)
//    {
//        this.qtdOcupantes = ocupantes;
//        this.qtdRodas = rodas;
//        this.capacidadeDoTanque = capTanque;
//        this.nivelDoTanque = nivelDoTanque;
//        this.consumo = consumo;
//        this.quilometragem = quilometragem;
//        this.autonomia = (((nivelDoTanque/100.0)*capTanque)*consumo);
//    }

//    public float GetQuilometragem() => quilometragem;
//    public void SetQuilometragem(float num) => quilometragem = num;

//    public double GetConsumo() => consumo;
//    public void SetConsumo(double num) => consumo = num;
//}

//class Carro : Veiculo
//{
//    private string modelo;
//    private int qtdPortas;

//    public Carro() : base()
//{
//    modelo = "Modelo Padrão";
//    qtdPortas = 4;
//}
//    public Carro(int ocupantes, int rodas, double capTanque,
//                 double nivelDoTanque, double consumo,
//                 float quilometragem, double autonomia,
//                 string modelo, int qtdPortas)
//        : base(ocupantes, rodas, capTanque, nivelDoTanque,
//               consumo, quilometragem, autonomia)
//    {
//        this.modelo = modelo;
//        this.qtdPortas = qtdPortas;
//    }
//    public float Percorrer(float qtdQuilometros)
//    {
//        if (qtdQuilometros < 0)
//        {
//            qtdQuilometros = 0;
//        }

//        float novaQuilometragem = GetQuilometragem() + qtdQuilometros;

//        if (novaQuilometragem > 999999f)
//        {
//            novaQuilometragem = 999999f;
//        }

//        SetQuilometragem(novaQuilometragem);

//        return GetQuilometragem();
//    }
//}






//========================================================= Lista 3 =====================================================



////Exercício nível fácil 1
//string nome = "hallisson";
//for(int i = 0; i < 100; i++)
//{
//    Console.WriteLine(nome);
//}



////Exercício nível médio 1
//public class QuadradoOuRetangulo
//{
//    private double b;
//    private double a;

//    public QuadradoOuRetangulo(double b, double a)
//    {
//        this.a = a;
//        this.b = b;
//    }

//    public void SetA(double a)
//    {
//        this.a = a;
//    }

//    public double GetA()
//    {
//        return this.a;
//    }

//    public void SetB(double b)
//    {
//        this.b = b;
//    }

//    public double GetB()
//    {
//        return this.b;
//    }

//    public double GetArea()
//    {
//        return a * b;
//    }

//    public void ExibirDados()
//    {
//        Console.WriteLine($"Base: {b}");
//        Console.WriteLine($"Altura: {a}");
//        Console.WriteLine($"Área: {GetArea()}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Digite a base do retângulo:");
//        double baseR = double.Parse(Console.ReadLine());

//        Console.WriteLine("Digite a altura do retângulo:");
//        double alturaR = double.Parse(Console.ReadLine());

//        QuadradoOuRetangulo retangulo = new QuadradoOuRetangulo(baseR, alturaR);

//        Console.WriteLine("\nDados do retângulo:");
//        retangulo.ExibirDados();
//    }
//}

////Exercício 1 nível difícil

//class Lampada
//{
//    private bool ligada;
//    private string estado;
//    private Random rnd;
//    public Lampada()
//    {
//        rnd = new Random();
//        ligada = false;
//        estado = "desligada";
//    }
//    public string GetEstado()
//    {
//        return estado;
//    }
//    public void Ligar()
//    {
//        if (rnd.Next(0, 7) == 1)
//        {
//            estado = "queimada";
//            ligada = false;
//        }
//        else {
//            ligada = true;
//            estado = "ligada";
//        }
            
//    }
//    public void Desligar()
//    {
//        ligada = false;
//        estado = "desligada";
//    }
//    public void ExibirInfo()
//    {
//        Console.WriteLine(GetEstado());
//    }
//}
//class Lampada2 : Lampada
//{
//    private int potencia;
//    private int voltagem;
//    public Lampada2() : base(){
//        potencia = 220;
//        voltagem = 60;
//    }
//    public void SetVoltagem (int voltagem){ 
//        this.voltagem = voltagem;
//    }
//    public int GetVoltagem()
//    {
//        return voltagem;
//    }
//    public void SetPotencia (int potencia){ 
//        this.potencia = potencia;
//    }
//    public int GetPotencia()
//    {
//        return potencia;
//    }
//    public void ExibirInfo()
//    {
//        Console.WriteLine(GetPotencia());
//        Console.WriteLine(GetVoltagem());
//        Console.WriteLine(GetEstado());
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Lampada2 lamp = new Lampada2();
//        lamp.ExibirInfo();
//        lamp.Ligar();
//        lamp.ExibirInfo();
//    }
//}

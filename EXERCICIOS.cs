//%% LISTA 1 - 7 a 11 %%

//// ATIVIDADE 7
//Letra A) O programa certo é o Programa B!
//Letra B) Igualando a váriavel "codigo" a 0! Assim nao daria erro inicial pelo fato de "codigo" estar vazio!
//Programa Corrigido ->
//import java.util.Scanner;
//public class Codigo
//{
//    public static void main(String[] args)
//    {
//        Scanner teclado = new Scanner(System.in);
//        int codigo = 0;

//        while (codigo != -1)
//        {
//            System.out.print("Informe o código: ");
//            codigo = teclado.nextInt();
//            System.out.println("Código: " + codigo);
//        }
//        ;
//    }
//}

//// ATIVIDADE 8
//public class Fibonacci
//{
//    public static void Main(String[] args)
//    {
//        int numero;
//        int n;

//        while (true)
//        {
//            Console.WriteLine("Entre com um número para ver a sequência de Fibonacci: ");
//            numero = Convert.ToInt16(Console.ReadLine());
//            if (numero <= 0)
//            {
//                Console.WriteLine("Entre com um número positivo!");
//            }
//            else
//            {
//                break;
//            }
//        }
//        ETAPA QUE É PEDIDO O NÚMERO DE ENTRADA E CHECAGEM PARA O COMEÇO DO CÓDIGO!

//        int[] lista = new int[numero + 1]; LISTA PARA MOSTRAR A SEQUENCIA!

//        for (int i = 0; i < (numero + 1); i++)
//        {
//            if (i == 0 || i == 1)
//            {
//                lista[i] = i; SE O NÚMERO EM QUESTÃO FOR 0 ou 1 ELE ADICIONAR DIRETO NA LISTA!
//            }
//            else
//            {
//                n = lista[i - 1] + lista[i - 2]; CALCULO PARA A SEQUENCIA DE FIBONACCI!
//                lista[i] = n;
//            }
//        }

//        Console.WriteLine("\nSegue a Sequência =>");
//        for (int j = 0; j < lista.Length; j++) ENTRA COM OS NÚMEROS DA LISTA PARA O TERMINAL!
//        {
//            Console.WriteLine(lista[j]);
//        }

//    }
//}

//// ATIVIDADE 9
//A saída vai ser =
// 2, 2, 1
// 2, 3, 1
// 2, 3, 3
// 2, 4, 1
// 2, 4, 3
// 4, 4, 1

//// ATIVIDADE 10
//public class Juros
//{
//    public static void Main(String[] args)
//    {

//        double saldo = 0;
//        double valor;
//        double taxa;
//        string resposta;

//        while (true)
//        {
//            Console.WriteLine("Entre com o saldo desejado para o investimento mensal: ");
//            valor = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Qual a taxa mensal para o rendimento?: ");
//            taxa = Convert.ToDouble(Console.ReadLine()) / 100;

//            if (valor > 0 && taxa >= 0)
//            {
//                break;
//            }
//            else
//            {
//                Console.WriteLine("\nColoque valores reais!\n");
//            }
//        }

//        while (true)
//        {
//            for (int i = 0; i < 12; i++)
//            {
//                saldo = (saldo + valor) * (1 + taxa);
//            }
//            Console.WriteLine("\nSaldo do investimento após 1 ano: " + saldo);
//            Console.WriteLine("Deseja processar mais um ano? (S/N)");
//            resposta = Console.ReadLine().ToUpper();
//            if (resposta == "N")
//            {
//                break;
//            }
//        }

//    }
//}

//// ATIVIDADE 11
//public class Raiz
//{
//    public static void Main(string[] args)
//    {
//        double valor;

//        while (true)
//        {
//            Console.WriteLine("Entre com um número para saber sua raiz quadrada aproximada: ");
//            valor = Convert.ToInt16(Console.ReadLine());
//            if (valor > 0){
//                break;
//            }
//            else{
//                Console.WriteLine("\nColoque valores reais!\n");
//            }
//        }
//        //ETAPA QUE É PEDIDO O NÚMERO DE ENTRADA E CHECAGEM PARA O COMEÇO DO CÓDIGO!

//        int raizAproximada = 1;

//        while ((raizAproximada * raizAproximada) <= valor) //VAi entrar em um loop para achar uma raiz próxima!
//        {
//            raizAproximada++;
//        }

//        int raiz = raizAproximada - 1; //Achou! Agora vai diminuir um número, pois o resultado passou!


//        Console.WriteLine($"A raiz aproximada do número {valor}: é" + raiz);
//    }
//}


// --------------------------------------------------


//// %% LISTA 3 %%
//// EXERCICIOS 2, 3 e 4 (Fácil)

////ATIVIDADE 2
//public class Pares
//{
//    public static void Main(string[] args)
//    {
//        int numeros = 0;
//        for (int i = 1; i <= 100; i++)
//        {
//            if (i % 2 == 0)
//            {
//                numeros++;
//            }
//        }
//        Console.WriteLine($"Entre o número 1 e 100 aparecem {numeros} números pares!");
//    }
//}

//// ATIVIDADE 3
//public class Piramide
//{
//    public static void Main(string[] args)
//    {
//        int espaço = 5;

//        for (int i = 1; i <= espaço; i++)
//        {
//            for (int j = 1; j <= espaço - 1; j++)
//            {
//                Console.Write(" ");
//            }
//            for (int k = 1; k <= (2 * i - 1); k++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////ATIVIDADE 4
//public class Fibonacci
//{
//    public static void Main(String[] args)
//    {
//        int numero = 30;
//        int n;

//        int[] lista = new int[numero]; //LISTA PARA MOSTRAR A SEQUENCIA!

//        for (int i = 0; i < numero; i++)
//        {
//            if (i == 0 || i == 1)
//            {
//                lista[i] = i; //SE O NÚMERO EM QUESTÃO FOR 0 ou 1 ELE ADICIONAR DIRETO NA LISTA!
//            }
//            else
//            {
//                n = lista[i - 1] + lista[i - 2]; //CALCULO PARA A SEQUENCIA DE FIBONACCI!
//                lista[i] = n;
//            }
//        }

//        Console.WriteLine("\nSegue a Sequência dos 30 números de Fibonacci =>");
//        for (int j = 0; j < lista.Length; j++) //ENTRA COM OS NÚMEROS DA LISTA PARA O TERMINAL!
//        {
//            Console.WriteLine(lista[j]);
//        }

//    }
//}

//--------------------------------------------

//// %% LISTA 3 %%
//// EXERCICIO 2 e 3 (Médio)


////ATIVIDADE 2
//public class Ponto
//{
//    private int CoordenadasX { get; set; }
//    private int CoordenadasY { get; set; }

//    public Ponto()
//    {
//        CoordenadasX = 0;
//        CoordenadasY = 0;
//    }

//    public Ponto(int x, int y)
//    {
//        this.CoordenadasX = x;
//        this.CoordenadasY = y;
//    }

//    public Ponto(Ponto outro)
//    {
//        CoordenadasX = outro.CoordenadasX;
//        CoordenadasY = outro.CoordenadasY;
//    }

//    public override string ToString()
//    {
//        return "(" + CoordenadasX + ", " + CoordenadasY + ")";
//    }

//    public static void Main(String[] args)
//    {
//        Ponto ponto = new Ponto();
//        Console.WriteLine(ponto);
//    }
//}


////ATIVIDADE 3
//class Pessoas
//{
//    private string Nome {  get; set; }
//    private int Idade { get; set; }

//    public Pessoas()
//    {
//        Nome = "Sem Nome!";
//        Idade = 0;
//    }

//    public Pessoas(string nome, int idade)
//    {
//        this.Nome = nome;
//        this.Idade = idade;
//    }

//    public int RetornarIdade()
//    {
//        return Idade;
//    }

//    public void ExibirDados()
//    {
//        Console.WriteLine($"Nome da Pessoa: {Nome}");
//        Console.WriteLine($"Idade da Pessoa: {Idade}"); 
//    }

//    public static void Main(string[] args)
//    {
//        Pessoas maisVelha = null;

//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine($"\nEntre com o Nome da {i + 1}ª pessoa: ");
//            string nome = Console.ReadLine();
//            Console.WriteLine("\nEntre com a idade dela: ");
//            int idade = Convert.ToInt16(Console.ReadLine());
//            Pessoas p = new Pessoas(nome, idade);

//            if (maisVelha == null || p.RetornarIdade() > maisVelha.RetornarIdade())
//            {
//                maisVelha = p;
//            }
//        }

//        Console.WriteLine("\nPessoa com maior idade:");
//        maisVelha.ExibirDados();

//    }
//}

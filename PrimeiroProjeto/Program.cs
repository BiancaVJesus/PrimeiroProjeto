
// Screen Sound (App de músicas)

using System.Linq.Expressions;

String mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());


void ExibirLogo()
{
    Console.WriteLine(@"
    


     █▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
     ▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀


");
   
    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesDoMenu()

{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    //utilizando a exclamação para definir que o valor do ReadLine não é nulo 
    string opcaoEscolhida = Console.ReadLine()!;
    //aqui precisamos inverter a opcaoEscolhida que está com tipo String mas recebera um valor numerico de acordo com o menu que criamos.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    //if(opcaoEscolhidaNumerica == 1)
    //{ 
    //    Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica); 
    //}
    //else if (opcaoEscolhidaNumerica == 2)
    //{
    //    Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
    //}


    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
                break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }

}
    void RegistrarBandas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir todas as bandas registradas");


    //for(int i = 0; i < listaDasBandas.Count; i++) 

    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");

    //}


    // utilizando foreach para deixar a leitura mais clara, e também minimizar a quantidade de código. Mas, é importante destacarmos os pontos positivos e negativos de utilizarmos foreach e for.
    foreach (string banda in bandasRegistradas.Keys)


    {
        Console.WriteLine($"Banda: {banda}");
    }

        

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();


}


void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    // o empty vai dizer ao código para pegar a string vazia 
    // o padleft vai colocar ao lado esquerdo os asteriscos de acordo com a quantidade de letras
    String asteriscos = String.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");


}



void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    //se a banda existir no dicionario >> atribuir uma nota
    //senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"\n A nota {nota} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();

        ExibirOpcoesDoMenu();

    } else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}



ExibirLogo();
ExibirOpcoesDoMenu();



//// 1 - Criar uma variável chamada curso, e guarde nela o nome do curso estudado.

//String curso = "C#: Criando sua primeira aplicação";

//// 2 - Mostrar o conteúdo da variável curso no console.

//Console.WriteLine(curso);

//// 3 - Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.


////String nome = "Bianca";
////String sobrenome = "Veronez";

//// 4 - Mostrar na tela o nome dos instrutores do curso.

//String nomei1 = "Daniel Portugal";
//String nomei2 = "Guilherme Lima";


//Console.WriteLine(nomei1 + " " + nomei2);


//// testando alteração no git




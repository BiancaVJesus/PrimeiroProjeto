
// Screen Sound (App de músicas)

using System.Linq.Expressions;

String mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

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
            Console.WriteLine("Você escolheu a opção: " + opcaoEscolhidaNumerica);
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
        Console.WriteLine("*********************");
        Console.WriteLine("Registro de bandas");
        Console.WriteLine("*********************\n");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        listaDasBandas.Add(nomeDaBanda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("*************************************\n");


    //for(int i = 0; i < listaDasBandas.Count; i++) 

    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");

    //}


    // utilizando foreach para deixar a leitura mais clara, e também minimizar a quantidade de código. Mas, é importante destacarmos os pontos positivos e negativos de utilizarmos foreach e for.
    foreach (string banda in listaDasBandas)

     

    {
        Console.WriteLine($"Banda: {banda}");
    }

        

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();


}

ExibirLogo();
ExibirOpcoesDoMenu();

// 1 - Criar uma variável chamada curso, e guarde nela o nome do curso estudado.

String curso = "C#: Criando sua primeira aplicação";

// 2 - Mostrar o conteúdo da variável curso no console.

Console.WriteLine(curso);

// 3 - Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.


//String nome = "Bianca";
//String sobrenome = "Veronez";

// 4 - Mostrar na tela o nome dos instrutores do curso.

String nomei1 = "Daniel Portugal";
String nomei2 = "Guilherme Lima";


Console.WriteLine(nomei1 + " " + nomei2);


// testando alteração


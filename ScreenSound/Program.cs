using ScreenSound.Calculadora;
using ScreenSound.Menus;
using ScreenSound.Modelos;
using ScreenSound.Oficina;

/*
 Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.
 */
Filme filme = new("Um sonho de liberdade", 142, new List<Artista>
{
    new Artista("Marlon Brando", 80),
    new Artista("Al Pacino", 81),
    new Artista("Talia Shire", 75)
});

var filme2 = new Filme("O poderoso chefão", 175, new List<Artista>
{
    new Artista("Marlon Brando", 80),
    new Artista("Al Pacino", 81),
    new Artista("Talia Shire", 75)
});
var filme3 = new Filme("Batman - O Cavaleiro das Trevas", 152, new List<Artista>
{
    new Artista("Christian Bale", 47),
    new Artista("Heath Ledger", 28),
    new Artista("Maggie Gyllenhaal", 44)
});
var filme4 = new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<Artista>
{
    new Artista("Elijah Wood", 40),
    new Artista("Ian McKellen", 82),
    new Artista("Viggo Mortensen", 63)
});
var filme5 = new Filme("Green Book - O Guia", 130, new List<Artista>
{
    new Artista("Viggo Mortensen", 63),
    new Artista("Mahershala Ali", 47)
});

List<Filme> meusFilmesFavoritos = new List<Filme>();
meusFilmesFavoritos.Add(filme);
meusFilmesFavoritos.Add(filme2);
meusFilmesFavoritos.Add(filme3);
meusFilmesFavoritos.Add(filme4);
meusFilmesFavoritos.Add(filme5);

foreach (Filme f in meusFilmesFavoritos)
{
    Console.WriteLine($"Filme: {f.Titulo}");
    Console.WriteLine($"Duracao: {f.Duracao}");
    f.ListarElenco();
    Console.WriteLine();
}

Artista artista = new("Ruth", 33);
artista.AdicionarFilme(filme);
artista.AdicionarFilme(filme2);
artista.AdicionarFilme(filme3);
artista.MostrarFilmesAtuados();

Veiculo meuCarro = new Veiculo("Chevrolet", "Cruze", 2020, "ABC1234");
Cliente cliente = new Cliente("Carlos", "rua da sabedoria", "987654321");
Mecanico mecanico = new Mecanico("Mário", "Mecânica Geral");
Oficina oficina = new Oficina();

oficina.AgendarServico(meuCarro, cliente, mecanico, "2023-12-18");
oficina.RealizarServico(meuCarro, mecanico);

Console.WriteLine($"O Resultado da operação é {Calculadora.Calcular(1, 2, '+')}");


Banda ira = new Banda("Ira!");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);


Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());
void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n1. Registrar uma banda");
    Console.WriteLine("2. Mostrar todas as bandas");
    Console.WriteLine("3. Avaliar uma banda");
    Console.WriteLine("4. Exibir a média de uma banda");
    Console.WriteLine("5. Sair");

    Console.Write("\nOpção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibida = opcoes[opcaoEscolhidaNumerica];
        menuASerExibida.Executar(bandasRegistradas);

        if (opcaoEscolhidaNumerica > 0) { 
            ExibirOpcoesDoMenu();
        }
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();
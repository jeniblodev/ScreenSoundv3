namespace ScreenSound.Modelos;

internal record Musica(string Nome, Artista Artista)
{

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
    }
}
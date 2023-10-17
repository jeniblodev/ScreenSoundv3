namespace ScreenSound.Modelos; 

internal record Artista(string Nome, string? Bio, int Id = 0, string? FotoPerfil = null) 
{
    private readonly List<Musica> musicas = new();

    public void AdicionarMusica(Musica musica) 
    {
        musicas.Add(musica);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
    }
}
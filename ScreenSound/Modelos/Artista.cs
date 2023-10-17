namespace ScreenSound.Modelos;

internal record Artista(string Nome, string? Bio, int Id = 0)
{
    private readonly List<Musica> musicas = new();
    public string? FotoPerfil { get; set; } = "https://img.freepik.com/vetores-gratis/silhueta-feminina_23-2147524227.jpg";

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
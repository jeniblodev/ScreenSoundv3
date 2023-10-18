namespace ScreenSound.Modelos;

internal class Artista
{
    public string  Nome { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; } = 0;
    public string? FotoPerfil { get; set; } = "https://img.freepik.com/vetores-gratis/silhueta-feminina_23-2147524227.jpg";
    
    private readonly List<Musica> musicas = new();

    public Artista(string nome, string bio)
    {
        Nome = nome;
        Bio = bio;
    }

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
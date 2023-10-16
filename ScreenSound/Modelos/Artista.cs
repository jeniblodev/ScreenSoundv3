namespace ScreenSound.Modelos; 

internal class Artista 
{
    private List<Musica> musicas = new List<Musica>();
    

    public Artista(string nome, string bio)
    {
        Nome = nome;
        Bio = bio;

    }

    public string Nome { get; }
    public string FotoPerfil { get; }
    public string Bio { get; }

    public IEnumerable<Musica> Musicas => musicas;

    public void AdicionarMusica(Musica musica) 
    {
        musicas.Add(musica);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
    }

    public override string ToString()
    {
        return "Artista:\n" +
            $"Nome: {Nome}\n" +
            $"Foto de Perfil: {FotoPerfil}" +
            $"Bio: {Bio}\n";
    }
}
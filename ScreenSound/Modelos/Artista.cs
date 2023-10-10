namespace ScreenSound.Modelos; 


internal class Artista 
{
    private List<Musica> musicas = new List<Musica>();
    

    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
  
    public List<Musica> Musicas => musicas;

    public void AdicionarMusica(Musica musica) 
    {
        musicas.Add(musica);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista {Nome}");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"Música: {musica.Nome} ({musica.Duracao})");
        }
    }
}
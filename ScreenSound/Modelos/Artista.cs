namespace ScreenSound.Modelos; 

internal class Artista 
{
    private List<Musica> musicas = new List<Musica>();
    

    public string Nome { get; set; }
    public string FotoPerfil { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }

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

    public override string ToString()
    {
        return "Artista:\n" +
            $"Nome: {Nome}\n" +
            $"Foto de Perfil: {FotoPerfil}\n" +
            $"Bio: {Bio}\n";
    }
}
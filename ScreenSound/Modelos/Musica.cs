namespace ScreenSound.Modelos;

internal class Musica
{

    public Musica(Artista artista, string nome)
    {
        Artista = artista;
        Nome = nome;  
    }

    public string Nome { get; }
    public Artista Artista { get; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
    }
}
namespace ScreenSound.Modelos;

internal class Musica
{

    public string Nome { get; set; }
    public Artista Artista { get; set; }

    public int Id { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
    }
}
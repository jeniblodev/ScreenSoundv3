namespace ScreenSound.Modelos;

public class Musica
{
    public Musica(string nome)
    {
        Nome = nome;
       
    }

    public string Nome { get; set; }
    public int Id { get; set; } = 0;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
    }
}
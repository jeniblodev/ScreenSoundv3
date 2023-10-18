namespace ScreenSound.Modelos;

internal record Musica(string Nome, int Id=0)
{

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
    }
}
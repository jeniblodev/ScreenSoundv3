using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Artista> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}

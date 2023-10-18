using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(EntityDAL<Artista> artistaDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}

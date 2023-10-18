using ScreenSound.Banco;
using ScreenSound.Context;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar(ArtistaDAL artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Registro de músicas");
        Console.Write("Digite o título da música que deseja registrar: ");
        string tituloMusica = Console.ReadLine()!;
        using var context = new ScreenSoundContext();
        new MusicaDAL(context).Adicionar(tituloMusica);
        Console.WriteLine($"A música {tituloMusica} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();

       
    }
}

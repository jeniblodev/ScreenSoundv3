using ScreenSound.Banco;
using ScreenSound.Context;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicas : Menu
{
    public override void Executar(EntityDAL<Artista> artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Exibindo todas as músicas registrados na nossa aplicação");

        using var context = new ScreenSoundContext();
        foreach (var musica in new EntityDAL<Musica>(context).Listar())
        {
            Console.WriteLine($"Musica: {musica}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();



   
    }
}

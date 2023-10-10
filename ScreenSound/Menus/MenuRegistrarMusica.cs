﻿using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Registro de músicas");
        Console.Write("Digite o artista cuja música deseja registrar: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (artistasRegistrados.ContainsKey(nomeDoArtista))
        {
            Console.Write("Agora digite o título da música: ");
            string tituloMusica = Console.ReadLine()!;
            Console.Write("Agora digite o genero da música: ");
            string generoMusica = Console.ReadLine()!;
            Artista artista = artistasRegistrados[nomeDoArtista];
            artista.AdicionarMusica(new Musica(artista, tituloMusica, new Genero(generoMusica)));
            Console.WriteLine($"A música {tituloMusica} de {nomeDoArtista} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

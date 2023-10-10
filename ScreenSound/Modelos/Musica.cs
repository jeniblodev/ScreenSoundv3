﻿namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(Artista artista, string nome, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
       
    }

    public string Nome { get; }
    public Artista Artista { get; }
    public Genero Genero { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
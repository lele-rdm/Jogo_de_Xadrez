using System;
using Jogo_de_Xadrez.Tabuleiro;

namespace Jogo_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);

            Console.WriteLine($"Posição: {P}");
        }
    }
}
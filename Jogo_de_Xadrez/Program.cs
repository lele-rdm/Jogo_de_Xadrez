using System;
using Jogo_de_Xadrez.Tabuleiro;

namespace Jogo_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiroo tab = new Tabuleiroo(8, 8);

            Tela.ImprimirTabuleiro(tab);

        }
    }
}
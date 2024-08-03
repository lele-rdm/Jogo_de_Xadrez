using System;
using System.Runtime.InteropServices.Marshalling;
using Jogo_de_Xadrez.Tabuleiro;

namespace Jogo_de_Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiroo tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write($"{tab.Peca(i, j)} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

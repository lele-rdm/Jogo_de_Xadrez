using System;
using Jogo_de_Xadrez.Tabuleiro;
using Jogo_de_Xadrez.Xadrez;

namespace Jogo_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiroo tab = new Tabuleiroo(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 6));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleirooException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
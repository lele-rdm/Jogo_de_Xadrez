using System;
using Jogo_de_Xadrez.Tabuleiro;
using Jogo_de_Xadrez.Xadrez;

namespace Jogo_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiroo tab = new Tabuleiroo(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

        }
    }
}
using System;
using Jogo_de_Xadrez.Tabuleiro;

namespace Jogo_de_Xadrez.Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiroo tab, Cor cor) :base (tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

    }
}

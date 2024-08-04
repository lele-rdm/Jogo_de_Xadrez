using System;
using Jogo_de_Xadrez.Tabuleiro;

namespace Jogo_de_Xadrez.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiroo tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

    }
}

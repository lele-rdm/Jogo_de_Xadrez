using System;

namespace Jogo_de_Xadrez.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }

        public Cor Cor { get; protected set; }

        public int QteMovimentos { get; protected set; }

        public Tabuleiroo Tab { get; protected set; }

        public Peca(Tabuleiroo tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }


    }
}

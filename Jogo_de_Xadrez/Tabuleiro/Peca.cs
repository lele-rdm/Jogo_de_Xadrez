using System;

namespace Jogo_de_Xadrez.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }

        public Cor Cor { get; protected set; }

        public int QteMovimentos { get; protected set; }

        public Tabuleiroo Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiroo tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }


    }
}

using System;
using Jogo_de_Xadrez.Tabuleiro;

namespace Jogo_de_Xadrez.Tabuleiro
{
    class Tabuleiroo
    {
        public int Linhas { get; set; }

        public int Colunas { get; set; }

        private Peca[,] Pecas;

        public Tabuleiroo(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
    }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xadrez.Tabuleiro
{
    public class Tabuleiro
    {
        public int linhaTab { get; set; }
        public int colunaTab { get; set; }
        private Peca[,] pecas { get; set; }

        public Tabuleiro(int linhaTab, int colunaTab)
        {
            this.linhaTab = linhaTab;
            this.colunaTab = colunaTab;
            pecas = new Peca[linhaTab, colunaTab];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void InserirPeca(Peca pec, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = pec;
            pec.posicao = pos;
        }
    }
}
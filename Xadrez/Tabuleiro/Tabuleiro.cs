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
        private Peca[,] pecasTab { get; set; }

        public Tabuleiro(int linhaTab, int colunaTab)
        {
            this.linhaTab = linhaTab;
            this.colunaTab = colunaTab;
            pecasTab = new Peca[linhaTab, colunaTab];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecasTab[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecasTab[pos.linha, pos.coluna];
        }

        public void InserirPeca(Peca pec, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Ja existe uma peça nessa posição");
            }
            else
            {
                pecasTab[pos.linha, pos.coluna] = pec;
                pec.posicao = pos;
            }
        }

        public bool PosicaoValida(Posicao pos)
        {

            if (pos.linha < 0 || pos.linha >= linhaTab || pos.coluna < 0 || pos.coluna >= colunaTab)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Invalida!!!!");
            }
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return pecasTab[pos.linha, pos.coluna] != null;
        }
    }
}
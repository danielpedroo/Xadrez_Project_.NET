using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;

namespace Xadrez.Xadrez
{
    public class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }

    }
}
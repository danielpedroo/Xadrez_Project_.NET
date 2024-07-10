using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xadrez.Xadrez;

namespace Xadrez.Tabuleiro
{
    public class PartidaXadrez
    {

        public Tabuleiro tab { get; private set; }
        private int Turno;
        private Cor JogandorAtual;
        public bool Termino { get; private set; }


        public PartidaXadrez()
        {
            tab = new Tabuleiro(8, 8);
            Turno = 1;
            Termino = false;
            JogandorAtual = Cor.Branca;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RemoverPeca(origem);
            p.IncrementarMovimentos();
            Peca PecaCapturada = tab.RemoverPeca(destino);
            tab.InserirPeca(p, destino);
        }

        private void ColocarPecas()
        {
            //Pecas Brancas
            tab.InserirPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            tab.InserirPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            tab.InserirPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            tab.InserirPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            tab.InserirPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            tab.InserirPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());

            //Pecas Pretas
            tab.InserirPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            tab.InserirPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            tab.InserirPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            tab.InserirPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            tab.InserirPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
            tab.InserirPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
        }
    }
}
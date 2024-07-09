using System;
using Xadrez.Tabuleiro;
using Xadrez.Xadrez;


internal class Program
{

    private static void Main(string[] args)
    {
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.InserirPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));
            tab.InserirPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.InserirPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);
        }
    }
}
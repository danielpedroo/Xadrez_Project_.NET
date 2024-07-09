using System;
using Xadrez.Tabuleiro;
using Xadrez.Xadrez;


internal class Program
{

    private static void Main(string[] args)
    {
        {
            try
            {

                PosicaoXadrez posXd = new PosicaoXadrez('c', 7);
                Console.WriteLine(posXd.ToPosicao());

            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
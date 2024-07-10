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

                PartidaXadrez partidaXadrez= new PartidaXadrez();

                while(!partidaXadrez.Termino){

                Console.Clear();
                Tela.ImprimirTabuleiro(partidaXadrez.tab);
                
                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                
                partidaXadrez.ExecutarMovimento(origem, destino);

                }



            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
using gamehub.entities.Enums;
using jogoDeXadrez.Entities.Enums;
using System.Drawing;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Tabuleiro
    {
        public static Pecas[,] tabuleiroX { get; set; }
        public static int linhaInicial;
        public static int linhaFinal;
        public static int colunaInicial;
        public static int colunaFinal;
        public static string[] LetrasColunas { get; set; }
        public static string[] NumerosLinhas { get; set; }

        public Tabuleiro()
        {
            NumerosLinhas = new string[8] {"1","2","3","4","5","6","7","8"};
            LetrasColunas = new string[8] {"a","b","c","d","e","f","g","h"};

            tabuleiroX = new Pecas[8,8];
            

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    tabuleiroX[i, j] = new Pecas(i, j);
                }
            }

            //coloca peões
            for (int i = 0; i < 8; i++)
            {
                tabuleiroX[1, i] = new Peao(1, i, Cor.White);
                tabuleiroX[6, i] = new Peao(6, i, Cor.Black);
            }

            //Cavalos brancos
            tabuleiroX[0, 1] = new Cavalo(0, 1, Cor.White);
            tabuleiroX[0, 6] = new Cavalo(0, 6, Cor.White);

            // Cavalos pretos
            tabuleiroX[7, 1] = new Cavalo(7, 1, Cor.Black);
            tabuleiroX[7, 6] = new Cavalo(7, 6, Cor.Black);

            //Torres pretas
            tabuleiroX[7, 0] = new Torre(7, 0, Cor.Black);
            tabuleiroX[7, 7] = new Torre(7, 7, Cor.Black);


            //Torres brancas
            tabuleiroX[0, 0] = new Torre(0, 0, Cor.White);
            tabuleiroX[0, 7] = new Torre(0, 7, Cor.White);

            //Bispos brancos
            tabuleiroX[0, 2] = new Bispo(0, 2, Cor.White);
            tabuleiroX[0, 5] = new Bispo(0, 5, Cor.White);

            //Bispos pretos
            tabuleiroX[7, 2] = new Bispo(7, 2, Cor.Black);
            tabuleiroX[7, 5] = new Bispo(7, 5, Cor.Black);

            // Rainha branca
            tabuleiroX[0, 3] = new Rainha(0, 3, Cor.White);

            //Rainha preta
            tabuleiroX[7, 3] = new Rainha(7, 3, Cor.Black);

            //Rei branco
            tabuleiroX[0, 4] = new Rei(0, 4, Cor.White);

            //Rei preto
            tabuleiroX[7, 4] = new Rei(7, 4, Cor.Black);
            exibirTabuleiro();
        }

        public void exibirTabuleiro()
        {
            Console.Clear();
            Console.Write("\n  ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($" {LetrasColunas[i]} ");
            }
                for (int i = 0; i < 8; i++)
                {
                    Console.Write($"\n {NumerosLinhas[i]} ");
                    for(int j = 0; j < 8; j++)
                 {                
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                if (tabuleiroX[i, j].Cor == Cor.White)
                                    Console.ForegroundColor = ConsoleColor.White;
                                else
                                    Console.ForegroundColor = ConsoleColor.Black;
                                if (tabuleiroX[i, j].LetrasPecas == LetrasPecas.Vazio)
                                    Console.Write("   ");
                                else
                                    Console.Write($" {tabuleiroX[i, j]} ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                if (tabuleiroX[i, j].Cor == Cor.White)
                                    Console.ForegroundColor = ConsoleColor.White;
                                else
                                    Console.ForegroundColor = ConsoleColor.Black;
                                if (tabuleiroX[i, j].LetrasPecas == LetrasPecas.Vazio)
                                    Console.Write("   ");
                                else
                                    Console.Write($" {tabuleiroX[i, j]} ");
                                Console.ResetColor();
                            }

                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                if (tabuleiroX[i, j].Cor == Cor.White)
                                    Console.ForegroundColor = ConsoleColor.White;
                                else
                                    Console.ForegroundColor = ConsoleColor.Black;
                                if (tabuleiroX[i, j].LetrasPecas == LetrasPecas.Vazio)
                                    Console.Write("   ");
                                else
                                    Console.Write($" {tabuleiroX[i, j]} ");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                if (tabuleiroX[i, j].Cor == Cor.White)
                                    Console.ForegroundColor = ConsoleColor.White;
                                else
                                    Console.ForegroundColor = ConsoleColor.Black;
                                if (tabuleiroX[i, j].LetrasPecas == LetrasPecas.Vazio)
                                    Console.Write("   ");
                                else
                                    Console.Write($" {tabuleiroX[i, j]} ");
                                Console.ResetColor();
                            }
                        }
                    }
                }
        }

    }
}

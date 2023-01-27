using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamehub.entities.JogoDaVelha
{
    public class TabuleiroVelha
    {
        string[,] matrizTabuleiro = new string[3, 3];

        public void fazerTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    matrizTabuleiro[i, j] = "0";
                }
            }          
        }

        public void mostrarTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write($"[{matrizTabuleiro[i,j]}]");
                }
                Console.WriteLine("");
            }
        }
    }
 }


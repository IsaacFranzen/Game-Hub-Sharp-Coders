using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamehub.entities.JogoDaVelha
{
    public class JogoDaVelha : Jogador
    {
        public bool fimDePartida;
        public string[] posicoesNaMatriz;
        public string vazia = " ";
        public string vezJogador;


        string[,] matrizTabuleiro = new string[3, 3];
        //passar o jogador de parametro pras funçoes
        Jogador jogador = new Jogador();

        public JogoDaVelha()
        {
            fimDePartida = false;
            posicoesNaMatriz = new[] { "1","2", "3", "4", "5", "6", "7", "8", "9" };
            vezJogador = jogador.jogadorLogado;

        }



        public void ComecarPartida()
        {
            Jogador jogador = new Jogador();
            Console.WriteLine("Digite o nome do jogador adversário: ");
            jogador.oponente = Console.ReadLine();
            while (!fimDePartida)
            {

            }
        }


        public void FazerTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if(i == 0)
                    {
                        matrizTabuleiro[i, j] = $"{j + 1}";
                    }
                    if(i == 1)
                    {
                        matrizTabuleiro[i, j] = $"{j + 4}";
                    }
                    if(i == 2)
                    {
                        matrizTabuleiro[i, j] = $"{j + 7}";
                    }
                }
            }
        }

        public void MostrarTabuleiro()
        {
            FazerTabuleiro();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write($"| {matrizTabuleiro[i, j]} |");
                }
                Console.WriteLine("");
            }
        }

        public void mudarVezJogador()
        {
            vezJogador = vezJogador == jogador.jogadorLogado ? jogador.oponente : jogador.jogadorLogado;
        }
    }
}


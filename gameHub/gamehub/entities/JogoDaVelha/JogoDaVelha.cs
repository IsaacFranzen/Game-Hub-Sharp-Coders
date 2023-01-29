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
        public int qtdJogadas;


        string[,] matrizTabuleiro = new string[3, 3];
        //passar o jogador de parametro pras funçoes
        

        public JogoDaVelha()
        {
            
            fimDePartida = false;
            posicoesNaMatriz = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            vezJogador = "X";
            qtdJogadas = 0;
            

        }



        public void ComecarPartida()
        { 
            Console.WriteLine("Digite o nome do jogador adversário: ");
            while (!fimDePartida)
            {
                MostrarTabuleiro();
                EscolherJogada();
                MostrarTabuleiro();
                ValidaFimDeJogo(); 
                mudarVezJogador();
            }
        }

        public string FazerTabuleiro()
        {
            //Não consegui fazer do jeito anterior e fiz na mão mesmo
            return $"__{posicoesNaMatriz[0]}__|__{posicoesNaMatriz[1]}__|__{posicoesNaMatriz[2]}__\n" +
                    $"__{posicoesNaMatriz[3]}__|__{posicoesNaMatriz[4]}__|__{posicoesNaMatriz[5]}__\n" +
                    $"  {posicoesNaMatriz[6]}  |  {posicoesNaMatriz[7]}  |  {posicoesNaMatriz[8]}  \n\n";
        }

        public void MostrarTabuleiro()
        {
            Console.Clear();
            Console.WriteLine(FazerTabuleiro());
        }

        public void EscolherJogada()
        {
            
            if(vezJogador == "X")
            {
                Console.WriteLine($"Vez do jogador X");
            }
            else
            {
                Console.WriteLine($"Vez do jogador O");
            }
            Console.Write("Digite a posicao escolhida: ");
            bool validaEntrada = int.TryParse(Console.ReadLine(), out int posicaoDigitada);

            while (!validaEntrada || !ValidarJogada(posicaoDigitada))
            {
                Console.WriteLine("Posição inválida");
                validaEntrada = int.TryParse(Console.ReadLine(), out posicaoDigitada);
            }

            ColocarNaPosicaoDigitada(posicaoDigitada);
        }

        public void ColocarNaPosicaoDigitada(int posicaoEscolhida)
        {
            int index = posicaoEscolhida - 1;
            posicoesNaMatriz[index] = vezJogador;
            qtdJogadas++;
        }

        public bool ValidarJogada(int posicaoEscolhida)
        {
            int index = posicaoEscolhida - 1;

            return posicoesNaMatriz[index] != "O" && posicoesNaMatriz[index] != "X";



        }

        public void mudarVezJogador()
        {
            vezJogador = vezJogador == "X" ? "O" : "X";
        }

        public bool VenceuHorizontal()
        {
            bool linha1 = posicoesNaMatriz[0] == posicoesNaMatriz[1] && posicoesNaMatriz[0] == posicoesNaMatriz[2];
            bool linha2 = posicoesNaMatriz[3] == posicoesNaMatriz[4] && posicoesNaMatriz[3] == posicoesNaMatriz[5];
            bool linha3 = posicoesNaMatriz[6] == posicoesNaMatriz[7] && posicoesNaMatriz[6] == posicoesNaMatriz[8];

            return linha1 || linha2 || linha3;
        }

        public bool VenceuVertical()
        {
            bool linha1 = posicoesNaMatriz[0] == posicoesNaMatriz[3] && posicoesNaMatriz[0] == posicoesNaMatriz[6];
            bool linha2 = posicoesNaMatriz[1] == posicoesNaMatriz[4] && posicoesNaMatriz[1] == posicoesNaMatriz[7];
            bool linha3 = posicoesNaMatriz[2] == posicoesNaMatriz[5] && posicoesNaMatriz[2] == posicoesNaMatriz[8];

            return linha1 || linha2 || linha3;
        }

        public bool VenceuDiagonais()
        {
            bool linha1 = posicoesNaMatriz[2] == posicoesNaMatriz[4] && posicoesNaMatriz[2] == posicoesNaMatriz[6];
            bool linha2 = posicoesNaMatriz[0] == posicoesNaMatriz[4] && posicoesNaMatriz[0] == posicoesNaMatriz[8];


            return linha1 || linha2;
        }

        private void ValidaFimDeJogo()
        {
            if (qtdJogadas < 5)
                return;

            if (VenceuHorizontal() || VenceuVertical() || VenceuDiagonais())
            {
                fimDePartida = true;
                Console.WriteLine($"Fim de jogo!!! Vitória de {vezJogador}");
                return;
            }

            if (qtdJogadas == 9)
            {
                fimDePartida = true;
                Console.WriteLine("Fim de jogo!!! EMPATE");
            }
        }
    }
}


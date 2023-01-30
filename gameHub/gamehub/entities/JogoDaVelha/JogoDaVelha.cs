using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        public string jogador1 { get; set; }
        public string jogador2 { get; set; }


        public JogoDaVelha()
        {
            fimDePartida = false;
            posicoesNaMatriz = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            vezJogador = "X";
            qtdJogadas = 0;         
        }

        public void ComecarPartida()
        {
            GetJogadores();
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

            return
                $"__{posicoesNaMatriz[0]}__|__{posicoesNaMatriz[1]}__|__{posicoesNaMatriz[2]}__\n" +
                $"__{posicoesNaMatriz[3]}__|__{posicoesNaMatriz[4]}__|__{posicoesNaMatriz[5]}__\n" +
                $"  {posicoesNaMatriz[6]}  |  {posicoesNaMatriz[7]}  |  {posicoesNaMatriz[8]}  \n\n ";
              
        }

        public void MostrarTabuleiro()
        {
            Console.Clear();
            Console.WriteLine(FazerTabuleiro());
        }

        public void GetJogadores()
        {
            Console.Write("Digite o nome do primeiro jogador: ");
            string nomeJogador1 = Console.ReadLine();
            Console.Write("Digite o nome do segundo jogador: ");
            string nomeJogador2 = Console.ReadLine();

            jogador1 = nomeJogador1;
            jogador2 = nomeJogador2;

        }

        public void EscolherJogada()
        {
            
            if (vezJogador == "X")
            {
                Console.WriteLine($"Vez do jogador X {jogador1}:");
            }
            else
            {
                Console.WriteLine($"Vez do jogador O {jogador2}:");
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


        public void AumentaPontuacaoX(List<Jogador> jogadores)
        {
            
           string jsonJogadores = File.ReadAllText(@"C:\Users\isaac\OneDrive\Área de Trabalho\GameHub\Game-Hub-Sharp-Coders\gameHub\gamehub\entities\jogadores.json");
            
           List<Jogador> todosOsJogadores = JsonSerializer.Deserialize<List<Jogador>>(jsonJogadores);
           Jogador teste = todosOsJogadores.FirstOrDefault(e => e.Nome == jogador1);
            if(teste != null) {
                teste.Pontuacao += 10;
            }
            string jsonAtt = JsonSerializer.Serialize(todosOsJogadores);
            File.WriteAllText(@"C:\Users\isaac\OneDrive\Área de Trabalho\GameHub\Game-Hub-Sharp-Coders\gameHub\gamehub\entities\jogadores.json", jsonAtt);
        }

        public void AumentaPontuacaoO(List<Jogador> jogadores)
        {

            string jsonJogadores = File.ReadAllText(@"C:\Users\isaac\OneDrive\Área de Trabalho\GameHub\Game-Hub-Sharp-Coders\gameHub\gamehub\entities\jogadores.json");

            List<Jogador> todosOsJogadores = JsonSerializer.Deserialize<List<Jogador>>(jsonJogadores);
            Jogador teste = todosOsJogadores.FirstOrDefault(e => e.Nome == jogador2);
            if (teste != null)
            {
                teste.Pontuacao += 10;
            }
            string jsonAtt = JsonSerializer.Serialize(todosOsJogadores);
            File.WriteAllText(@"C:\Users\isaac\OneDrive\Área de Trabalho\GameHub\Game-Hub-Sharp-Coders\gameHub\gamehub\entities\jogadores.json", jsonAtt);
        }

        private void ValidaFimDeJogo()
        {
            if (qtdJogadas < 5)
                return;

            if (VenceuHorizontal() || VenceuVertical() || VenceuDiagonais())
            {
                fimDePartida = true;
                Console.WriteLine($"Fim de jogo!!! Vitória de {vezJogador}");
                switch (vezJogador)
                {
                    case "X":
                        AumentaPontuacaoX(jogadores);
                        Console.WriteLine($"Pontuação do jogador {jogador1} subiu!");
                        break;
                    case "O":
                        AumentaPontuacaoO(jogadores);
                        Console.WriteLine($"Pontuação do jogador {jogador2} subiu!");
                        break;
                }
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


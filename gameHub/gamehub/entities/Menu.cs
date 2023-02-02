using gamehub.entities.BatalhaNaval;
using gamehub.entities.JogoDaVelha;

using jogoDeXadrez.Entities.Xadrez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gamehub.entities
{
    public class Menu
    {
        public int Option { get; set; }
        
        public Menu()
        {
            exibirMenu();           
        }
        
        public void exibirMenu()
        {            
            Jogador jogador = new Jogador();
            JogoDaVelha.JogoDaVelha incio = new JogoDaVelha.JogoDaVelha();
                 
            jogador.LerJogadoresJson(jogador.jogadores);
            bool loopMenu = true;

            while (loopMenu)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("BEM-VINDO AO HUB DE GAMES!\n" +
                              "##########################\n" +
                              "# 1 - Registrar jogador. #\n" +
                              "# 2 - Fazer login.       #\n" +
                              "# 3 - Ranking.           #\n" +
                              "# 4 - Lista de jogadores.#\n" +
                              "# 5 - Logout.            #\n" +
                              "# 6 - Sair do hub.       #\n" +
                              "##########################");
                Console.ResetColor();
                Console.WriteLine("");
                if (jogador.Logado == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("OBS** Para exibir os jogos\ndisponiveis faça o login.");
                    Console.ResetColor();
                }
                if (jogador.Logado == true)
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;           
                    Console.Write(
                              "    Escolha o jogo!      \n"+
                             "##########################\n" +
                             "# 7 - Jogo da velha       #\n" +
                             "# 8 - Batalha naval       #\n" +
                             "# 9 - Xadrez              #\n" +
                             "##########################");
                }
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Digite a opção escolhida: ");

                Option = int.Parse(Console.ReadLine());
                
                switch (Option)
                {
                    case 1:
                        jogador.RegistrarJogador(jogador.jogadores);                      
                        break;
                    case 2:
                        if(jogador.Logado != true)
                        {
                            jogador.fazerLogin();
                        }
                        else
                        {
                            Console.WriteLine($"Você já está logado, faça o logout para logar em outra conta");
                        }                       
                        break;
                    case 3:
                        jogador.Ranking(jogador.jogadores);
                        break;                 
                    case 4:
                        jogador.ListarJogadores(jogador.jogadores);

                        break;
                    case 5:
                        jogador.Logout();
                        break;
                    case 6:
                        Console.WriteLine("Encerrando menu.");
                        Environment.Exit(0);
                        break;
                    case 7:
                        new JogoDaVelha.JogoDaVelha().ComecarPartida();
                        break;
                    case 8:
                        TabuleiroBn tabuleiro = new TabuleiroBn();
                        break;
                    case 9:
                        Tabuleiro tabuleiroXadrez = new Tabuleiro();
                       tabuleiroXadrez.ComecarPartida();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }
    }
}

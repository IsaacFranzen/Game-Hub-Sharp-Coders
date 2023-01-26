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
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("BEM-VINDO AO HUB DE GAMES!\n" +
                              "#########################\n" +
                              "# 1 - Registrar jogador. #\n" +
                              "# 2 - Fazer login.       #\n" +
                              "# 3 - Salvar jogadores.  #\n" +
                              "# 4 - Lista de jogadores.#\n" +
                              "# 5 - Logout.            #\n" +
                              "# 6 - Sair do hub        #\n" +
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
                    Console.Write("Escolha o jogo para jogar");
                    Console.Write("7 - Jogar jogo da velha");
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Digite a opção escolhida: ");

                Option = int.Parse(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        jogador.registrarJogador();                      
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
                        jogador.salvarJogadores();
                        break;                 
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Encerrando menu.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }
    }
}

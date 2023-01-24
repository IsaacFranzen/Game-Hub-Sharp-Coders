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
            while (true)
            {
                Console.WriteLine("1 - Registrar jogador");
                Console.WriteLine("2 - Fazer login");
                Console.WriteLine("3 - Mostrar jogadores");
                Console.WriteLine("4 - Salvar jogadores");
                Console.WriteLine("5 - Logout");
                Console.WriteLine("6 - Sair");

                Console.WriteLine("Digite a opção escolhida");

                Option = int.Parse(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        Jogador jogador = new Jogador();
                        jogador.registrarJogador();
                        break;
                    case 2:

                        break;
                    case 3:

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

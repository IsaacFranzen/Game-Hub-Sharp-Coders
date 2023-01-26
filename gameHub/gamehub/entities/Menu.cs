﻿using System;
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
                
                Console.WriteLine("1 - Registrar jogador");
                Console.WriteLine("2 - Fazer login");
                Console.WriteLine("3 - Salvar jogadores");
                Console.WriteLine("4 - Logout");
                Console.WriteLine("5 - Sair");

                Console.WriteLine("Digite a opção escolhida");

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

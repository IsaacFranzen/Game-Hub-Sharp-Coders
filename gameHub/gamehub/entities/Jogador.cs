using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace gamehub.entities
{
    public class Jogador
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public int Pontuacao { get; set; }
        public bool Logado { get; set; }

        public List<Jogador> jogadores = new List<Jogador>();
        

        public Jogador() 
        {
        }

        public void registrarJogador()
        {          
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();


                Console.Write("Digite a sua senha: ");
                string senha = Console.ReadLine();

                Jogador jogador = new Jogador
                {
                    Nome = nome,
                    Pontuacao = 0,
                    Senha = senha,
                    Logado = false
                };

                jogadores.Add(jogador);   
        }

        public void fazerLogin()
        {
            if (jogadores.Count != 0 )
            {
            Console.Write("Digite seu nome:");
            string nomeDigitado = Console.ReadLine();

            Console.Write("Digite sua senha:");
            string senhaDigitada = Console.ReadLine();

            foreach (Jogador jogador in jogadores)
            {
                if (jogador.Nome == nomeDigitado && jogador.Senha == senhaDigitada)
                {
                    Console.WriteLine("Logado com sucesso!");
                    Logado = true;
                    break;
                }
            }
            if (!Logado)
            {
                Console.WriteLine("Login ou senha inválidos, tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Registre ao menos um usuário para fazer o login.");
                Console.WriteLine("");
            }
        }

        public void salvarJogadores()
        {
            string roothPath = @"C:\Users\isaac\OneDrive\Área de Trabalho\gameHub\gameHub\gamehub\data\";
            string filePath = roothPath + "jogadores.json";
            Console.WriteLine(filePath);

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            for(int i = 0; i < jogadores.Count; i++)
            {
                string json = JsonSerializer.Serialize(jogadores[i]);
                File.AppendAllText(filePath, json);
            }
           
            
        }
    }
}

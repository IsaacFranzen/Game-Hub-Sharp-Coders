using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Xml.Linq;

namespace gamehub.entities
{
    public class Jogador
    {
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public int Pontuacao { get; set; }
        public bool Logado { get; set; }
        
       
        public List<Jogador> jogadores = new List<Jogador>();

        
        public Jogador() { }


        public Jogador(string? nome, string? senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public void RegistrarJogador(List<Jogador>jogadores)
        {            
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();


                Console.Write("Digite a sua senha: ");
                string senha = Console.ReadLine();

                Jogador jogador = new Jogador(nome,senha)
                {
                    Nome = nome,
                    Senha = senha,
                    
                };

                jogadores.Add(jogador);
       
            string roothPath = @"C:\Users\isaac\OneDrive\Área de Trabalho\GameHub\Game-Hub-Sharp-Coders\gameHub\gamehub\entities\";
            
            string filePath = roothPath + "jogadores.json";
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            string jsonString = JsonSerializer.Serialize(jogadores);
            File.WriteAllText(filePath, jsonString);           
        }

        public void LerJogadoresJson(List<Jogador> jogadores)
        {
            //string jsonJogadores = @"C:\Users\isaac\OneDrive\Área de Trabalho\gameHub\gameHub\gamehub\"; caminho pc mesa
            string jsonJogadores = File.ReadAllText(@"C:\Users\isaac\OneDrive\Área de Trabalho\GameHub\Game-Hub-Sharp-Coders\gameHub\gamehub\entities\jogadores.json");
            if (!String.IsNullOrEmpty(jsonJogadores))
            {
                List<Jogador> todosOsJogadores = JsonSerializer.Deserialize<List<Jogador>>(jsonJogadores);
                todosOsJogadores.ForEach(jogador => jogadores.Add(jogador));

            }
            
        }
        
        public void ListarJogadores(List<Jogador> jogadores)
        {
            jogadores.ForEach(jogador => { Console.WriteLine(jogador.Nome); });
        }

        public void Ranking(List<Jogador> jogadores)
        {
            jogadores.ForEach(jogador => { Console.WriteLine($"Jogador: {jogador.Nome} -> Pontuação: {jogador.Pontuacao}"); });
        }

        public void fazerLogin()
        {
           
            if (jogadores.Count != 0 )
            {
            Console.Write("Digite seu nome: ");
            string nomeDigitado = Console.ReadLine();
                
                Console.Write("Digite sua senha: ");
            string senhaDigitada = Console.ReadLine();
              
            foreach (Jogador jogador in jogadores)
            {
                if (jogador.Nome == nomeDigitado && jogador.Senha == senhaDigitada)
                {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Logado com sucesso!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        
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
        public void Logout()
        {
            Logado= false;
            Console.WriteLine("Logout feito com sucesso");
        }
    }
}

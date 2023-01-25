﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamehub.entities
{
    public class Jogador
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Pontuacao { get; set; }
        public bool Logado { get; set; }

        static List<Jogador> jogadores = new List<Jogador>();

        public void registrarJogador()
        {
            while (true)
            {
                Console.Write("Digite o seu nome (ou digite sair): ");
                string nome = Console.ReadLine();
                if (nome.ToLower() == "sair")
                    break;
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
        }

        public void fazerLogin()
        {
            Console.Write("Digite seu nome:");
            string nomeDigitado = Console.ReadLine();

            Console.Write("Digite sua senha:");
            string senhaDigitada = Console.ReadLine();
            foreach(Jogador jogador in jogadores)
            {
                if(jogador.Nome == nomeDigitado && jogador.Senha == senhaDigitada)
                {
                    Console.WriteLine("Logado com sucesso!");
                    Logado = true;                    
                    break;
                }
            }
            if(!Logado)
            {
                Console.WriteLine("Login ou senha inválidos, tente novamente.");
            }
        }
    }
}

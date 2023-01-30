using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace gamehub.entities.BatalhaNaval
{
    public class TabuleiroBn
    {
        public Embarcacoes[,] tabuleiroN = new Embarcacoes[10, 10];
        
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public bool[,] posicoesEncontradas { get; set; }
        public int JogadaLinha { get; set; }
        public int jogadaColuna { get; set; }
        public int qtdJogadas { get; set; }
        //public List<char> posicoes = new List<char>();

        public TabuleiroBn()
        {
            posicoesEncontradas = new bool[10, 10];
            CriarTabuleiro();
            MostrarTabuleiro();
            GetJogada();
            MostrarTabuleiro();
            ValidaFimDeJogo();
        }

        public void preencherBool()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    posicoesEncontradas[i, j] = false;
                }
            }
        }

        public void CriarTabuleiro()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    tabuleiroN[i, j] = new Agua(i, j);
                }
            }
            ColocarSubmarinos(tabuleiroN, 5);
            ColocarPortaAvioes(tabuleiroN, 3);
        }


        public void MostrarTabuleiro()
        {

            Console.WriteLine("  0  1  2  3  4  5  6  7  8  9");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    
                     if (j == 0)

                        Console.Write($"{(Letras)i + 1}");
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write($"|{tabuleiroN[i, j].LetraDaPeca}|");
                        Console.ResetColor();
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public void GetJogada()
        {
            Console.Write("Digite a linha: ");
            int linha = int.Parse(Console.ReadLine());
            int linhaNaMatriz = linha;
            Console.Write("Digite o coluna: ");
            int coluna = int.Parse(Console.ReadLine());
            int colunaNaMatriz = coluna;
            posicoesEncontradas[linhaNaMatriz, colunaNaMatriz] = true;

            if (tabuleiroN[linhaNaMatriz, colunaNaMatriz].LetraDaPeca == 'S' || tabuleiroN[linhaNaMatriz, colunaNaMatriz].LetraDaPeca == 'P')
            {
                tabuleiroN[linhaNaMatriz, colunaNaMatriz].LetraDaPeca = 'X';
            }
            qtdJogadas++;
        }

        private void ValidaFimDeJogo()
        {
            if (qtdJogadas < 5)
                return;
        }

            public void ColocarSubmarinos(Embarcacoes[,] tabuleiroN, int qtdEmbarcacao)
        {
            Random random = new Random();
            int subsColocados = 0;

            while (subsColocados < qtdEmbarcacao)
            {
                int linha = random.Next(0, 10);
                int coluna = random.Next(0, 10);

                if (tabuleiroN[linha, coluna].LetraDaPeca == '~')
                {
                    tabuleiroN[linha, coluna] = new Submarino(linha,coluna);
                    subsColocados++;
                }
            }
        }

        public void ColocarPortaAvioes(Embarcacoes[,] tabuleiroN, int qtdEmbarcacao)
        {
            Random random = new Random();
            int portaColocados = 0;

            while (portaColocados < qtdEmbarcacao)
            {
                int linha = random.Next(0, 7);
                int coluna = random.Next(0, 7);


                if (tabuleiroN[linha, coluna].LetraDaPeca == '~')
                {
                    for (int i = 0; i < 3; i++)
                    {
                        tabuleiroN[linha, i + coluna] = new PortaAvioes(linha,coluna);
                    }
                    portaColocados++;
                }
            }
        }
    }
}

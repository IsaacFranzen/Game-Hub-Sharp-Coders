using gamehub.entities.Enums;
using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Pecas
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public int qtdDeMovimentos { get; set; }
        public Cor Cor;
        public LetrasPecas LetrasPecas;


        public Pecas()
        {

        }

        public Pecas(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            qtdDeMovimentos = 0;
            Cor = Cor.Null;
            LetrasPecas = LetrasPecas.Vazio;
        }

        public override string ToString()
        {
            return LetrasPecas.ToString();
        }

        public virtual bool confereMovimento(int colunaFinal, int linhaFinal) 
        {
            return false;
        }

    }
}

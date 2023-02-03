using gamehub.entities.Enums;
using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Cavalo : Pecas
    {
        public Cavalo(int linha, int coluna, Cor cor) : base(linha, coluna)
        {
            Cor = cor;
            LetrasPecas = LetrasPecas.C;
        }

        public override bool confereMovimento(int linhaFinal, int colunaFinal)
        {
            if (linhaFinal == Linha + 2 || linhaFinal == Linha - 2)
            {
                if (colunaFinal == Coluna + 1 || colunaFinal == Coluna - 1)
                {
                    return true;
                }
                else
                    return false;
            }
            else if (linhaFinal == Linha + 1 || linhaFinal == Linha - 1)
            {
                if (colunaFinal == Coluna+ 2 || colunaFinal == Coluna - 2)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}

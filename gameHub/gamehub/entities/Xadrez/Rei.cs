using gamehub.entities.Enums;
using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Rei:Pecas
    {
        public Rei(int linha, int coluna, Cor cor) : base(linha, coluna)
        {
            Cor = cor;
            LetrasPecas = LetrasPecas.R;
        }

        public override bool confereMovimento(int colunaFinal, int linhaFinal)
        {
            if (Math.Abs(Linha - linhaFinal) == 1 || Math.Abs(Linha - linhaFinal) == 0)
            {
                if (Math.Abs(Coluna - colunaFinal) == 1 || Math.Abs(Coluna - colunaFinal) == 0)
                {
                    if (Tabuleiro.tabuleiroX[linhaFinal, colunaFinal].LetrasPecas == LetrasPecas.Vazio)
                    {
                        return true;
                    }
                    else if (Tabuleiro.tabuleiroX[linhaFinal, colunaFinal].Cor != Cor)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

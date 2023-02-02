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
    public class Peao : Pecas
    {
        public Peao(int linha, int coluna, Cor cor) : base(linha, coluna)
        {
            Cor = cor;
            LetrasPecas = LetrasPecas.P;
        }

        public override bool confereMovimento(int colunaFinal, int linhaFinal, Tabuleiro tab)
        {
            return false;
        }
    }
}

using gamehub.entities.Enums;
using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Rainha : Pecas
    {
        public Rainha(int linha, int coluna, Cor cor) : base(linha, coluna)
        {
            Cor = cor;
            LetrasPecas = LetrasPecas.D;
        }
    }
}

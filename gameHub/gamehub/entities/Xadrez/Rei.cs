﻿using gamehub.entities.Enums;
using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
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
    }
}
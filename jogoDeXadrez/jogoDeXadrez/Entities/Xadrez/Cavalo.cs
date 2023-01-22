﻿using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Cavalo : Pecas
    {
        public Cavalo(int linha, int coluna, Cor cor) : base(linha, coluna, cor)
        {
            LetraDaPeca = 'C';
        }
    }
}

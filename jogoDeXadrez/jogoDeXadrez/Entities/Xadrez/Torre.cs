using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Torre : Pecas
    {
        public Torre(int linha, int coluna, Cor cor) : base(linha, coluna, cor)
        {
            LetraDaPeca = 'T';
        }
    }
}

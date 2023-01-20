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
        public int Linha;
        public int Coluna;
        public char LetraDaPeca;
        public Cor Cores;

        public Pecas()
        {

        }

        public Pecas(int linha, int coluna, Cor cor)
        {
            Linha = linha;
            Coluna = coluna;
            Cores = cor;
        }
    }
}

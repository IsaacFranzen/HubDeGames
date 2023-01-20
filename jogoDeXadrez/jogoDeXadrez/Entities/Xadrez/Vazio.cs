using jogoDeXadrez.Entities;
using jogoDeXadrez.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Vazio : Pecas
    {
        public Vazio(int linha, int coluna, Cor cores) { }
        public Vazio(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
            Cores = Cor.Null;
            LetraDaPeca = ' ';
        }
    }
}

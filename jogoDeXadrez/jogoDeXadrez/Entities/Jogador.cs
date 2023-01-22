using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int Pontuacao { get; set; }


        public Jogador(string nome,
            int pontucao) 
        {
            Nome = nome;
            Pontuacao = 0;
        }

        public void pegarNome()
        {
            Nome = Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities
{
    public class RegistroDeUsuario : Jogador
    {
        List<Jogador> jogadores = new List<Jogador>();

        public RegistroDeUsuario(string nome, int pontuacao) : base(nome, pontuacao) 
        {
            Jogador novoJogador = new Jogador(nome, pontuacao);
            jogadores.Add(novoJogador);
        }
        
    }
}

using jogoDeXadrez.Entities.Xadrez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDeXadrez.Entities
{
    public class Menu
    {
        public int Option { get; set; }
        public Menu() 
        {
            showMenu();
        }

        public void showMenu()
        {
            while(true)
            {
                Console.WriteLine("1. Registrar jogador");
                Console.WriteLine("2. Jogar xadrez");
                Console.WriteLine("3. Mostrar jogadores");
                Console.WriteLine("4. Sair");

                Console.WriteLine("Digite a opção escolhida");

                Option = int.Parse(Console.ReadLine());

                switch(Option)
                {
                    case 1:
                        Jogador jogador = new Jogador();
                        jogador.registrarJogador();
                        break;
                    case 2:
                        Tabuleiro tabuleiro = new Tabuleiro();
                        break;
                    case 3:
                        MostrarJogador mostrar = new MostrarJogador();
                        break;
                    case 4:
                        Console.WriteLine("Encerrando menu.");
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }
    }
}

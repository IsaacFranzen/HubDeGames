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
                Console.WriteLine("3. Sair");

                Console.WriteLine("Digite a opção escolhida");

                Option = int.Parse(Console.ReadLine());

                switch(Option)
                {
                    case 1:
                        Console.WriteLine("Digite o seu nome:");
                        string nome = Console.ReadLine();
                        RegistroDeUsuario registrar = new RegistroDeUsuario( nome, 0);
                        Console.WriteLine("Usuário registrado com sucesso!");
                        break;
                    case 2:
                        Tabuleiro tabuleiro = new Tabuleiro();
                        break;
                    case 3:
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

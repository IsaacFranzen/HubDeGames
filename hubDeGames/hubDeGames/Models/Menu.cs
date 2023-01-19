using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hubDeGames.Models
{
    public class Menu
    {
        public List<string> Palyers { get; set; }
        public int options { get; set; }
        
        public Menu()
        {
            showMenu();
        }

        public void showMenu()
        {
            Console.WriteLine("1 - Registrar player");
            Console.WriteLine("2 - Ver ranking de players");
            Console.WriteLine("Digite sua opção:");
            getOption();
        }

        public void getOption()
        {
            options = int.Parse(Console.ReadLine());
        }
    }
}

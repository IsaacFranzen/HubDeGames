using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace jogoDeXadrez.Entities
{
    public class Jogador
    {
       
            public string Nome { get; set; }
            public int Pontuacao { get; set; }
        
        static List<Jogador> jogadores = new List<Jogador>();

        public void registrarJogador()
        {
            while (true)
            {
                Console.Write("Digite o seu nome (ou digite sair): ");
                string nome = Console.ReadLine();

                if (nome.ToLower() == "sair")
                    break;

                Jogador jogador = new Jogador
                {
                    Nome = nome,
                    Pontuacao = 0
                };

                jogadores.Add(jogador);
            }
        }

        public void mostrarJogadores()
        {
            Console.WriteLine("Jogadores registrados e a sua pontuação:");
            foreach (Jogador jogador in jogadores)
            {
                Console.WriteLine("Nome: " + jogador.Nome + ", Pontuação: " + jogador.Pontuacao);
            }
        }

        public void salvarJogadores()
        {
            string roothPath = @"C:\Users\isaac\OneDrive\Área de Trabalho\HubDeGames\jogoDeXadrez\jogoDeXadrez\";
            string filePath = roothPath + "jogadores.JSON";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            using (StreamWriter sw = File.AppendText(filePath)) 
            {
                
                    string json = JsonSerializer.Serialize(jogadores);
                    sw.WriteLine(json);
                
                
            }
        }
    }
}

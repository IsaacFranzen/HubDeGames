using jogoDeXadrez.Entities.Enums;

namespace jogoDeXadrez.Entities.Xadrez
{
    public class Tabuleiro
    {
        private Pecas[,] tabuleiro = new Pecas[8, 8];
        public int linhaInicial;
        public int linhaFinal;
        public int colunaInicial;
        public int colunaFinal;

        public Tabuleiro()
        {
            criarTabuleiro();
            mostrarTabuleiro();
            moverPeca();
            mostrarTabuleiro();
        }

        public void criarTabuleiro()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    tabuleiro[i, j] = new Vazio(i, j);
                }
            }
            colocarPecas();
        }


        public void mostrarTabuleiro()
        {

            Console.WriteLine("  1  2  3  4  5  6  7  8");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tabuleiro[i, j].Cores == Cor.Black)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (tabuleiro[i, j].Cores == Cor.White)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (tabuleiro[i, j].Cores == Cor.Null)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (j == 0)
                        // bug para resolver aqui, quando uso o Console.Foreground ele altera a exposição do tabuleiro
                        Console.Write($"{(Letras)i + 1}");
                    Console.Write($"[{tabuleiro[i, j].LetraDaPeca}]");

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void colocarPecas()
        {
            //Torres pretas
            tabuleiro[7, 0] = new Torre(7, 0, Cor.Black);
            tabuleiro[7, 7] = new Torre(7, 7, Cor.Black);

            //Torres brancas
            tabuleiro[0, 0] = new Torre(0, 0, Cor.White);
            tabuleiro[0, 7] = new Torre(0, 7, Cor.White);

            //Peoes pretos
            for (int i = 0; i < 8; i++)
            {
                tabuleiro[6, i] = new Peao(6, i, Cor.Black);
            }

            //Peoes brancos
            for (int i = 0; i < 8; i++)
            {
                tabuleiro[1, i] = new Peao(1, i, Cor.White);
            }

            //Cavalos brancos
             tabuleiro[0, 1] = new Cavalo(0, 1, Cor.White);
             tabuleiro[0, 6] = new Cavalo(0, 6, Cor.White);

            // Cavalos pretos
            tabuleiro[7,1] = new Cavalo(7, 1, Cor.Black);
            tabuleiro[7,6] = new Cavalo(7, 6, Cor.Black);

            //Bispos brancos
            tabuleiro[0,2] = new Bispo(0, 2, Cor.White);
            tabuleiro[0,5] = new Bispo(0,5, Cor.White);

            //Bispos pretos
            tabuleiro[7, 2] = new Bispo(7, 2, Cor.Black);
            tabuleiro[7, 5] = new Bispo(7, 5, Cor.Black);

            // Rainha branca
            tabuleiro[0,3] = new Rainha(0, 3, Cor.White);

            //Rainha preta
            tabuleiro[7, 3] = new Rainha(7, 3, Cor.Black);

            //Rei branco
            tabuleiro[0,4] = new Rei(0, 4, Cor.White);

            //Rei preto
            tabuleiro[7,4] = new Rei(7, 4, Cor.Black);

        }

        public void moverPeca()
        {
         
            
            Console.WriteLine("Digite a linha inicial:");
            linhaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o coluna inicial:");
            colunaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a linha final:");
            linhaFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a coluna final");
            colunaFinal = int.Parse(Console.ReadLine());

            tabuleiro[linhaFinal, colunaFinal] = tabuleiro[linhaInicial, colunaInicial];
            tabuleiro[linhaInicial, colunaInicial] = new Vazio(linhaInicial, colunaInicial);
           
           
        }
    }
}

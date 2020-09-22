using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        //método static é um método o qual não precisa estanciar um objeto para a cessar o método
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    Console.Write(tab.peca(i, j) + " ");
                }

                Console.WriteLine();
            }

        }
    }
}

using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8 ,8);

            tab.ColocaPeca(new Rei(Cor.preta, tab), new Posicao(0,2));
            tab.ColocaPeca(new Torre(Cor.preta, tab), new Posicao(0, 0));
            tab.ColocaPeca(new Torre(Cor.preta, tab), new Posicao(0, 7));

            Tela.ImprimirTabuleiro(tab);
        }
    }
}

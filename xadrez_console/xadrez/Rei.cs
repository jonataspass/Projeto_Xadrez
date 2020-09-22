using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        //o construtor desta classe passa a função para a super classe Peca
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}

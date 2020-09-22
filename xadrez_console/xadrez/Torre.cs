using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        //o construtor desta classe passa a função para a super classe Peca
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}

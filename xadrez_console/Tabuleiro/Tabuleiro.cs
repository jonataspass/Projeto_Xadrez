namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        //matriz de pecas
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.pecas = new Peca [linhas, colunas];
        }

        //retorna uma peça
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //posiciona peça no tabuleiro
        public void ColocaPeca(Peca p, Posicao pos)
        {
            //matriz de peças recebe uma peça "p" em uma posição pos.linha, pos.coluna
            pecas[pos.linha, pos.coluna] = p;
            //peça guarda a posição onde está
            p.posicao = pos;
        }
    }
}

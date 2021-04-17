

namespace Loja
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
       
        /*===========================================================================*/
        public Produto()
        {
            Quantidade = 0;
        }

        public Produto(string nome, double preco) : this() 
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this( nome, preco) 
        {
            Quantidade = quantidade;
        }
        
        /*===========================================================================*/
        public string Nome 
        {
            get { return _nome; }
            set 
            {
                if (value != null && value.Length > 1) 
                {
                    _nome = value;
                }
            }
        }

        /*===========================================================================*/
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $ "
                + Preco + ", "
                + Quantidade
                + " unidades, total: $ "
                + ValorTotalEmEstoque();
        }
    }
}

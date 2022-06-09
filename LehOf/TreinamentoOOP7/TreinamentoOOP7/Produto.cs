using System.Globalization;
namespace Course
{
    class Produto
    {
        // Atributos
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // Construtor padrão
        public Produto()
        {
        }

        // Construtor com inicialização no nome e no preço
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        // Criando uma propertie onde o parâmetro do Set agora é chamado de value
        // Transformando Get e Set em properties

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        // Construtor com inicialização completa
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        // Método para valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Método para adicionar produtos
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        // Método para remover produtos
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        // Sobre escrever com ToString
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

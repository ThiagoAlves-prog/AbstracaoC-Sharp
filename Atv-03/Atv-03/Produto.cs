namespace Atv_03
{
    public class Produto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(string codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
        public void qtndEstoque()
        {
            Console.WriteLine($"Em estoque: {Estoque} ");
        }
    }
}

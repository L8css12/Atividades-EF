namespace ExemploEF.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        public string Nome { get; set; }
        // Relacionando as entidades Produto e Catgoria (1 Categoria - N Produtos)
        // Cada categoria pode conter muitos produtos

        public IEnumerable<Produto>? Produtos { get; set; }

    }
}

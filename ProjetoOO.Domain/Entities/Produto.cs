
namespace ProjetoOO.Domain.Entities
{
    /// <summary>
    /// Trata-se de uma subclasse utilizada na classe Pessoa.
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Atributo específico
        /// </summary>
        public int ProdutoId { get; set; }
        /// <summary>
        /// Atributo específico
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Atributo específico
        /// </summary>
        public decimal Valor { get; set; }
        /// <summary>
        /// Atributo específico
        /// </summary>
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}

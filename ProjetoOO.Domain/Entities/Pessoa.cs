using System;

namespace ProjetoOO.Domain.Entities
{
    /// <summary>
    /// A superclasse Pessoa é a classe criada para ser herdada na classe Cliente
    /// </summary>
    public class Pessoa
    {
        public int PessoaId { get; set; }
        /// <summary>
        /// Atributo Genérico Encapsulado
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Atributo Genérico Encapsulado
        /// </summary>
        public string Sobrenome { get; set; }
        /// <summary>
        /// Atributo Genérico Encapsulado
        /// </summary>
        public DateTime DataAniversario { get; set; }

    }
}

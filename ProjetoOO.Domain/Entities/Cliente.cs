using System;
using System.Collections.Generic;

namespace ProjetoOO.Domain.Entities
{
    /// <summary>
    /// Classe Cliente refere a classe tema do trabalho de Orientação a Objeto.
    /// </summary>
    public class Cliente : Pessoa
    {
        /// <summary>
        /// Métodos get e set implementados nos atributos 
        /// </summary>
        public int ClienteId { get; set; }
        /// <summary>
        /// Métodos get e set implementados nos atributos 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Métodos get e set implementados nos atributos 
        /// </summary>
        public DateTime DataCadastro { get; set; }
        /// <summary>
        /// Métodos get e set implementados nos atributos 
        /// </summary>
        public bool Ativo { get; set; }
        /// <summary>
        /// Métodos get e set implementados nos atributos 
        /// </summary>
        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}

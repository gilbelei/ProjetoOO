using ProjetoOO.Domain.Entities;
using ProjetoOO.Domain.Interface.Repositories;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoOO.Infra.Data.Repositories
{
    /// <summary>
    /// Classe herda de forma poliformica
    /// </summary>
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}

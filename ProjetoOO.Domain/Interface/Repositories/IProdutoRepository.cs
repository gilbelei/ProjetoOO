using ProjetoOO.Domain.Entities;
using System.Collections.Generic;


namespace ProjetoOO.Domain.Interface.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}

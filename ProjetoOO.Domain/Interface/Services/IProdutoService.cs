using ProjetoOO.Domain.Entities;
using System.Collections.Generic;


namespace ProjetoOO.Domain.Interface.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}

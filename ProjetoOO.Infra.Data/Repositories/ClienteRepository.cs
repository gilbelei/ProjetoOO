using ProjetoOO.Domain.Entities;
using ProjetoOO.Domain.Interface.Repositories;

namespace ProjetoOO.Infra.Data.Repositories
{
    /// <summary>
    /// Classe herda de forma poliformica
    /// </summary>
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}

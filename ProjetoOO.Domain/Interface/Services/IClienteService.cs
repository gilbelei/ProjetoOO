using ProjetoOO.Domain.Entities;
using System.Collections.Generic;


namespace ProjetoOO.Domain.Interface.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}

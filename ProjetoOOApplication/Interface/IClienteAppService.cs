using ProjetoOO.Domain.Entities;
using System.Collections.Generic;


namespace ProjetoOOApplication.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}

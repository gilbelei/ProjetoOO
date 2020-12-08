using ProjetoOO.Domain.Entities;
using ProjetoOO.Domain.Interface.Repositories;
using ProjetoOO.Domain.Interface.Services;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoOO.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}

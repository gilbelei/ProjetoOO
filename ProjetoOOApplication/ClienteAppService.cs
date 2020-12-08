using ProjetoOO.Domain.Entities;
using ProjetoOO.Domain.Interface.Services;
using ProjetoOOApplication.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOOApplication
{
    /// <summary>
    /// Classe herda os métodos base da superclasse
    /// </summary>
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        /// <summary>
        /// Acesso aos métodos da aplicação via interface
        /// </summary>
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}

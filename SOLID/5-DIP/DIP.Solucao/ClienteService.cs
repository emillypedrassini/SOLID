using SOLID._5_DIP.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.DIP.Solucao
{
	public class ClienteService : IClienteService
	{
		private readonly IClienteRepository _clienteRepository;
		private readonly IEmailService _emailService;

		public ClienteService(IClienteRepository clienteRepository, IEmailService emailService)
		{
			_clienteRepository = clienteRepository;
			_emailService = emailService;
		}

		public string AdicionarCliente(Cliente cliente)
		{
			try
			{
				if (!cliente.IsValid())
					return "Dados inválidos";

				_clienteRepository.AdicionarCliente(cliente);

				_emailService.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns você está cadastrado");

				return "Cliente cadastrado com sucesso!";
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}

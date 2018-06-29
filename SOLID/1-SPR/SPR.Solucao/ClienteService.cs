using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_SPR.SPR.Solucao
{
	// é o serviço do cliente - ele que add o cliente
	// a classe de serviõ que faz tudo, pega o cliente, valida, insere no repositorio, e envia o email
	class ClienteService
	{
		public string AdicionarCliente(Cliente cliente)
		{
			try
			{
				if (!cliente.IsValid())
					return "Dados inválidos";
				
				ClienteRepository _repository = new ClienteRepository();
				_repository.AdicionarCliente(cliente);

				EmailService.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo", "Parabéns você está cadastrado");

				return "Cliente cadastrado com sucesso!";
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}

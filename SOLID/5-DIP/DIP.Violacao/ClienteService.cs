using System;

namespace SOLID._5_DIP.DIP.Violacao
{
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

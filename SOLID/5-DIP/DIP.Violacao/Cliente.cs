using System;

namespace SOLID._5_DIP.DIP.Violacao
{
	class Cliente
	{
		public int ClienteId { get; set; }

		public string Nome { get; set; }

		public string Email { get; set; }

		public string CPF { get; set; }

		public DateTime DataCadastro { get; set; }

		public bool IsValid()
		{
			return EmailService.IsValid(Email) && CPFService.IsValid(CPF);
		}
	}
}

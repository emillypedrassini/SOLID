using SOLID._5_DIP.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.DIP.Solucao
{
	public class Cliente
	{
		private readonly IEmailService _emailService;
		private readonly ICPFService _cpfService;

		public Cliente(IEmailService emailService, ICPFService cpfService)
		{
			_emailService = emailService;
			_cpfService = cpfService;
		}

		public int ClienteId { get; set; }

		public string Nome { get; set; }

		public string Email { get; set; }

		public string CPF { get; set; }

		public DateTime DataCadastro { get; set; }

		public bool IsValid()
		{
			return _emailService.IsValid(Email) && _cpfService.IsValid(CPF);
		}
	}
}

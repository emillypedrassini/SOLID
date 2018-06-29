using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_SPR.SPR.Solucao
{
	public class Cliente
	{
		public int ClienteId { get; set; }  

		public string Nome { get; set; }

		public string Email { get; set; }

		public string CPF { get; set; }

		public DateTime DataCadastro { get; set; }

		public bool IsValid() {
			return EmailService.IsValid(Email) && CPFService.IsValid(CPF);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.OCP.SolucaoExtensionMethods
{
	public static class DebitoContaInvestimento
	{
		public static string DebitarContaInvestimento(this DebitoConta debitoConta)
		{
			//logica de negócio para debitar de conta investimento
			return debitoConta.FormatarTransacao();
		}
	}
}

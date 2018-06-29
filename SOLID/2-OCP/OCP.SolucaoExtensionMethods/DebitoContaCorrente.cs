using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.OCP.SolucaoExtensionMethods
{
	public static class DebitoContaCorrente
	{
		public static string DebitarContaCorrente(this DebitoConta debitoConta)
		{
			//logica de negócio para debitar de conta corrente
			return debitoConta.FormatarTransacao();
		}
	}
}

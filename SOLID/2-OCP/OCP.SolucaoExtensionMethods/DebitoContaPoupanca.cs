using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.OCP.SolucaoExtensionMethods
{
	public static class DebitoContaPoupanca
	{

		public static string DebitarContaPoupanca(this DebitoConta debitoConta)
		{
			//regra de negocio para debitar de conta poupança
			return debitoConta.FormatarTransacao();
		}
	}
}

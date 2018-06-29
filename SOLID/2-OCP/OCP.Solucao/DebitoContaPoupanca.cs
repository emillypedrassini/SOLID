using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.OCP.Solucao
{
	class DebitoContaPoupanca : DebitoConta
	{
		public override string Debitar(decimal valor, string conta)
		{
			//valida aniversario da conta
			// debita conta corrente
			return NumeroTransacao;
		}
	}
}

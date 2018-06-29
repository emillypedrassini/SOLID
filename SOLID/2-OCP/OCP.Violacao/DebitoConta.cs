using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.OCP.Violacao
{
	public class DebitoConta
	{
		public void Debitar(decimal valor, string conta, TipoConta tipoConta)
		{
			if (tipoConta == TipoConta.Corrente)
			{
				//debita conta corrente
			}

			if (tipoConta == TipoConta.Poupanca)
			{
				//valida aniversario da conta
				//debita conta poupança
			}
		}
	}
}

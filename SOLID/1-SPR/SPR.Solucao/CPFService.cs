using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_SPR.SPR.Solucao
{
	public static class CPFService
	{
		public static bool IsValid(string cpf)
		{
			return cpf.Length == 11;
		}
	}
}

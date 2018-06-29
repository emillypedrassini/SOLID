using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.DIP.Violacao
{
	class CPFService
	{
		public static bool IsValid(string cpf)
		{
			return cpf.Length == 11;
		}
	}
}

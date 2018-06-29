using SOLID._5_DIP.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.DIP.Solucao
{
	public class CPFService : ICPFService
	{
		public bool IsValid(string cpf)
		{
			return cpf.Length == 11;
		}
	}
}

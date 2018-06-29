using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.DIP.Solucao.Interfaces
{
	public interface ICPFService
	{
		bool IsValid(string cpf);
	}
}

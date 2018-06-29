using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.ISP_Violacao
{
	public interface ICadastro
	{
		void ValidarDados();
		void SalvarBanco();
		void EnviarEmail();
	}
}

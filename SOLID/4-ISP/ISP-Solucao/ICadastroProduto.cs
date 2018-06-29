using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.ISP_Solucao
{
	public interface ICadastroProduto
	{
		void ValidarDados();
		void SalvarBanco();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.ISP_Violacao
{
	public class CadastroProduto : ICadastro
	{
		public void ValidarDados()
		{
			// validar valor
		}

		public void SalvarBanco()
		{
			// insert na tabela Produto
		}

		public void EnviarEmail()
		{
			// produto não tem email, o que faço agora ????
		}
	}
}

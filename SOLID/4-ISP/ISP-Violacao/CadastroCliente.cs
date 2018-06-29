using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.ISP_Violacao
{
	public class CadastroCliente : ICadastro
	{
		public void ValidarDados()
		{
			// validar cpf, email 
		}

		public void SalvarBanco()
		{
			// insert na tabela cliente
		}

		public void EnviarEmail()
		{
			// enviar e-mail para o cliente
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_ISP.ISP_Solucao
{
	public class CadastroCliente : ICadastroCliente
	{
		public void ValidarDados()
		{
			// validar cpf, email
		}
		
		public void SalvarBanco()
		{
			// insert na tabela Cliente
		}

		public void EnviarEmail()
		{
			// enviar email para o cliente
		}
	}
}

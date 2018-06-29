using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

//PRINCIPIO DE RESPONSÁBILIADE ÚNICA
namespace SOLID._1_SPR.SRP.Violacao
{
	//essa classe tem muitas responsábilidades

	/* 1 violação
	 * essa classe adiona cliente
	 * uma classe não deve se adionar ao banco, alguem tem que fazer isso para ela, seja um repositorio uma outra classe
	 */
	public class Cliente
	{

		public int ClienteId { get; set; }

		public string Nome { get; set; }

		public string Email { get; set; }

		public string CPF { get; set; }

		public DateTime DataCadastro { get; set; }

		//esse método não deveria estar aqui, a classe não tem a responsabilidade de cadastrar o cliente no banco, ela deveria só validar o cliente se ele esta consistente 
		public string AdicionarCliente()
		{
			// violação pq esta dando ao método a responsabilidade de como ele deve validar se o email é valido ou não
			// o método de adicionar cliente não responsável por saber como validar email
			if (!Email.Contains("@"))
			{
				return "Cliente com e-mail inválido";
			}

			// o método de adicionar cliente não é obrigada a saber como validar um cpf
			if (CPF.Length != 11)
			{
				return "Cliente com CPF inválido";
			}

			// o método não é obrigado a conectar-se ao banco de dados e nem saber como conecta ao banco e que banco está utilizando 
			using (var cn = new SqlConnection())
			{
				var cmd = new SqlCommand();

				cn.ConnectionString = "MinhaConnectionString";
				cmd.Connection = cn;
				cmd.CommandType = System.Data.CommandType.Text;
				cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datCad)";

				cmd.Parameters.AddWithValue("nome", Nome);
				cmd.Parameters.AddWithValue("email", Email);
				cmd.Parameters.AddWithValue("cpf", CPF);
				cmd.Parameters.AddWithValue("datCad", DataCadastro);

				cn.Open();
				cmd.ExecuteNonQuery();

			}

			//não é responsabilidade dele enviar email - não deve saber como enviar email
			var mail = new MailMessage("empresa@empresa.com", Email);
			var client = new SmtpClient
			{
				Port = 25,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Host = "smtp.google.com"
			};

			mail.Subject = "Bem Vindo";
			mail.Body = "Parabéns você está cadastrado";
			client.Send(mail);

			return "CLiente cadastrado com sucesso";

			// o método só deveria cadastrar o cliente no banco, como fazer isso ele não deveria saber 
		}
	}
}

using SOLID._5_DIP.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.DIP.Solucao
{
	public class ClienteRepository : IClienteRepository
	{
		public void AdicionarCliente(Cliente cliente)
		{
			using (var cn = new SqlConnection())
			{
				var cmd = new SqlCommand();

				cn.ConnectionString = "MinhaConnectionString";
				cmd.Connection = cn;
				cmd.CommandType = System.Data.CommandType.Text;
				cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datCad)";

				cmd.Parameters.AddWithValue("nome", cliente.Nome);
				cmd.Parameters.AddWithValue("email", cliente.Email);
				cmd.Parameters.AddWithValue("cpf", cliente.CPF);
				cmd.Parameters.AddWithValue("datCad", cliente.DataCadastro);

				cn.Open();
				cmd.ExecuteNonQuery();
			}
		}
	}
}

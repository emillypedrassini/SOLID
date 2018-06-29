using System.Data.SqlClient;

namespace SOLID._1_SPR.SPR.Solucao
{
	//essa classe que conhece o banco e adicona o cliente nele
	public class ClienteRepository
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

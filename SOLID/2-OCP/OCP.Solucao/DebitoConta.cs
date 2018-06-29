using System;
using System.Linq;

namespace SOLID._2_OCP.OCP.Solucao
{
	/// <summary>
	///		esta classe atente o principio de OCP - ela esta fechada
	///		não ha necessidade de mexer nela caso um novo tipo de conta seja criado
	///		
	///		classe abstrata não possui implementação
	///		desta forma a classe que herdar da classe abstrata sera obrigada a implementar os metodos da classe abstrata(pai)
	/// </summary>
	public abstract class DebitoConta
	{
		public string NumeroTransacao { get; set; }

		public abstract string Debitar(decimal valor, string conta);

		public string FormatarTransacao()
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			var random = new Random();

			NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
				.Select(s => s[random.Next(s.Length)]).ToArray());

			//numero de transacao formatado
			return NumeroTransacao;
		}
	}
}

using SOLID._5_DIP.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_DIP.DIP.Solucao
{
	public class EmailService : IEmailService
	{
		public bool IsValid(string email)
		{
			return email.Contains("@");
		}

		public void Enviar(string deEmail, string paraEmail, string assunto, string mensagem)
		{
			var mail = new MailMessage(deEmail, paraEmail);
			var client = new SmtpClient
			{
				Port = 25,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Host = "smtp.google.com"
			};

			mail.Subject = assunto;
			mail.Body = mensagem;
			client.Send(mail);
		}

	}
}

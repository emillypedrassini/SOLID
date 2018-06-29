using System.Net.Mail;

namespace SOLID._5_DIP.DIP.Violacao
{
	class EmailService
	{
		public static bool IsValid(string email)
		{
			return email.Contains("@");
		}

		public static void Enviar(string deEmail, string paraEmail, string assunto, string mensagem)
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

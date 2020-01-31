using MimeKit;
using MailKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;

namespace SweepstakesProject
{
    class SweepstakeEmailer
    {
		public void SendWinnerEmail(Contestant contestant, Sweepstakes sweepstakes)
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Mr. Anderson", "aaronmadisondevtesting@gmail.com"));
			message.To.Add(new MailboxAddress(contestant.GetName(), contestant.Email));
			message.Subject = "Congratulations!";

			message.Body = new TextPart("plain")
			{
				Text = $"You've won! " +
				$"\nYoure the big winner of the big {sweepstakes.Name} sweepstakes!" +
				$"\nUnfortunately this is just a boot camp assignment, so you don't get anything. Congrats though." +
				$"\n- Mr Anderson at Customer Services"
			};

			using (var client = new SmtpClient())
			{
				client.ServerCertificateValidationCallback = (s, c, h, e) => true;

				client.Connect("smtp.gmail.com", 587, false);

				client.Authenticate("aaronmadisondevtesting@gmail.com", "AMpass@Google1");

				client.Send(message);
				client.Disconnect(true);
			}
		}

		public void SendLoserEmail(Contestant contestant, Sweepstakes sweepstakes, Contestant winner)
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Mr. Anderson", "aaronmadisondevtesting@gmail.com"));
			message.To.Add(new MailboxAddress(contestant.GetName(), contestant.Email));
			message.Subject = "Sorry contestant.GetName()!";

			message.Body = new TextPart("plain")
			{
				Text = $"You lost this time, but try again! " +
				$"\n{winner.GetName()} was the big winner of the big {sweepstakes.Name} sweepstakes!" +
				$"\nFortunately this is just a boot camp assignment, so they didn't get anything anyways. Player again though." +
				$"\n- Mr Anderson at Customer Services"
			};

			using (var client = new SmtpClient())
			{
				client.ServerCertificateValidationCallback = (s, c, h, e) => true;

				client.Connect("smtp.gmail.com", 587, false);

				client.Authenticate("aaronmadisondevtesting@gmail.com", "AMpass@Google1");

				client.Send(message);
				client.Disconnect(true);
			}
		}

	}
}

using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;

namespace CONTROLADORA.ServiciosCorreo
{
    public class ServicioCorreoSendGrid
    {
        private readonly string apiKey;
        private readonly string remitenteNombre;
        private readonly string remitenteEmail;

        public ServicioCorreoSendGrid()
        {
            Env.Load();

            apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            remitenteNombre = Environment.GetEnvironmentVariable("SENDGRID_NAME");
            remitenteEmail = Environment.GetEnvironmentVariable("SENDGRID_EMAIL");

            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(remitenteEmail))
            {
                throw new Exception("Faltan las variables de entorno SENDGRID en el archivo .env");
            }
        }

        public async Task EnviarCorreoAsync(string asunto, string mensaje, List<string> destinatarios)
        {
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(remitenteEmail, remitenteNombre);

            var tos = destinatarios.Select(dest => new EmailAddress(dest)).ToList();
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, asunto, mensaje, null);

            var response = await client.SendEmailAsync(msg);
            if ((int)response.StatusCode >= 400)
            {
                throw new Exception("Error al enviar correo con SendGrid.");
            }
        }
    }
}

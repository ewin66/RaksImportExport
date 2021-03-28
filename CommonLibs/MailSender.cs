using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs
{
    public static class MailSender
    {



        public static void SendEmail(string subject, string body, string receiver)
        {
            if (String.IsNullOrEmpty(receiver))
            {
                return;
            }

            string replyTo = "Jacek.Kosinski@outlook.com";
            string bcc = "kashiash@gmail.com";

            string your_id = @"jacek.kosinski@uta.pl";// Konfigurator.GetConfigValue(13);
            string your_password = "Starwars#33";//Konfigurator.GetConfigValue(14);
            try
            {
                System.Net.Mail.SmtpClient client = new SmtpClient
                {
                    Host = "timex.home.pl", // Konfigurator.GetConfigValue(15),
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(your_id, your_password),
                    Timeout = 10000,
                };

                // _logger.Trace("Email to Send to  {0}", receiver);
                MailMessage mm = new MailMessage(); // , receiver, subject, body);
                mm.From = new MailAddress(your_id);
                mm.Subject = subject;
                mm.Body = body;
                mm.Priority = MailPriority.High;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;




                string[] allToAddresses = receiver.Split(";,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (string toAddress in allToAddresses)
                {
                    try
                    {
                        mm.To.Add(toAddress);
                    }
                    catch (FormatException)
                    {
                        //do nothing, illformed address. screw it.
                    }
                }

                MailAddress _bcc = new MailAddress("kashish@gmail.com");
                mm.Bcc.Add(_bcc);
                MailAddress _bcc2 = new MailAddress("kashiash@gmail.com");
                mm.Bcc.Add(_bcc2);
                if (bcc != null)
                {
                    string[] allToAddressesBCC = bcc.Split(";,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (string toAddress in allToAddressesBCC)
                    {
                        try
                        {
                            mm.Bcc.Add(toAddress);
                        }
                        catch (FormatException)
                        {
                            //do nothing, illformed address. screw it.
                        }
                    }
                }



                mm.IsBodyHtml = true;
                MailAddress reply = new MailAddress(replyTo);
                mm.ReplyToList.Add(reply);

                client.Send(mm);


                //  stream.Dispose();
            }
            catch (System.Exception)
            {

                throw;
            }


        }

    }
}

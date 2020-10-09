using System;
using System.Net.Mail;
using System.Security.Authentication;
using System.Windows.Forms;

namespace SMTPCheck
{
    public class SendMail
    {
        public void Send(string SmtpAddress, int port, string usrName, string pass, bool ssl, string fromAddress, string toAddress)
        {
            try
            {
                MailMessage Mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(SmtpAddress);
                Mail.From = new MailAddress(fromAddress);
                Mail.To.Add(toAddress);
                Mail.Subject = "Test";
                Mail.Body = DateTime.Now.ToString();
                SmtpServer.Port = port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(usrName, pass);
                SmtpServer.EnableSsl = ssl;
                SmtpServer.Send(Mail);
            }
            catch (SmtpException sx)
            {
                var statusCode = Convert.ToString(sx.StatusCode); // https://msdn.microsoft.com/en-us/library/system.net.mail.smtpstatuscode(v=vs.110).aspx
                if (statusCode == "GeneralFailure")
                {
                    MessageBox.Show("Chyba spojenia so serverom");
                    return;
                }
                if (statusCode == "ExceededStorageAllocation")
                {
                    MessageBox.Show("Správa je príliž veľká");
                    return;
                }
                if (statusCode == "MustIssueStartTlsFirst")
                {
                    MessageBox.Show("Skontroluj SSL/TLS alebo Chyba prihlasovania");
                    return;
                }
                if (statusCode == "TransactionFailed")
                {
                    MessageBox.Show("Prenos zlyhal");
                    return;
                }
                if (statusCode == "ClientNotPermitted")
                {
                    MessageBox.Show("Užívateľ nemá povolenie na odosielanie");
                    return;
                }
                if (statusCode == "MailboxBusy")
                {
                    MessageBox.Show("Adresa sa práve používa");
                    return;
                }
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("Chyba prihlasovania");
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadaj správne e-mailovú adresu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vyskytla sa chyba");
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}

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
                MainForm.btnVisibility = true;
            }
            catch (SmtpException sx)
            {
                var statusCode = Convert.ToString(sx.StatusCode); // https://msdn.microsoft.com/en-us/library/system.net.mail.smtpstatuscode(v=vs.110).aspx
                if (statusCode == "GeneralFailure")
                {
                    MessageBox.Show("Chyba spojenia so serverom");
                    MainForm.btnVisibility = true;
                    return;
                }
                if (statusCode == "ExceededStorageAllocation")
                {
                    MessageBox.Show("Správa je príliž veľká");
                    MainForm.btnVisibility = true;
                    return;
                }
                if (statusCode == "MustIssueStartTlsFirst")
                {
                    MessageBox.Show("Skontroluj SSL/TLS alebo Chyba prihlasovania");
                    MainForm.btnVisibility = true;
                    return;
                }
                if (statusCode == "TransactionFailed")
                {
                    MessageBox.Show("Prenos zlyhal");
                    MainForm.btnVisibility = true;
                    return;
                }
                if (statusCode == "ClientNotPermitted")
                {
                    MessageBox.Show("Užívateľ nemá povolenie na odosielanie");
                    MainForm.btnVisibility = true;
                    return;
                }
                if (statusCode == "MailboxBusy")
                {
                    MessageBox.Show("Adresa sa práve používa");
                    MainForm.btnVisibility = true;
                    return;
                }
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("Chyba prihlasovania");
                MainForm.btnVisibility = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Zadaj správne e-mailovú adresu");
                MainForm.btnVisibility = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vyskytla sa chyba");
                MessageBox.Show(Convert.ToString(ex));
                MainForm.btnVisibility = true;
            }
        }
    }
}
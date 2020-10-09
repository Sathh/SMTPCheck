using System;
using System.Threading;
using System.Windows.Forms;

namespace SMTPCheck
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void runButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressBox.Text))
            {
                MessageBox.Show("Zadaj IP adresu alebo hostname SMTP servera", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(portBox.Text))
            {
                MessageBox.Show("Zadaj port SMTP servera", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(usrNameBox.Text))
            {
                MessageBox.Show("Zadaj prihlasovacie meno", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(passBox.Text))
            {
                MessageBox.Show("Zadaj prihlasovacie heslo", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(fromBox.Text))
            {
                MessageBox.Show("Zadaj adresu odosielateľa", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(toBox.Text))
            {
                MessageBox.Show("Zadaj adresu na ktorú príde testovací e-mail", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread thread1 = new Thread(WorkThread);
            thread1.Start();
        }

        public void WorkThread()
        {
            SendMail mail = new SendMail();
            mail.Send(addressBox.Text, Convert.ToInt32(portBox.Text), usrNameBox.Text, passBox.Text, sslCheckBox.Checked, fromBox.Text, toBox.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            portBox.Text = comboBox.Text;
        }
    }
}

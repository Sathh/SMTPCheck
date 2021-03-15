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
        public static bool btnVisibility;
        private void btnTimer()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(refreshBtn);
            timer.Enabled = true;
            timer.Start();
        }
        private void refreshBtn(object o, EventArgs eventA)
        {
            if (btnVisibility == true)
                runButton.Visible = true;
        }
        private void runButton_Click(object sender, EventArgs e)
        {
            btnVisibility = false;
            runButton.Visible = false;
            btnTimer();
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
            if (checkBox1.Checked == false)
            {
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                usrNameBox.Visible = false;
                passBox.Visible = false;
                usrNameLabel.Visible = false;
                passLabel.Visible = false;
            }
            else
            {
                usrNameBox.Visible = true;
                passBox.Visible = true;
                usrNameLabel.Visible = true;
                passLabel.Visible = true;
            }
        }
    }
}

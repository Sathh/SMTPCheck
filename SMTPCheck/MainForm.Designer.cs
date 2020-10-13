namespace SMTPCheck
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addressBox = new System.Windows.Forms.TextBox();
            this.sslCheckBox = new System.Windows.Forms.CheckBox();
            this.usrNameBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.usrNameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.toBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(195, 50);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(326, 20);
            this.addressBox.TabIndex = 0;
            // 
            // sslCheckBox
            // 
            this.sslCheckBox.AutoSize = true;
            this.sslCheckBox.Location = new System.Drawing.Point(527, 53);
            this.sslCheckBox.Name = "sslCheckBox";
            this.sslCheckBox.Size = new System.Drawing.Size(71, 17);
            this.sslCheckBox.TabIndex = 7;
            this.sslCheckBox.Text = "SSL/TLS";
            this.sslCheckBox.UseVisualStyleBackColor = true;
            // 
            // usrNameBox
            // 
            this.usrNameBox.Location = new System.Drawing.Point(195, 124);
            this.usrNameBox.Name = "usrNameBox";
            this.usrNameBox.Size = new System.Drawing.Size(326, 20);
            this.usrNameBox.TabIndex = 2;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(195, 161);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = 'x';
            this.passBox.Size = new System.Drawing.Size(326, 20);
            this.passBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(24, 53);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(165, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Hostname alebo IP adresa SMTP";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(163, 90);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Port";
            // 
            // usrNameLabel
            // 
            this.usrNameLabel.AutoSize = true;
            this.usrNameLabel.Location = new System.Drawing.Point(94, 127);
            this.usrNameLabel.Name = "usrNameLabel";
            this.usrNameLabel.Size = new System.Drawing.Size(95, 13);
            this.usrNameLabel.TabIndex = 9;
            this.usrNameLabel.Text = "Užívateľské meno";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(155, 164);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(34, 13);
            this.passLabel.TabIndex = 10;
            this.passLabel.Text = "Heslo";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(195, 198);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(326, 20);
            this.fromBox.TabIndex = 4;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(107, 201);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(82, 13);
            this.fromLabel.TabIndex = 12;
            this.fromLabel.Text = "Adresa od koho";
            // 
            // runButton
            // 
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runButton.Location = new System.Drawing.Point(195, 280);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(326, 69);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "Spustiť test";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(195, 87);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(326, 20);
            this.portBox.TabIndex = 1;
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(195, 235);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(326, 20);
            this.toBox.TabIndex = 5;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(74, 238);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(115, 13);
            this.toLabel.TabIndex = 16;
            this.toLabel.Text = "Odoslať mail na adresu";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "",
            "21",
            "465",
            "587"});
            this.comboBox.Location = new System.Drawing.Point(527, 86);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(61, 21);
            this.comboBox.TabIndex = 17;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 361);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usrNameLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.usrNameBox);
            this.Controls.Add(this.sslCheckBox);
            this.Controls.Add(this.addressBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SMTP Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.CheckBox sslCheckBox;
        private System.Windows.Forms.TextBox usrNameBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label usrNameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

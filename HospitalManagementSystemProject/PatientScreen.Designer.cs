namespace HospitalManagementSystemProject
{
    partial class PatientScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 164);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgisi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(7, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(492, 415);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu İşlemleri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 15.75F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(191, 26);
            label1.TabIndex = 8;
            label1.Text = "TC Kimlik Numarası :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 15.75F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(100, 103);
            label2.Name = "label2";
            label2.Size = new Size(107, 26);
            label2.TabIndex = 9;
            label2.Text = "Ad Soyad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 15.75F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(213, 53);
            label3.Name = "label3";
            label3.Size = new Size(133, 26);
            label3.TabIndex = 10;
            label3.Text = "00000000000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 15.75F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(213, 103);
            label4.Name = "label4";
            label4.Size = new Size(80, 26);
            label4.TabIndex = 11;
            label4.Text = "null null";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 15.75F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(53, 83);
            label5.Name = "label5";
            label5.Size = new Size(70, 26);
            label5.TabIndex = 12;
            label5.Text = "Branş :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 15.75F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(41, 138);
            label6.Name = "label6";
            label6.Size = new Size(82, 26);
            label6.TabIndex = 13;
            label6.Text = "Doktor :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 15.75F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(37, 193);
            label7.Name = "label7";
            label7.Size = new Size(86, 26);
            label7.TabIndex = 14;
            label7.Text = "Şikayet :";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Genel Cerrahi\t\t", "Kulak Burun Boğaz", "Üroloji", "Dermatoloji", "Plastik Ve Rekonstrüktif Cerrahi", "Fizik Tedavi Ve Rehabilitasyon", "Psikiyatri", "Kardiyovasküler Cerrahi ", "Ortopedi", "Beyin Ve Sinir Cerrahisi", "Göz Hastalıkları", "Dahiliye" });
            comboBox1.Location = new Point(129, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(320, 38);
            comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Opr. Dr. Yasin Ramazan GÖK", "Prof. Dr. Enes BALCI", "Doç. Dr. Mehmet Ali GÖK", "Opr. Dr. Emine GÖÇER", "Prof. Dr. Yusuf SAĞLAM", "Prof. Dr. Ahmet Asım TRABZON", "Doç. Dr. Hakan ÇAM" });
            comboBox2.Location = new Point(129, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(320, 38);
            comboBox2.TabIndex = 16;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(129, 196);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(320, 120);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "Şikayetinizi yazınız";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(204, 339);
            button1.Name = "button1";
            button1.Size = new Size(171, 47);
            button1.TabIndex = 18;
            button1.Text = "Oluştur";
            button1.UseVisualStyleBackColor = false;
            // 
            // PatientScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1061, 679);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PatientScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientScreen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button1;
    }
}
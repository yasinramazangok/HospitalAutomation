namespace HospitalManagementSystemProject
{
    partial class DoctorEditInformation
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
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(254, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 36);
            comboBox1.TabIndex = 49;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(254, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 34);
            textBox3.TabIndex = 47;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(254, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 34);
            textBox2.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(152, 327);
            label6.Name = "label6";
            label6.Size = new Size(79, 33);
            label6.TabIndex = 44;
            label6.Text = "Şifre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(141, 271);
            label5.Name = "label5";
            label5.Size = new Size(90, 33);
            label5.TabIndex = 43;
            label5.Text = "Branş :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 215);
            label4.Name = "label4";
            label4.Size = new Size(174, 33);
            label4.TabIndex = 42;
            label4.Text = "TC Kimlik No : ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(331, 399);
            button1.Name = "button1";
            button1.Size = new Size(171, 47);
            button1.TabIndex = 41;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(254, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 34);
            textBox1.TabIndex = 40;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(254, 213);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(312, 35);
            maskedTextBox1.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(130, 159);
            label3.Name = "label3";
            label3.Size = new Size(101, 33);
            label3.TabIndex = 38;
            label3.Text = "Soyad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 103);
            label2.Name = "label2";
            label2.Size = new Size(63, 33);
            label2.TabIndex = 37;
            label2.Text = "Ad : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(302, 24);
            label1.Name = "label1";
            label1.Size = new Size(244, 33);
            label1.TabIndex = 36;
            label1.Text = "Güncelleme İşlemleri";
            // 
            // DoctorEditInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(800, 478);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DoctorEditInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Bilgi Güncelleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
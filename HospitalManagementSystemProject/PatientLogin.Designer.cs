namespace HospitalManagementSystemProject
{
    partial class PatientLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(311, 49);
            label1.Name = "label1";
            label1.Size = new Size(268, 41);
            label1.TabIndex = 0;
            label1.Text = "Hasta Giriş Ekranı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 179);
            label2.Name = "label2";
            label2.Size = new Size(320, 41);
            label2.TabIndex = 1;
            label2.Text = "TC Kimlik Numarası : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 288);
            label3.Name = "label3";
            label3.Size = new Size(100, 41);
            label3.TabIndex = 2;
            label3.Text = "Şifre :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(311, 176);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(356, 42);
            maskedTextBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(311, 288);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 41);
            textBox1.TabIndex = 4;
            textBox1.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(311, 373);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(195, 63);
            button1.TabIndex = 5;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(553, 385);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 35);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Üye Ol";
            // 
            // PatientLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(832, 600);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}
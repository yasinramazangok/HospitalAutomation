namespace HospitalManagementSystemProject
{
    partial class SystemLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemLogin));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(136, 389);
            button1.Name = "button1";
            button1.Size = new Size(306, 198);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(596, 389);
            button2.Name = "button2";
            button2.Size = new Size(306, 198);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(1067, 389);
            button3.Name = "button3";
            button3.Size = new Size(306, 198);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(230, 624);
            label1.MaximumSize = new Size(200, 200);
            label1.Name = "label1";
            label1.Size = new Size(118, 45);
            label1.TabIndex = 3;
            label1.Text = "Doktor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(692, 624);
            label2.MaximumSize = new Size(200, 200);
            label2.Name = "label2";
            label2.Size = new Size(100, 45);
            label2.TabIndex = 4;
            label2.Text = "Hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(1161, 624);
            label3.MaximumSize = new Size(200, 200);
            label3.Name = "label3";
            label3.Size = new Size(137, 45);
            label3.TabIndex = 5;
            label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 32F);
            label4.Location = new Point(519, 93);
            label4.Name = "label4";
            label4.Size = new Size(870, 75);
            label4.TabIndex = 7;
            label4.Text = "Aktepe Eğitim Ve Araştırma Hastanesi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(602, 769);
            label5.Name = "label5";
            label5.Size = new Size(298, 28);
            label5.TabIndex = 8;
            label5.Text = "Giriş yapmak için kullanıcı seçiniz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1505, 869);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastane Yönetim Sistemi V1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
    }
}

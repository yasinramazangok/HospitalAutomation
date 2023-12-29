namespace HospitalManagementSystemProject
{
    partial class SecretaryBranchEdit
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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(486, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(375, 228);
            dataGridView1.TabIndex = 79;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(154, 266);
            button3.Name = "button3";
            button3.Size = new Size(312, 47);
            button3.TabIndex = 5;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(316, 202);
            button2.Name = "button2";
            button2.Size = new Size(150, 47);
            button2.TabIndex = 4;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(154, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 34);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(154, 202);
            button1.Name = "button1";
            button1.Size = new Size(146, 47);
            button1.TabIndex = 3;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(154, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 34);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 141);
            label3.Name = "label3";
            label3.Size = new Size(131, 33);
            label3.TabIndex = 67;
            label3.Text = "Branş Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 85);
            label2.Name = "label2";
            label2.Size = new Size(116, 33);
            label2.TabIndex = 66;
            label2.Text = "Branş Id :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(378, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 33);
            label1.TabIndex = 65;
            label1.Text = "Branş Bilgileri";
            // 
            // SecretaryBranchEdit
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(879, 328);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SecretaryBranchEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Branş Düzenle";
            Load += SecretaryBranchEdit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
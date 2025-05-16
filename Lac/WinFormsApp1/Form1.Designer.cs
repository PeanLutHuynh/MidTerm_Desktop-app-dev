namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            btnthem = new Button();
            btnluu = new Button();
            btnthoat = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 27);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 65);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 100);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 136);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(153, 62);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(567, 23);
            maskedTextBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(567, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 218);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(153, 97);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(567, 23);
            maskedTextBox2.TabIndex = 7;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(153, 133);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(567, 23);
            maskedTextBox3.TabIndex = 8;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(134, 186);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(131, 47);
            btnthem.TabIndex = 9;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(326, 186);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(131, 47);
            btnluu.TabIndex = 10;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(517, 186);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(131, 47);
            btnthoat.TabIndex = 11;
            btnthoat.Text = "Xóa";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(btnthoat);
            Controls.Add(btnluu);
            Controls.Add(btnthem);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Nhóm 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Button btnthem;
        private Button btnluu;
        private Button btnthoat;
        private TextBox textBox2;
    }
}

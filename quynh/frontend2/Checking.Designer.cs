namespace frontend2
{
    partial class Checking
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
            btn_Deposit = new Button();
            btn_display = new Button();
            lb_hoten = new Label();
            lb_address = new Label();
            lb_phone = new Label();
            SuspendLayout();
            // 
            // btn_Deposit
            // 
            btn_Deposit.Location = new Point(87, 309);
            btn_Deposit.Name = "btn_Deposit";
            btn_Deposit.Size = new Size(75, 23);
            btn_Deposit.TabIndex = 1;
            btn_Deposit.Text = "Deposit";
            btn_Deposit.UseVisualStyleBackColor = true;
            // 
            // btn_display
            // 
            btn_display.Location = new Point(237, 309);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(75, 23);
            btn_display.TabIndex = 2;
            btn_display.Text = "Display Transaction";
            btn_display.UseVisualStyleBackColor = true;
            // 
            // lb_hoten
            // 
            lb_hoten.AutoSize = true;
            lb_hoten.Location = new Point(116, 101);
            lb_hoten.Name = "lb_hoten";
            lb_hoten.Size = new Size(59, 15);
            lb_hoten.TabIndex = 3;
            lb_hoten.Text = "Họ và Tên";
            lb_hoten.Click += this.lb_hoten_Click;
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Location = new Point(116, 140);
            lb_address.Name = "lb_address";
            lb_address.Size = new Size(43, 15);
            lb_address.TabIndex = 4;
            lb_address.Text = "Địa chỉ";
            lb_address.Click += this.lb_address_Click;
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Location = new Point(116, 179);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(41, 15);
            lb_phone.TabIndex = 5;
            lb_phone.Text = "Phone";
            lb_phone.Click += this.lb_phone_Click;
            // 
            // Checking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 402);
            Controls.Add(lb_phone);
            Controls.Add(lb_address);
            Controls.Add(lb_hoten);
            Controls.Add(btn_display);
            Controls.Add(btn_Deposit);
            Name = "Checking";
            Text = "Form2";
            Load += this.Checking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Deposit;
        private Button btn_display;
        private Label lb_hoten;
        private Label lb_address;
        private Label lb_phone;
    }
}
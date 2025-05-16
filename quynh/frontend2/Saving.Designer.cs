namespace frontend2
{
    partial class Saving
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
            lb_phone = new Label();
            lb_address = new Label();
            lb_hoten = new Label();
            btn_back = new Button();
            SuspendLayout();
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Location = new Point(137, 195);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(41, 15);
            lb_phone.TabIndex = 8;
            lb_phone.Text = "Phone";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Location = new Point(137, 156);
            lb_address.Name = "lb_address";
            lb_address.Size = new Size(43, 15);
            lb_address.TabIndex = 7;
            lb_address.Text = "Địa chỉ";
            // 
            // lb_hoten
            // 
            lb_hoten.AutoSize = true;
            lb_hoten.Location = new Point(137, 117);
            lb_hoten.Name = "lb_hoten";
            lb_hoten.Size = new Size(59, 15);
            lb_hoten.TabIndex = 6;
            lb_hoten.Text = "Họ và Tên";
            // 
            // btn_back
            // 
            btn_back.Location = new Point(297, 384);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            // 
            // Saving
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 426);
            Controls.Add(btn_back);
            Controls.Add(lb_phone);
            Controls.Add(lb_address);
            Controls.Add(lb_hoten);
            Name = "Saving";
            Text = "Saving";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_phone;
        private Label lb_address;
        private Label lb_hoten;
        private Button btn_back;
    }
}
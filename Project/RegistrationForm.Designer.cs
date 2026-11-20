namespace Project
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MobileListBox = new System.Windows.Forms.ListBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ลงทะเบียน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(146, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "กรุณากรอก ข้อมูลให้ครบถ้วน เพื่อเลงทะเบียน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "ชื่อผู้ใช้";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(128, 105);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(451, 45);
            this.UsernameTextBox.TabIndex = 10;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label5.Location = new System.Drawing.Point(38, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "รหัสผ่าน";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(130, 156);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(449, 45);
            this.PasswordTextbox.TabIndex = 14;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label6.Location = new System.Drawing.Point(39, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "ชื่อ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.NameTextBox.Location = new System.Drawing.Point(95, 223);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(206, 45);
            this.NameTextBox.TabIndex = 16;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.SurnameTextBox.Location = new System.Drawing.Point(408, 219);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(171, 45);
            this.SurnameTextBox.TabIndex = 29;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.Location = new System.Drawing.Point(307, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "นามสกุล";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.MobileListBox);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SurnameTextBox);
            this.panel1.Controls.Add(this.MobileTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PasswordTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UsernameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(139, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 983);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(599, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 34);
            this.button3.TabIndex = 37;
            this.button3.Text = "Delete All";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(599, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 34);
            this.button2.TabIndex = 36;
            this.button2.Text = "Delete item";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(599, 355);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(141, 34);
            this.AddButton.TabIndex = 35;
            this.AddButton.Text = "Add item";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // MobileListBox
            // 
            this.MobileListBox.FormattingEnabled = true;
            this.MobileListBox.ItemHeight = 38;
            this.MobileListBox.Location = new System.Drawing.Point(192, 400);
            this.MobileListBox.Name = "MobileListBox";
            this.MobileListBox.Size = new System.Drawing.Size(387, 80);
            this.MobileListBox.TabIndex = 34;
            this.MobileListBox.SelectedIndexChanged += new System.EventHandler(this.MobileListBox_SelectedIndexChanged);
            this.MobileListBox.DoubleClick += new System.EventHandler(this.MobileListBox_DoubleClick);
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.IDTextBox.Location = new System.Drawing.Point(282, 286);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(297, 45);
            this.IDTextBox.TabIndex = 33;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label7.Location = new System.Drawing.Point(39, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 35);
            this.label7.TabIndex = 32;
            this.label7.Text = "หมายเลขบัตรประชาชน:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 55);
            this.button1.TabIndex = 31;
            this.button1.Text = "ลงทะเบียน";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.MobileTextBox.Location = new System.Drawing.Point(187, 344);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(392, 45);
            this.MobileTextBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label9.Location = new System.Drawing.Point(39, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 35);
            this.label9.TabIndex = 22;
            this.label9.Text = "เบอร์โทรศัพท์";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(8, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 55);
            this.button4.TabIndex = 38;
            this.button4.Text = "ย้อนกลับ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Screenshot_2024_09_18_225715;
            this.ClientSize = new System.Drawing.Size(996, 643);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox MobileListBox;
        private System.Windows.Forms.Button button4;
    }
}
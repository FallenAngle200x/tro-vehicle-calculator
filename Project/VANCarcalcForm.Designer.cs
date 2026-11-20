namespace Project
{
    partial class VANCarcalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VANCarcalcForm));
            this.DDTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GasRadioButton = new System.Windows.Forms.RadioButton();
            this.NolmalRadioButton = new System.Windows.Forms.RadioButton();
            this.LicenseplateTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KgTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Mainbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YYTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DDTimePicker
            // 
            this.DDTimePicker.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDTimePicker.Location = new System.Drawing.Point(65, 309);
            this.DDTimePicker.Name = "DDTimePicker";
            this.DDTimePicker.Size = new System.Drawing.Size(338, 47);
            this.DDTimePicker.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.YYTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.LicenseplateTextbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.DDTimePicker);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.KgTextbox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(244, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 563);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GasRadioButton);
            this.groupBox1.Controls.Add(this.NolmalRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 100);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ลักษณะรถ";
            // 
            // GasRadioButton
            // 
            this.GasRadioButton.AutoSize = true;
            this.GasRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GasRadioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GasRadioButton.Location = new System.Drawing.Point(111, 44);
            this.GasRadioButton.Name = "GasRadioButton";
            this.GasRadioButton.Size = new System.Drawing.Size(293, 45);
            this.GasRadioButton.TabIndex = 1;
            this.GasRadioButton.TabStop = true;
            this.GasRadioButton.Text = "CNG/LPGสลับเบนซิน";
            this.GasRadioButton.UseVisualStyleBackColor = true;
            this.GasRadioButton.CheckedChanged += new System.EventHandler(this.GasRadioButton_CheckedChanged);
            // 
            // NolmalRadioButton
            // 
            this.NolmalRadioButton.AutoSize = true;
            this.NolmalRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NolmalRadioButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NolmalRadioButton.Location = new System.Drawing.Point(5, 43);
            this.NolmalRadioButton.Name = "NolmalRadioButton";
            this.NolmalRadioButton.Size = new System.Drawing.Size(90, 45);
            this.NolmalRadioButton.TabIndex = 0;
            this.NolmalRadioButton.TabStop = true;
            this.NolmalRadioButton.Text = "ปกติ";
            this.NolmalRadioButton.UseVisualStyleBackColor = true;
            this.NolmalRadioButton.CheckedChanged += new System.EventHandler(this.NolmalRadioButton_CheckedChanged);
            // 
            // LicenseplateTextbox
            // 
            this.LicenseplateTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.LicenseplateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseplateTextbox.Location = new System.Drawing.Point(66, 62);
            this.LicenseplateTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.LicenseplateTextbox.Name = "LicenseplateTextbox";
            this.LicenseplateTextbox.Size = new System.Drawing.Size(237, 45);
            this.LicenseplateTextbox.TabIndex = 30;
            this.LicenseplateTextbox.TextChanged += new System.EventHandler(this.LicenseplateTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(59, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 46);
            this.label4.TabIndex = 29;
            this.label4.Text = "เลขทะเบียน";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(68, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "วิธีการตรวจสอบ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(67, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "ในกรณีที่ถัง LPG มีอายุครบ 10 ปี มีค่าบริการ ต่ออายุถัง 1000 บาท";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(61, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 45);
            this.label7.TabIndex = 17;
            this.label7.Text = "วันสิ้นภาษี";
            // 
            // KgTextbox
            // 
            this.KgTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.KgTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KgTextbox.Location = new System.Drawing.Point(68, 140);
            this.KgTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.KgTextbox.Name = "KgTextbox";
            this.KgTextbox.Size = new System.Drawing.Size(341, 45);
            this.KgTextbox.TabIndex = 9;
            this.KgTextbox.TextChanged += new System.EventHandler(this.KgTextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(168, 497);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "คำนวน";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(58, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "น้ำหนักรถ (kg) *";
            // 
            // Mainbutton
            // 
            this.Mainbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Mainbutton.Location = new System.Drawing.Point(13, 587);
            this.Mainbutton.Name = "Mainbutton";
            this.Mainbutton.Size = new System.Drawing.Size(142, 49);
            this.Mainbutton.TabIndex = 31;
            this.Mainbutton.Text = "ย้อนกลับ";
            this.Mainbutton.UseVisualStyleBackColor = false;
            this.Mainbutton.Click += new System.EventHandler(this.Mainbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(-3, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "รย.2 : รถยนต์นั่งส่วนบุคคลเกิน 7 คน";
            // 
            // YYTextBox
            // 
            this.YYTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.YYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YYTextBox.Location = new System.Drawing.Point(61, 226);
            this.YYTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YYTextBox.Name = "YYTextBox";
            this.YYTextBox.Size = new System.Drawing.Size(344, 45);
            this.YYTextBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(62, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 46);
            this.label3.TabIndex = 32;
            this.label3.Text = "ปีที่จดทะเบียน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(262, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "กรุณากรอกปีคริสต์ศักราช";
            // 
            // VANCarcalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(996, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mainbutton);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "VANCarcalcForm";
            this.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VANCarcalcForm";
            this.Load += new System.EventHandler(this.VANCarcalcForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DDTimePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KgTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LicenseplateTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GasRadioButton;
        private System.Windows.Forms.RadioButton NolmalRadioButton;
        private System.Windows.Forms.Button Mainbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YYTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
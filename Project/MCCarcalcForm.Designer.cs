namespace Project
{
    partial class MCCarcalcForm
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
            this.DDTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LicenseplateTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CCTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Mainbutton = new System.Windows.Forms.Button();
            this.YYTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "รย.12 : รถจักรยานยนต์ \n";
            // 
            // DDTimePicker
            // 
            this.DDTimePicker.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDTimePicker.Location = new System.Drawing.Point(28, 329);
            this.DDTimePicker.Name = "DDTimePicker";
            this.DDTimePicker.Size = new System.Drawing.Size(253, 47);
            this.DDTimePicker.TabIndex = 25;
            this.DDTimePicker.ValueChanged += new System.EventHandler(this.DDTimePicker_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.YYTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LicenseplateTextbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.DDTimePicker);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CCTextbox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(300, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 449);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LicenseplateTextbox
            // 
            this.LicenseplateTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.LicenseplateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseplateTextbox.Location = new System.Drawing.Point(28, 73);
            this.LicenseplateTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.LicenseplateTextbox.Name = "LicenseplateTextbox";
            this.LicenseplateTextbox.Size = new System.Drawing.Size(237, 45);
            this.LicenseplateTextbox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 46);
            this.label4.TabIndex = 29;
            this.label4.Text = "เลขทะเบียน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(21, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "วันสิ้นภาษี";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CCTextbox
            // 
            this.CCTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.CCTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCTextbox.Location = new System.Drawing.Point(28, 151);
            this.CCTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CCTextbox.Name = "CCTextbox";
            this.CCTextbox.Size = new System.Drawing.Size(343, 41);
            this.CCTextbox.TabIndex = 9;
            this.CCTextbox.TextChanged += new System.EventHandler(this.CCTextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(137, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "คำนวน";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "เครื่องยนต์ (cc) *";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Mainbutton
            // 
            this.Mainbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Mainbutton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Mainbutton.Location = new System.Drawing.Point(12, 541);
            this.Mainbutton.Name = "Mainbutton";
            this.Mainbutton.Size = new System.Drawing.Size(142, 49);
            this.Mainbutton.TabIndex = 33;
            this.Mainbutton.Text = "ย้อนกลับ";
            this.Mainbutton.UseVisualStyleBackColor = false;
            this.Mainbutton.Click += new System.EventHandler(this.Mainbutton_Click);
            // 
            // YYTextBox
            // 
            this.YYTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(246)))));
            this.YYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YYTextBox.Location = new System.Drawing.Point(27, 232);
            this.YYTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.YYTextBox.Name = "YYTextBox";
            this.YYTextBox.Size = new System.Drawing.Size(344, 45);
            this.YYTextBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(28, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 46);
            this.label3.TabIndex = 34;
            this.label3.Text = "ปีที่จดทะเบียน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(221, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "กรุณากรอกปีคริสต์ศักราช";
            // 
            // MCCarcalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Screenshot_2024_09_24_2158161;
            this.ClientSize = new System.Drawing.Size(996, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mainbutton);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MCCarcalcForm";
            this.Text = "MCCarcalcForm";
            this.Load += new System.EventHandler(this.MCCarcalcForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DDTimePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CCTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LicenseplateTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Mainbutton;
        private System.Windows.Forms.TextBox YYTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            RegistrationForm s = new RegistrationForm();
            s.Show();

           
            

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (UserTextBox.Text == "")// Radio dy[ 1cheak ต้องเป็นสีใส ต้องเขียนเรียงลำดับ
            {
                status = false;
                UserTextBox.BackColor = Color.Red; // ถ้าชื่อไม่ได้กรอก ในNameTextBox ให้ตัวแปรเป็นเท็จ แบล็คกราวเปลี่ยนสี
            }
            if (PasswordTextBox.Text == "")
            {
                status = false;
                PasswordTextBox.BackColor = Color.Red;
            }


            if (!status)
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้และรหัสผ่าน"); // แจ้งเตือนผู้ใช้
                return; // หยุดการทำงาน
            }
            bool checkstate = false;
                for (int i = 0; i < Global.per.Rows.Count; i++)
                {
                    if (UserTextBox.Text == Global.per.Rows[i][0].ToString()
                        && PasswordTextBox.Text == Global.per.Rows[i][1].ToString())

                    {
                        Global.Username = Global.per.Rows[i]["ชื่อผู้ใช้"].ToString(); // สมมุติว่ามีคอลัมน์ชื่อ "ชื่อ"
                        checkstate = true; // สถานะของการล็อกอินเป็นจริง
                        break;
                    }
                }
                if (checkstate)
                {
                    MessageBox.Show(Global.Username);
                    this.DialogResult = DialogResult.OK;// ถ้า เจอ ชื่อมันจะชื่อว่าโอเคร ก่อนจะจบในการ login

                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
                }
        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            UserTextBox.BackColor = Color.White;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // ซ่อน TaxCalculationForm 
            foreach (Form form in Application.OpenForms) //// วนรอบดูทุกๆฟอร์มที่เปิดอยู่โปรแกรม
            {
                if (form is MainForm) //ดูว่าฟอร์มปัจจุบันในลูปมี MainForm หรือไม่
                {
                    form.Show(); // ถ้สเจอให้แสดง MainForm
                    break; // หยุดการทำงาน
                }
            }
        }
    }
}


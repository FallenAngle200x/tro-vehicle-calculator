using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
              
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (UsernameTextBox.Text == "")
            {
                status = false;
                UsernameTextBox.BackColor = Color.Red; 
            }
            if (PasswordTextbox.Text == "")
            {
                status = false;
                PasswordTextbox.BackColor = Color.Red;
            }
            
            if (NameTextBox.Text == "")
            {
                status = false;
                NameTextBox.BackColor = Color.Red;
            }
            if (SurnameTextBox.Text == "")
            {
                status = false;
                SurnameTextBox.BackColor = Color.Red;
            }
            
            if (MobileListBox.Items.Count == 0)
            {
                status = false;
                MobileListBox.BackColor = Color.Red;
            }
            if (IDTextBox.Text== "")
            {
                status = false;
                IDTextBox.BackColor = Color.Red;
            }

                if (!status)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
                return; 
            }
            
            if (!ID(IDTextBox.Text))
            {
                status = false;
                IDTextBox.BackColor = Color.Red;
                MessageBox.Show("หมายเลขบัตรประชาชนต้องมีความยาว 13 หลักและเป็นตัวเลขเท่านั้น");
                return;
            }

            Global.Username = UsernameTextBox.Text;
            Global.Password = PasswordTextbox.Text;
            Global.FirstName = NameTextBox.Text;
            Global.LastName = SurnameTextBox.Text;
            Global.id = IDTextBox.Text;
            Global.per.Rows.Add(Global.Username, Global.Password, Global.FirstName, Global.LastName, Global.id,Global.PhoneNumbers);
            
            this.Hide();
            Form.ActiveForm.Show(); // แสดงฟอร์มที่เปิดอยู่ (ฟอร์ม Login)
            this.Close();
            
        }


        private bool ID(string id)
        {
            // ตรวจสอบว่ามีความยาว 13 หลัก
            if (id.Length != 13)
            {
                return false; // ถ้าไม่ครบ 13 ตัว ถือว่าเป็นเท็จ
            }

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] < '0' || id[i] > '9')
                {
                    return false; //ต้องเป็นตัวอักษร
                }
            }

            return true; 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Global.PhoneNumbers.Add(MobileTextBox.Text);
            MobileListBox.Items.Add(MobileTextBox.Text);
             MobileTextBox.Text = "";// ถ้าใส่stringทำให้ข้อความที่ใส่ในช่องtextboxตบลงมาในช่องlistbox เหลือช่องเปล่าๆ
            MobileListBox.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MobileListBox.Items.RemoveAt(MobileTextBox.SelectionLength);
        }

        private void MobileListBox_DoubleClick(object sender, EventArgs e)
        {
            MobileListBox.Items.RemoveAt(MobileListBox.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลนี้", // การเช็กว่าต้องการลบจริงหรือไม่
                                "แจ้งเตือน",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                MobileListBox.Items.Clear();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UsernameTextBox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void MobileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobileListBox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextbox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextBox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SurnameTextBox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            IDTextBox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form.ActiveForm.Show(); // แสดงฟอร์มที่เปิดอยู่ (ฟอร์ม Login)
            this.Close();

        }
    }
}

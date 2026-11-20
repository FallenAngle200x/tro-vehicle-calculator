using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Reflection.Emit;
using Project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class ProfileDetails : Form
    {
        public ProfileDetails()
        {
            InitializeComponent();
            UsernameTextBox.Text = Global.Username;
            UsernameTextBox.ReadOnly = true;
            PasswordTextbox.Text = Global.Password;
            NameTextBox.Text = Global.FirstName;
            SurnameTextBox.Text= Global.LastName;
            IDTextBox.Text = Global.id;
            foreach (string phone in Global.PhoneNumbers)
            {
                MobileListBox.Items.Add(phone); // เพิ่มหมายเลขโทรศัพท์ใน ListBox
            }
            


        }
        private void DisplayUserInfo()
        {
            
           
        }



        private void ProfileDetails_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลนี้", // การเช็กว่าต้องการลบจริงหรือไม่
                                "แจ้งเตือน",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                MobileListBox.Items.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
                bool status = true;

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
            DialogResult dr = MessageBox.Show("คุณต้องการบันทึกข้อมูลนี้", // การเช็กว่าต้องการลบจริงหรือไม่
                            "แจ้งเตือน",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)

            {
                Global.FirstName = NameTextBox.Text;
                Global.LastName = SurnameTextBox.Text;
                Global.id = IDTextBox.Text;
                Global.PhoneNumbers.Clear();
                foreach (string phone in MobileListBox.Items)
                {
                    Global.PhoneNumbers.Add(phone); // เพิ่มหมายเลขโทรศัพท์ใน Global
                }
                Global.per.Rows.Clear();
                Global.per.Rows.Add(Global.Username, Global.Password, Global.FirstName, Global.LastName, Global.id, Global.PhoneNumbers);
                MessageBox.Show("ข้อมูลถูกบันทึกเรียบร้อยแล้ว");
            }

        }

        private void Mainbutton_Click(object sender, EventArgs e)
        {
            this.Hide(); // ซ่อน TaxCalculationForm 
            foreach (Form form in Application.OpenForms) //// วนรอบดูทุกๆฟอร์มที่เปิดอยู่โปรแกรม
            {
                if (form is MainForm) //ดูว่าฟอร์มปัจจุบันในลูปมี MainForm หรือไม่
                {
                    form.Show();// ถ้สเจอให้แสดง MainForm
                    break; // หยุดการทำงาน
                }
            }

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

    }
}

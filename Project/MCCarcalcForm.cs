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
    public partial class MCCarcalcForm : Form
    {
        public MCCarcalcForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MCCarcalcForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (CCTextbox.Text == "")
            {
                status = false;
                CCTextbox.BackColor = Color.Red;
            }
            if (LicenseplateTextbox.Text == "")
            {
                status = false;
                LicenseplateTextbox.BackColor = Color.Red;
            }
            if (!status)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
                return;
            }
            string registrationNumber = LicenseplateTextbox.Text;
            double cc = Convert.ToDouble(CCTextbox.Text);
            DateTime dateTime = DDTimePicker.Value;

            double register = Convert.ToDouble(YYTextBox.Text);
            double currentYear = DateTime.Now.Year;
            double carage = currentYear - register;

            if (carage >= 5) // รถมีอายุครบ 5 ปีขึ้นไป
            {
                Global.inspectionFee = 60; // ค่าตรวจสภาพ
                MessageBox.Show("รถจักรยานยนต์มีอายุครบ 5 ปี ต้องตรวจสภาพ!");
            }
            else
            {
                Global.inspectionFee = 0; // ถ้าน้อยกว่า 5 ปี ไม่ต้องเก็บค่าตรวจสภาพ
                MessageBox.Show("รถจักรยานยนต์มีอายุน้อยกว่า 5 ปี ไม่ต้องตรวจสภาพ");
            }

            Global.registrationNumber = registrationNumber;
            Global.vehicleType = "รย.12";
            Global.mc = 100;
            Global.insuranceFee = CalculateInsuranceFee(cc); // ค่าพรบ.
            Global.totalTax = Global.mc + Global.inspectionFee + Global.insuranceFee;

            bool isLPGRadio = false; //ไม่่มีradio
            TaxCalculationForm s = new TaxCalculationForm(isLPGRadio);
            s.Show();
            this.Hide();



        }
        private double CalculateInsuranceFee(double cc)
        {
            double prb = 0;
            if (cc <= 75)
            {
                prb = 161.57;
            }
            else if (cc > 75 && cc <= 125)
            {
                prb = 323.14; // สำหรับ 601 - 1800 ซีซี
            }
            else if (cc > 125 && cc <= 150)
            {
                prb = 430.14; // สำหรับเกิน 1800 ซีซี
            }
            else
            {
                prb = 645.21;
            }
            return prb;


        }

        private void CCTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DDTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mainbutton_Click(object sender, EventArgs e)
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

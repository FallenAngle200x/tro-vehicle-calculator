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
    public partial class VANCarcalcForm : Form
    {

        public VANCarcalcForm()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = true;
            double gasFee = 0;
            if (GasRadioButton.Checked)
            {
                gasFee = 500;
            }
            else if (NolmalRadioButton.Checked)
            {
                gasFee = 0;
            }
            else
            {
                status = false;
                NolmalRadioButton.BackColor = Color.Red;
                GasRadioButton.BackColor = Color.Red;
            }

            if (LicenseplateTextbox.Text == "")
            {
                status = false;
                LicenseplateTextbox.BackColor = Color.Red;
            }
            if (KgTextbox.Text == "")
            {
                status = false;
                KgTextbox.BackColor = Color.Red;
            
                

            }
            string registrationNumber = LicenseplateTextbox.Text;
            double kg = Convert.ToDouble(KgTextbox.Text);
            DateTime dateTime = DDTimePicker.Value;
            
            double register = Convert.ToDouble(YYTextBox.Text);
            double currentYear = DateTime.Now.Year;
            double carage = currentYear - register;


            if (carage >= 7) // ถ้ารถมีอายุครบ 7 ปีขึ้นไป
            {
                Global.inspectionFee = CalculateTro(kg); // ค่าตรวจสภาพ
            }
            else
            {
                Global.inspectionFee = 0; // ถ้าน้อยกว่า 7 ปี ไม่ต้องเก็บค่าตรวจสภาพ
                MessageBox.Show("รถยนต์นั่งส่วนบุคคลไม่เกิน 7 คน มีอายุไม่ถึง 7 ปี ไม่ต้องตรวจสภาพ");
            }
            if (!status)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
                return;
            }



            Global.registrationNumber = registrationNumber;
            Global.vehicleType = "รย.2";
            Global.van = CalculateTax(kg);
            Global.insuranceFee = 1182.35; // ค่าพรบ.
            Global.totalTax = Global.van + Global.inspectionFee + Global.insuranceFee + gasFee;
            

            TaxCalculationForm s = new TaxCalculationForm(GasRadioButton.Checked);
            s.Show();
            this.Hide();
        }
        private double CalculateTax(double kg)
        {
            double tax = 0;
            if (kg <= 1800)
            {
                tax = 1300; // น้ำหนักไม่เกิน 1,800 กก.
            }
            else
            {
                tax = 1600; // น้ำหนักเกิน 1,800 กก.
            }
            return tax;
        }
        private double CalculateTro(double kg)
        {
            double tro = 0;
            if (kg <= 2000)
            {
              tro = 200; // ถ้าไม่เกิน 2000 kg 200 บาท
            }
            else
            {
              tro = 300; // ค่าตรวจสภาพสำหรับน้ำหนักเกิน 2,000 กก.
            }

            return tro;
        }

        private void VANCarcalcForm_Load(object sender, EventArgs e)
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

        private void LicenseplateTextbox_TextChanged(object sender, EventArgs e)
        {
            LicenseplateTextbox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void KgTextbox_TextChanged(object sender, EventArgs e)
        {
            KgTextbox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void NolmalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NolmalRadioButton.BackColor = Color.Transparent;
            GasRadioButton.BackColor = Color.Transparent;
        }

        private void GasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NolmalRadioButton.BackColor = Color.Transparent;
            GasRadioButton.BackColor = Color.Transparent;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            GasCylinderExpiryForm f = new GasCylinderExpiryForm();
            f.ShowDialog(); 
            
        }
    }
}

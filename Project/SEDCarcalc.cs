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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project
{
    public partial class SEDCarcalc : Form
    {
        public SEDCarcalc()
        {
            InitializeComponent();
        }

        private void SEDCarcalc_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            YYTextBox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void button1_Click_1(object sender, EventArgs e)
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

                if (LicenseplateTextbox.Text == "")
            {
                status = false;
                LicenseplateTextbox.BackColor = Color.Red;
            }
            if (CCTextbox.Text == "" )
            {
                status = false;
                CCTextbox.BackColor = Color.Red;
            }
            if (YYTextBox.Text == "")
            {
                status = false;
                YYTextBox.BackColor = Color.Red;
            }
                
                if (!status)
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
                    return;
                }
            
            }
            string registrationNumber = LicenseplateTextbox.Text;//ใส่ทะเบียนรถ
            double cc = Convert.ToDouble(CCTextbox.Text);
            double register = Convert.ToDouble(YYTextBox.Text);




            DateTime dateTime = DDTimePicker.Value;

            double currentYear = DateTime.Now.Year;
            double carage = currentYear - register;


            if (carage >= 7) // ถ้ารถมีอายุครบ 7 ปีขึ้นไป
            {
                
                Global.inspectionFee = 200; // ค่าตรวจสภาพ
            }
            else
            {
                Global.inspectionFee = 0; // ถ้าน้อยกว่า 7 ปี ไม่ต้องเก็บค่าตรวจสภาพ
                MessageBox.Show("รถยนต์นั่งส่วนบุคคลไม่เกิน 7 คน มีอายุไม่ถึง 7 ปี ยังไม่ต้องตรวจสภาพ");
            }

            double carageForTax = currentYear - register + 1;
            if (carageForTax > 5) // สำหรับภาษี
            {
                double discount = GetDiscount(carageForTax - 5);
                Global.car -= Global.car * discount;
            }

            Global.vehicleType = "รย.1";
            Global.registrationNumber = registrationNumber;
            Global.insuranceFee = 645.21; // ค่าพรบ.
            Global.car = CalculateTax(cc);

            Global.totalTax = Global.car + Global.inspectionFee + Global.insuranceFee + gasFee;
            
            TaxCalculationForm s = new TaxCalculationForm(GasRadioButton.Checked);
            s.Show();
            this.Hide();

        }
        private double GetDiscount(double yearsOverFive) // การใช้ double เพื่อให้สามารถคืนค่าทศนิยม
        {
            if (yearsOverFive < 1)
                return 0; // ถ้ายังไม่ถึง 6 ปี ไม่มีส่วนลด
         
            return Math.Min(yearsOverFive * 0.10, 0.50); // คำนวนส่วนลด ปีที่ 1 (ปีที่ 6) ลด 0.10%
        }
        private double CalculateTax(double cc)
        {
            double tax = 0;
            if (cc <= 600)
            {
                tax = cc * 0.50; // สำหรับ 600 ซีซีแรก
            }
            else if (cc <= 1800)
            {
                tax = 300 + (cc - 600) * 1.50; // สำหรับ 601 - 1800 ซีซี
            }
            else
            {
                tax = 300 + (1200 * 1.50) + ((cc - 1800) * 4); // สำหรับเกิน 1800 ซีซี
            }
            return tax;


        }

        private void DDTimePicker_ValueChanged(object sender, EventArgs e)
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

        private void CCTextbox_TextChanged(object sender, EventArgs e)
        {
            CCTextbox.BackColor = Color.FromArgb(221, 226, 246);
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

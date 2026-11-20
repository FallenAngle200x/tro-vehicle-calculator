using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class PUCarcalcForm : Form
    {
        public PUCarcalcForm()
        {
            InitializeComponent();
        }

        private void PUCarcalcForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = true;
            double gasFee = 0; // ค่าธรรมเนียมก๊าซ

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
            if (KgTextBox.Text == "")
                {
                    status = false;
                    KgTextBox.BackColor = Color.Red;
            if (!status)
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
                    return;
                }

            }
            string registrationNumber = LicenseplateTextbox.Text;
            double kg = Convert.ToDouble(KgTextBox.Text);
            DateTime dt = DDTimePicker.Value;
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
                MessageBox.Show("รถยนต์มีอายุไม่ถึง 7 ปี ยังไม่ต้องตรวจสภาพ");
            }

            Global.registrationNumber = registrationNumber;
            Global.vehicleType = "รย.3";
            Global.pu = CalculateTax(kg);
            Global.insuranceFee = 967.28; // ค่าพรบ.
            Global.totalTax = Global.pu + Global.inspectionFee + Global.insuranceFee + gasFee;



            TaxCalculationForm s = new TaxCalculationForm(GasRadioButton.Checked);
            s.Show();
            this.Hide();

        }
        private double CalculateTax(double kg)
        {
            double tax = 0;
            if (kg <= 500)
            {
                tax = 300; // น้ำหนัก 0-500 กก.
            }
            else if (kg >= 501 && kg <= 750)
            {
                tax = 450;
            }
            else if (kg >= 751 && kg <= 1000)
            {
                tax = 600;
            }
            else if (kg >= 1001 && kg <= 1250)
            {
                tax = 750;
            }
            else if (kg >= 1251 && kg <= 1500)
            {
                tax = 900;
            }
            else if (kg >= 1501 && kg <= 1750)
            {
                tax = 1050;
            }
            else if (kg >= 1751 && kg <= 2000)
            {
                tax = 1350;
            }
            else if (kg >= 2001 && kg <= 2500)
            {
                tax = 1650;
            }
            else if (kg >= 2501 && kg <= 3000)
            {
                tax = 1950;
            }
            return tax;

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

        private void GasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NolmalRadioButton.BackColor = Color.Transparent;
            GasRadioButton.BackColor = Color.Transparent;
        }

        private void NolmalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NolmalRadioButton.BackColor = Color.Transparent;
            GasRadioButton.BackColor = Color.Transparent;
        }

        private void LicenseplateTextbox_TextChanged(object sender, EventArgs e)
        {
            LicenseplateTextbox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void KgTextBox_TextChanged(object sender, EventArgs e)
        {
            KgTextBox.BackColor = Color.FromArgb(221, 226, 246);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            GasCylinderExpiryForm f = new GasCylinderExpiryForm();
            f.ShowDialog();
        }
    }
}

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
    public partial class TaxCalculationForm : Form
    {

        public TaxCalculationForm(bool isLPGRadio)
        {
            InitializeComponent();
            ShowTaxCalculation(isLPGRadio);

        }

        private void TaxCalculationForm_Load(object sender, EventArgs e)
        {
            


        }
        private void ShowTaxCalculation(bool isLPGRadio)
        {
            double tax = 0;
            double gasFee = isLPGRadio ? 500 : 0;
            // ตรวจสอบค่าภาษีตามประเภทของรถ
            if (Global.car > 0)
            {
                tax = Global.car; // รถยนต์นั่งส่วนบุคคล
            }
            else if (Global.pu > 0)
            {
                tax = Global.pu; // รถกระบะ
            }
            else if (Global.van > 0)
            {
                tax = Global.van; // รถตู้
            }
            else if (Global.mc > 0)
            {
                tax = Global.mc; // รถมอเตอร์ไซค์
            }
            TaxcalTextbox.Text = tax.ToString("N2");
            GasTextBox.Text = gasFee.ToString("N2");
            VehicleTypeTextBox.Text = Global.vehicleType;
            LicenseTextBox.Text = Global.registrationNumber.ToString(); // โชว์ทะเบียน
            TroTaxtBox.Text += Global.inspectionFee.ToString("N2"); // โชว์ค่าตรอ
            PRBTextBox.Text += Global.insuranceFee.ToString("N2"); // โชว์ค่า พรบ.
            SumtaxTextBox.Text = (Global.totalTax).ToString();
            // ตรอ+พรบ+ภาษี

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

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (!Global.signInStatus)
            {
                MessageBox.Show("กรุณาเข้าสู่ระบบ");
                return; // หยุดการทำงานหากยังไม่ได้เข้าสู่ระบบ
            }
            Global.ts.Rows.Add(
            Global.registrationNumber,
            Global.vehicleType, // รย.
            Global.inspectionFee.ToString("N2"),//ตรอ
            Global.insuranceFee.ToString("N2"), //พรบ
            GasTextBox.Text, // ค่าธรรมเนียมแก๊ส
            TaxcalTextbox.Text, // ค่าภาษี
            SumtaxTextBox.Text, // ราคารวม
            DateTime.Now.AddYears(1).ToString("dd/MM/yyyy"));

            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
        }

        private void SumtaxTextBox_TextChanged(object sender, EventArgs e)
        {
            SumtaxTextBox.Text = (Global.totalTax).ToString();
        }
    }
}
//this.Hide() ถ้้าจะกลับไผป ฟอร์มเดิม โดยไม่ต้องสร้างฟอร์มใหม่อีกครั้ง เช่น เมื่อกลับไปที่หน้าเมนหลัก
//this.Close() สิ้นสุดการทำงานของฟอร์มและไม่ต้องการกลับไปใน ฟอร์มอีก เช่น เมื่อผู้ใช้ออกจากโปรแกรม

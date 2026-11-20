using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class calculationprogram : Form
    {
        public calculationprogram()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // ซ่อน TaxCalculationForm 
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

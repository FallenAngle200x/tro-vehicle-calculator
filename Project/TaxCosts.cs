using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.IO;


namespace Project
{
    public partial class TaxCosts : Form
    {
        int index = -1;
        public TaxCosts()
        {
            InitializeComponent();
            dataGridView1.DataSource = Global.ts;
            Refreshgrid();
        }
        void Refreshgrid()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersHeight = 10;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Height = 20;
        }

        private void TaxCosts_Load(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            LicenseplateTextbox.Text = Global.ts.Rows[e.RowIndex]["เลขทะเบียน"].ToString();
            RYTextBox.Text = Global.ts.Rows[e.RowIndex]["รย."].ToString();
            TroTextBox.Text = Global.ts.Rows[e.RowIndex]["ตรอ"].ToString();
            PRBTextBox.Text = Global.ts.Rows[e.RowIndex]["พรบ"].ToString();
            GasTextBox.Text = Global.ts.Rows[e.RowIndex]["LPG/NGV"].ToString();
            TaxTextBox.Text = Global.ts.Rows[e.RowIndex]["ภาษี"].ToString();
            SumTaxTextBox.Text = Global.ts.Rows[e.RowIndex]["ราคารวม"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(Global.ts.Rows[e.RowIndex]["วันสิ้นภาษีอายุต่อไป"]);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลนี้", // การเช็กว่าต้องการลบจริงหรือไม่
                                "แจ้งเตือน",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Global.ts.Rows.RemoveAt(index);
                LicenseplateTextbox.Text = ""; // หลังจากพิมเสน็จการใส่ sting จำทำให้ข้อมูลหาย หรือการเคียร์ข้อมูล
                RYTextBox.Text = "";
                TroTextBox.Text = "";
                PRBTextBox.Text = "";
                GasTextBox.Text = "";
                TaxTextBox.Text = "";
                SumTaxTextBox.Text = "";
                dateTimePicker1.Checked = false;
                dataGridView1.DataSource = Global.ts; //อัปเดตตารางอีกรอบ ข้อมูลของผู้ใช้งานจะหายไป
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Global.ts.Rows[index]["เลขทะเบียน"] = LicenseplateTextbox.Text;
            Global.ts.Rows[index]["รย."] = RYTextBox.Text;
            Global.ts.Rows[index]["ตรอ"] = TroTextBox.Text;
            Global.ts.Rows[index]["พรบ"] = PRBTextBox.Text;
            Global.ts.Rows[index]["LPG/NGV"] = GasTextBox.Text;
            Global.ts.Rows[index]["ภาษี"] = TaxTextBox.Text;
            Global.ts.Rows[index]["ราคารวม"] = SumTaxTextBox.Text;
            DateTime ps = dateTimePicker1.Value;
            Global.ts.Rows[index]["วันสิ้นภาษีอายุต่อไป"] = ps.ToString("dd/MM/yyyy", new System.Globalization.CultureInfo("th-TH")); //new System.Globalization.CultureInfo("th-TH")) ทำให้ datetime เป็น พศ.
            dataGridView1.DataSource = Global.ts;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string s = SearchTextBox.Text;
            if (s == "") 
                dataGridView1.DataSource =Global.ts;
            else
            {
                for (int i = 0; i < Global.ts.Rows.Count; i++)
                {
                    if (s == Global.ts.Rows[i]["เลขทะเบียน"].ToString())
                    {
                        Global.ts2.Rows.Add(
                            Global.ts.Rows[i]["เลขทะเบียน"].ToString(),
                            Global.ts.Rows[i]["รย."].ToString(),
                            Global.ts.Rows[i]["ตรอ"].ToString(),
                            Global.ts.Rows[i]["พรบ"].ToString(),
                            Global.ts.Rows[i]["LPG/NGV"].ToString(),
                            Global.ts.Rows[i]["ภาษี"].ToString(),
                            Global.ts.Rows[i]["ราคารวม"].ToString(),
                            Global.ts.Rows[i]["วันสิ้นภาษีอายุต่อไป"].ToString());

                    }
                }
                dataGridView1.DataSource = Global.ts2;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            SaveFileDialog of = new SaveFileDialog();
            of.Title = "Employee Import";
            of.FileName = "Text File(*.txt)|All files(*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                while (sr.Peek() > -1)
                {
                    try
                    {
                        string[] s = sr.ReadLine().Split(',');
                        Global.ts.Rows.Add(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7]);


                    }
                    catch
                    {
                        MessageBox.Show("ข้อมูลมีปัญหา");
                    }
                }
                sr.Close();
            }    }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Employee Export";
            sf.FileName = "Text File(*.txt)|All files(*.*)|*.*"; //(*.txt)ความหมายของ * หมายถึงข้างหน้าจะชื่ออะไรก็ได้ แต่ต้องลงท้ายด้วย, All files(*.*) ชื่ออะไรก็ได้ นามสกุลอะไรก็ได้ 
            sf.FileName = "Untile.txt";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(File.Open(sf.FileName, FileMode.Create), Encoding.UTF8); //การเปิดไฟล์
                for (int i = 0; i < Global.ts.Rows.Count; i++)
                {
                    sw.WriteLine(Global.ts.Rows[i]["เลขทะเบียน"] + "," +
                                 Global.ts.Rows[i]["รย."] + "," +
                                 Global.ts.Rows[i]["ตรอ"] + "," +
                                 Global.ts.Rows[i]["พรบ"] + "," +
                                 Global.ts.Rows[i]["LPG/NGV"] + "," +
                                 Global.ts.Rows[i]["ภาษี"] + "," +
                                 Global.ts.Rows[i]["ราคารวม"] + "," +
                                 Global.ts.Rows[i]["วันสิ้นภาษีอายุต่อไป"]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainForm) 
                {
                    form.Show(); 
                    break; 
                }
            }
        }
    }
}

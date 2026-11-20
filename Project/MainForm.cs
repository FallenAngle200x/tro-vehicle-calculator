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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();


            Global.ts.Columns.Add("เลขทะเบียน", typeof(string));
            Global.ts.Columns.Add("รย.", typeof(string));
            Global.ts.Columns.Add("ตรอ", typeof(string));
            Global.ts.Columns.Add("พรบ", typeof(string));
            Global.ts.Columns.Add("LPG/NGV",typeof(string));
            Global.ts.Columns.Add("ภาษี", typeof(string));
            Global.ts.Columns.Add("ราคารวม", typeof(string));
            Global.ts.Columns.Add("วันสิ้นภาษีอายุต่อไป", typeof(string));
            Global.ts.Rows.Add("2กม 2816", "รย.1", "200.00", "645.21", "500.00", "2018.21","3451.21", "30/9/2568");
            Global.ts.Rows.Add("บม 4251", "รย.3", "200.00", "967.21", "500.00", "2561.21","5421.86", "14/10/2568");

            Global.ts2.Columns.Add("เลขทะเบียน", typeof(string));
            Global.ts2.Columns.Add("รย.", typeof(string));
            Global.ts2.Columns.Add("ตรอ", typeof(string));
            Global.ts2.Columns.Add("พรบ", typeof(string));
            Global.ts2.Columns.Add("LPG/NGV", typeof(string));
            Global.ts2.Columns.Add("ภาษี", typeof(string));
            Global.ts2.Columns.Add("ราคารวม", typeof(string));
            Global.ts2.Columns.Add("วันสิ้นภาษีอายุต่อไป", typeof(string));
            


            Global.per.Columns.Add("ชื่อผู้ใช้", typeof(string));
            Global.per.Columns.Add("รหัสผ่าน", typeof(string));
            Global.per.Columns.Add("ชื่อ", typeof(string));
            Global.per.Columns.Add("นามสกุล", typeof(string));
            Global.per.Columns.Add("หมายเลขบัตรประชาชน", typeof(string));
            Global.per.Columns.Add("เบอร์โทรศัพท์", typeof(string));
            Global.per.Rows.Add("A", "1234", "นับอนันต์", "ซอเซ็น", "1234567890123", "0630990818");
            Global.per.Rows.Add("b", "1111", "นิจนิรันด์", "ซอเซ็น", "2345678901234", "0813425158");

           
            
            
        }

        
        private void customizeDesing()
        {
            panelVRSubmenu.Visible = false;
            panelGVBSubmenu.Visible = false;

        }
        private void hideSubmenu()
        {
            if (panelVRSubmenu.Visible == true) 
                panelVRSubmenu.Visible=false;
            if (panelGVBSubmenu.Visible == true)
                panelGVBSubmenu.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else 
                subMenu.Visible = false;
        }
        

        private void Carcalcbutton_Click(object sender, EventArgs e)
        {
            showSubmenu(panelVRSubmenu);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            SEDCarcalc s = new SEDCarcalc();
            hideSubmenu();
            this.Hide();
            s.ShowDialog();
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            VANCarcalcForm s = new VANCarcalcForm();
            s.Show();
            hideSubmenu();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PUCarcalcForm s = new PUCarcalcForm();
            s.Show();
            hideSubmenu();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MCCarcalcForm s = new MCCarcalcForm();
            s.Show();
            hideSubmenu();
            this.Hide();
        }

        private void GeneralVehicleButton_Click(object sender, EventArgs e)
        {
            showSubmenu(panelGVBSubmenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!Global.signInStatus)
            {
                MessageBox.Show("กรุณาเข้าสู่ระบบ");
                return; // หยุดการทำงานหากยังไม่ได้เข้าสู่ระบบ
            }
            TaxCosts t = new TaxCosts();
            t.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!Global.signInStatus)
            {
                MessageBox.Show("กรุณาเข้าสู่ระบบ");
                return; // หยุดการทำงานหากยังไม่ได้เข้าสู่ระบบ
            }
            ProfileDetails p = new ProfileDetails();
            p.Show();
            this.Hide();
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                panelSideMenu.Width -= 20;
                if(panelSideMenu.Width <= 56)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                panelSideMenu.Width += 10;
                if (panelSideMenu.Width >=237)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        

        private void Menubutton_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculationprogram c = new calculationprogram();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

            
            if (Global.signInStatus)
            {
                nameLabel.Text = "";
                Loginbutton.Text = "เช้าสู่ระบบ";
                Global.signInStatus = false;
            }
            else
            {
                LoginForm f = new LoginForm();  
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    nameLabel.Text = Global.Username;
                    Loginbutton.Text = "ออกจากระบบ";
                    Global.signInStatus = true;
                }
            }

        }
       




    }
}

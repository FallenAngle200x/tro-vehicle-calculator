using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Global
    {
        public static DataTable cc = new DataTable();
        public static DataTable ts = new DataTable(); // แสดงค่าใช้จ่ายในการต่อภาษี
        public static DataTable ts2 = new DataTable();
        public static DataTable per = new DataTable(); // แสดงข้อมูลผู้ใช้งาน
        public static bool signInStatus = false;
       


        

        public static double car; // รถยนต์ รย.1
        public static double pu; // รถยนต์ รย.3
        public static double van; // รถยนต์ รย.2
        public static double mc; // รถจักรยานยนน์ รย.12

        public static double inspectionFee; // ค่าตรวจสภาพ
        public static double insuranceFee;   // ค่าพรบ.
        public static double totalTax; //ภาษีรวม หมายถึง ภาษี
        public static string vehicleType; //เก็บ รย.

        public static string Username = "";
        public static string Password;
        public static string FirstName;
        public static string id;
        public static string LastName;
        public static List<string> PhoneNumbers = new List<string>();
        


        public static string registrationNumber;




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_Method_MoiveTicket
{
    public partial class Form1 : Form
    {
        double A;//กำหนดค่าตัวแปร
        double B;
        double C;
        public Form1()
        {
            InitializeComponent();

        }
        //นาย นพัทธ์ ศรีจันทพงศ์ รหัสประจำตัว 593410051-4
        private void button1_Click(object sender, EventArgs e)//เมื่อทำการกดปุ่ม button1 
        {
            
            try//ดักError
            {
                textBox2.Text = textBox1.Text;//จะเป็นการแสดงชื่อ โดยให้รับtextbox1 และเมื่อกดButton1 จะไปแสดงใน Textbox2 
                Moive();//Method ชื่อหนัง
                Time();//Method รอบฉายหนัง
                Seat();//Method ที่นั่ง
                double M = double.Parse(textBox6.Text);//รับค่าจำนวนที่นั่งมากำหนดตัวแปรให้เป็น M
                Calculator(M);//รับMethod คำนวณที่นั่งมาแล้วมาหาด้วยค่าตัวแปร M
            }
            catch//จับตวError โดยที่ให้แสดง
            {
            }
            if (label15.Text == "" || label16.Text == "" || label17.Text == "" ||label18.Text == ""|| textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" )//ถ้าแต่ล่ะTextBox เป็นช่องว่างให้แสดงว่าMessageBox กรอกข้อมูลให้ถูกต้อง
            {
                MessageBox.Show("โปรดใส่ข้อมูลให้ถูกต้อง");
            }           
        }
        private void Moive()//Method หนัง โดยให้ textBox3 = ComboBox1
        {
            textBox3.Text = comboBox1.Text;
        }
        private void Time()//Method เวลาฉาย โดยให้ textBox4 = ComboBox2
        {
            textBox4.Text = comboBox2.Text;
        }
        private void Seat()//Method ที่นั่ง โดยให้ textbox5 = ComboBox3
        {
            textBox5.Text = comboBox3.Text;
        }
        private void Calculator(double x)//Method คำนวณ 
        {
            if (radioButton1.Checked)//ถ้ากดเลือกว่าเป็นสมาชิกจะได้รับส่วนลด
            {
                switch (comboBox3.SelectedIndex)//ComboBox3 แสดงที่นั่ง
                {
                    case 0: A = x * 160; B = 30 * x; C = A - B; break;//ถ้าเลิอกที่นั่ง A-C จะขึ้นสถานะเป็น Yes ใน label15 เป็นราคา160 ส่วนลด30แล้วไปแสดงใน label16 label17 label18
                    case 1: A = x * 160; B = 30 * x; C = A - B; break;
                    case 2: A = x * 160; B = 30 * x; C = A - B; break;
                    case 3: A = x * 130; B = 20 * x; C = A - B; break;//ถ้าเลิอกที่นั่ง D-E จะขึ้นสถานะเป็น Yes ใน label15 เป็นราคา130 ส่วนลด20แล้วไปแสดงใน label16 label17 label18
                    case 4: A = x * 130; B = 20 * x; C = A - B; break;
                    case 5: A = x * 100; B = 10 * x; C = A - B; break;//ถ้าเลิอกที่นั่ง F-G จะขึ้นสถานะเป็น Yes ใน label15 เป็นราคา100 ส่วนลด10แล้วไปแสดงใน label16 label17 label18
                    case 6: A = x * 100; B = 10 * x; C = A - B; break;
                }
                label16.Text = A.ToString() + "   " + "บาท";
                label17.Text = B.ToString() + "   " + "บาท";
                label18.Text = C.ToString() + "   " + "บาท";
                label15.Text = "Yes";
            }
            if (radioButton2.Checked)//ถ้ากดเลือกว่าไม่เป็นสมาชิกจะได้ราคาบัตรเท่าเดิม
            {
                switch (comboBox3.SelectedIndex)//ComboBox3 แสดงที่นั่ง
                {
                    case 0: A = x * 160; label17.Text = "0  "+"บาท"; break;//ที่นั้ง A-C จะราคา160 และ label17 จะแสดง 0 บาท
                    case 1: A = x * 160; label17.Text = "0  "+"บาท"; break;
                    case 2: A = x * 160; label17.Text = "0  "+"บาท"; break;
                    case 3: A = x * 130; label17.Text = "0  "+"บาท"; break;//ที่นั้ง D-E จะราคา130 และ label17 จะแสดง 0 บาท
                    case 4: A = x * 130; label17.Text = "0  "+"บาท"; break;
                    case 5: A = x * 100; label17.Text = "0  "+"บาท"; break;//ที่นั้ง F-G จะราคา100 และ label17 จะแสดง 0 บาท
                    case 6: A = x * 100; label17.Text = "0  "+"บาท"; break;
                }
                label16.Text = A.ToString() + "   "+"บาท";
                label18.Text = A.ToString() + "   "+"บาท";
                label15.Text = "No";//แสดงสถานะNo
            }     
        }

        private void button2_Click(object sender, EventArgs e)//เมื่อกดยืนยันการจอง
        {
            DialogResult x;//กำหนดค่าผลลัพธ์ตัวแปรเป็น x
            x = MessageBox.Show("คุณต้องการจองหนัง", "ตรวจสอบ", MessageBoxButtons.YesNo);//กำหนดค่าผลลัพธ์ตัวแปรเป็น x
            if (x == DialogResult.Yes)//ถ้ากด YesจะแสดงMessageBox
            {
                MessageBox.Show("คุณ " + textBox2.Text +"\r\n" +"หนังเรื่อง:" + textBox3.Text +"\r\n"+ "ในราคา:" + label18.Text +"\r\n"+ "ที่นั่ง:" + textBox5.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)//เมื่อกดยกเลิกการจอง
        {
            DialogResult x;//กำหนดค่าผลลัพธ์ตัวแปรเป็น x
            x = MessageBox.Show("คุณไม่ต้องการจองหนัง", "ตราวจสอบ", MessageBoxButtons.YesNo);//กำหนดค่าผลลัพธ์ตัวแปรเป็น x
            if (x == DialogResult.Yes)//ถ้ากด YesจะแสดงMessageBoxจะทำการปิดโปรแกรม
            {
                this.Close();
            }
        }
    }
}

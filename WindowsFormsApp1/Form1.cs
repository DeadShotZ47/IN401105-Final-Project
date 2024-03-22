using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private int currentCount1 = 0;   //ข้าวหมูย่าง
        private int currentCount2 = 0;   //ข้าวไก่ย่าง
        private int currentCount3 = 0;   //ข้าวกะเพราทะเล
        private int currentCount4 = 0;   //ข้าวพริกเผาทะเล
        private int currentCount5 = 0;   //ข้าวหมูทอดกระเทียม
        private int currentCount6 = 0;   //ข้าวไก่ทอดกระเทียม
        
        public Form1()
        {   
            InitializeComponent();
            ShowMaterial();
        }
        Menu1 menu = new Menu1();
        //แสดงจำนวนวัตถุดิบ
        private void ShowMaterial()
        {
            porkTextBox.Text = menu.Pork().ToString();
            chickenTextBox.Text = menu.Chicken().ToString();
            shrimpTextBox.Text = menu.Shrimp().ToString();
            squidTextBox.Text = menu.Squid().ToString();
            riceTextBox.Text = menu.Rice().ToString();
        }


        //เคลียจำนวนเมนู
        private void ClearAllMenu()
        {
            currentCount1 = 0;
            currentCount2 = 0;
            currentCount3 = 0;
            currentCount4 = 0;
            currentCount5 = 0;
            currentCount6 = 0;

        }
        //เคลียจำนวนออเดอร์
        private void ClearAllCurrent()
        {
            khaoMuYangOrderTextBox.Clear();
            khaoOokKaiYangOrderTextBox.Clear();
            khaoKaphraoThaleOrderTextBox.Clear();
            khaoPhrikPhaoThaleOrderTextBox.Clear();
            khaoMuThodKrathiamTextBox.Clear();
            khaoKaiThodKrathiamOrderTextBox.Clear();
        }

        //ปุ่ม"เพิ่มออเดอร์"
        private void khaoMuYangAddButton_Click(object sender, EventArgs e)
        {


            bool canmake = menu.khaoMuYang();
            if (canmake)
            {
                ShowMaterial();
                currentCount1 ++;
                khaoMuYangOrderTextBox.Text = currentCount1.ToString();

            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
            
        }
        private void khaoOokKaiYangAddButton_Click(object sender, EventArgs e)
        {

            bool canmake = menu.khaoOokKaiYang();
            if (canmake)
            {

                ShowMaterial();
                currentCount2++;
                khaoOokKaiYangOrderTextBox.Text= currentCount2.ToString();
            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
        }

        private void khaoKaphraoThaleAddButton_Click(object sender, EventArgs e)
        {

            bool canmake = menu.khaoKaphraoThale();
            if (canmake)
            {
                ShowMaterial();
                currentCount3 ++;
                khaoKaphraoThaleOrderTextBox.Text = currentCount3.ToString();
            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
        }

        private void khaoPhrikPhaoThaleAddButton_Click(object sender, EventArgs e)
        {

            bool canmake = menu.khaoPhrikPhaoThale();
            if (canmake)
            {
                ShowMaterial();
                currentCount4 ++;
                khaoPhrikPhaoThaleOrderTextBox.Text = currentCount4 .ToString();
            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
        }

        private void khaoMuThodKrathiamAddButton_Click(object sender, EventArgs e)
        {

            bool canmake = menu.khaoMuThodKrathiam();
            if (canmake)
            {
                ShowMaterial();
                currentCount5 ++;
                khaoMuThodKrathiamTextBox.Text = currentCount5 .ToString();
            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
        }

        private void khaoKaiThodKrathiamAddButton_Click(object sender, EventArgs e)
        {

            bool canmake = menu.khaoKaiThodKrathiam();
            if (canmake)
            {
                ShowMaterial();
                currentCount6 ++;
                khaoKaiThodKrathiamOrderTextBox.Text = currentCount6 .ToString();
            }
            else
            {
                MessageBox.Show("วัตถุดิบไม่เพียงพอ");
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            menu.ClearMaterial();
            ShowMaterial();
        }

        //เพิ่มวัตถุดิบ
        private void increaseButton_Click(object sender, EventArgs e)
        {
            int pork;
            int chicken;
            int shrimp;
            int squid;
            int rice;
            if (porkAddTextBox.Text == "")
            {
                pork = 0;
                chicken = 0;
                shrimp = 0;
                squid = 0;
                rice = 0;
            }
            else
            {

                pork = int.Parse(porkAddTextBox.Text);
            }
            if (chickenAddTextBox.Text == "")
            {
                chicken = 0;

            }
            else
            {
                chicken = int.Parse(chickenAddTextBox.Text);
            }
            if (shrimpAddTextBox.Text == "")
            {

                shrimp = 0;
            }
            else
            {
                shrimp = int.Parse(shrimpAddTextBox.Text);
            }
            if (squidAddTextBox.Text == "")
            {
                squid = 0;  
            }
            else
            {
                squid = int.Parse(squidAddTextBox.Text);

            }
            if (riceAddTextBox.Text == "")
            {
                rice = 0;
            }
            else
            {

                rice = int.Parse(riceAddTextBox.Text);
            }

            menu.AddMaterial(rice, pork, chicken, shrimp, squid);
            porkAddTextBox.Text = string.Empty;
            chickenAddTextBox.Text = string.Empty;
            shrimpAddTextBox.Text = string.Empty;
            squidAddTextBox.Text = string.Empty;
            riceAddTextBox.Text = string.Empty;
            

            ShowMaterial();
        }


        
        
        //นำเข้าข้อมูลจากไฟล์
        private void importMaterial_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            Menu1 import = csv.ReadFile();
            porkTextBox.Text = import.Pork().ToString();
            chickenTextBox.Text = import.Chicken().ToString();
            shrimpTextBox.Text = import.Shrimp().ToString();
            squidTextBox.Text = import.Squid().ToString();
            riceTextBox.Text = import.Rice().ToString();
        }

        //บันทึกข้อมูลเข้าไฟล์
        private void saveMaterial_Click(object sender, EventArgs e)
        {
            CSV csv = new CSV();
            csv.SavetoFile(menu);
        }

        private void ClearOrder_Click(object sender, EventArgs e)
        {
            ClearAllCurrent();
            ClearAllMenu();
        }
    }
}

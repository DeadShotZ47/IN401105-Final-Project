using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CSV
    {
        private string path = @"D:\งานคอม bro\IN401105 (OOP)\Final Project\Final Project\Data.csv";
        
        //สิ่งที่ไฟล์จะเซฟ
        public bool SavetoFile(Menu1 mateial)
        {
            string content = mateial.Pork() + "," + mateial.Chicken() + "," + mateial.Shrimp() + "," + mateial.Squid() + "," + mateial.Rice() + "\n";
            try
            {
                File.WriteAllText(path, content);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //อ่านข้อมูลไฟล์
        public Menu1 ReadFile()
        {
            string[] content = File.ReadAllText(path).Split(',');
            
            Menu1 menu = new Menu1();
            menu.SetPork(int.Parse(content[0]));
            menu.SetChicken(int.Parse(content[1]));
            menu.SetShrimp(int.Parse(content[2]));
            menu.SetSquid(int.Parse(content[3]));
            menu.SetRice(int.Parse(content[4]));
            return menu;
        }
    }
}

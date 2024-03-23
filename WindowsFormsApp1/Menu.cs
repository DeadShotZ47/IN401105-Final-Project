using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Menu1 : Control
    {
       
        //ตรวจสอบจำนวนวัตถุดิบเทียบกับจำนวนที่แต่ละเมนูต้องการ
        //
        public bool khaoMuYang() 
        {
            if (pork >= 120 && rice >= 150)
            {
                pork = pork - 120;
                rice = rice - 150;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool khaoOokKaiYang()
        {
            if (chicken >= 120 && rice >= 150)
            {
                chicken -= 120;
                rice -= 150;
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public bool khaoKaphraoThale()
        {
            if (shrimp >= 70 && squid >= 90 && rice >= 150)
            {
                shrimp = shrimp - 70;
                squid = squid - 90;
                rice = rice - 150;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool khaoPhrikPhaoThale()
        {
            if (shrimp >= 70 && squid >= 90 && rice >= 150)
            {
                shrimp = shrimp - 70;
                squid = squid - 90;
                rice = rice - 150;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool khaoMuThodKrathiam()
        {
            if (pork >= 120 && rice >= 150)
            {
                pork = pork - 120;
                rice = rice - 150;
                return true;

            }
            else 
            {
                return false;
            }
        }

        public bool khaoKaiThodKrathiam()
        {
            if (chicken >= 120 && rice >= 150)
            {
                chicken = chicken - 120;
                rice = rice - 150;
                return true;
            }
            else
            {
                return false;
            }
        }

        //เพิ่มจำนวนวัตถุดิบ
        public void AddMaterial(int rice, int pork, int chicken, int shrimp, int squid)
        {
            this.rice += rice;
            this.pork += pork;
            this.chicken += chicken;
            this.shrimp += shrimp;
            this.squid += squid;
        }

        //ล้างข้อมูลวัตถุดิบ
        public void ClearMaterial()
        {
            this.rice = 0;
            this.pork = 0;
            this.chicken = 0;
            this.shrimp = 0;
            this.squid = 0;
        }

    }
}

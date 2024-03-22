using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //วัตถุดิบเริ่มต้น = 0
    public class Control
    {
        protected int rice = 0;
        protected int pork = 0;
        protected int chicken = 0;
        protected int shrimp = 0;
        protected int squid = 0;
        

        

        //ตัวเรียกค่า วัตถุดิบ
        public int Rice()
        {
            return rice;
        }
        public int Pork()
        {
            return pork;
        }
        public int Chicken()
        {
            return chicken;
        }
        public int Shrimp()
        {
            return shrimp;
        }
        public int Squid()
        {
            return squid;
        }

        //ตั้งค่าจำนวนวัตถุดิบ
        public void SetPork(int pork)
        {
            this.pork = pork;
        }
        public void SetChicken(int chieken)
        {
            this.chicken = chieken;
        }
        public void SetShrimp(int shrimp)
        {
            this.shrimp = shrimp;
        }
        public void SetSquid(int squid)
        {
            this.squid = squid;
        }
        public void SetRice(int rice)
        {
            this.rice = rice;
        }
        
        
        
    }

}

### ความเป็นมา
    ปัจจุบันได้มีการรับประทารอาหารนอกบ้านจำนวนมาก ทำให้เกิดร้านอาหารได้ทั่วไป ซึ่งได้เกิดปัญหาคือบางวัตถุดิบสำหรับบางเมนูได้หมดขึ้น จึงทำให้เกิดการชะรอเวลาในการบอกลูกค้าให้เปลี่ยนเมนู และเกิดความกังวลของเจ้าของร้านว่าวัตถุดิบจะเพียงพอต่อการทำอาหารหรือไม่ จึงได้สร้างโปรแกรมนี้เพื่อจัดการปัญหานั้น
### วัตถุประสงค์
        1.เพื่อศึกษาการเขียนโปรแกรมเชิงระบบ
        2.เพื่อช่วยเหลือเหล่าผู้ประกอบการร้านอาหาร
### โครงสร้างโปรแกรม
```mermaid
classDiagram
    Control <|-- Menu1
    Form1 <-- Control
    Form1 --> Menu1
    class Form1{
        -int currentCount1
        -int currentCount2
        -int currentCount3
        -int currentCount4
        -int currentCount5
        -int currentCount6

        -ShowMaterial()
        -ClearAllMenu()
        -ClearAllCurrent()
        -khaoMuYangAddButton_Click(object sender, EventArgs e)
        -khaoOokKaiYangAddButton_Click(object sender, EventArgs e)
        -khaoKaphraoThaleAddButton_Click(object sender, EventArgs e)
        -khaoPhrikPhaoThaleAddButton_Click(object sender, EventArgs e)
        -khaoMuThodKrathiamAddButton_Click(object sender, EventArgs e)
        -khaoKaiThodKrathiamAddButton_Click(object sender, EventArgs e)
        -DeleteButton_Click(object sender, EventArgs e)
        -increaseButton_Click(object sender, EventArgs e)
        -importMaterial_Click(object sender, EventArgs e)
        -saveMaterial_Click(object sender, EventArgs e)

    }
    class Control{
        
        -int rice 
        -int pork 
        -int chicken
        -int shrimp 
        -int squid 

        +Rice()
        +Pork()
        +Chicke()
        +Shrimp()
        +Squid()

        +SetPork()
        +SetChicken()
        +SetShrimp()
        +SetSquid()
        +SetRice() 
    }
    class Menu1{
        +khaoMuYang()
        +khaoOokKaiYang()
        +khaoKaphraoThale()
        +khaoPhrikPhaoThale()
        +khaoMuThodKrathiam()
        +khaoKaiThodKrathiam()
        +AddMaterial(int rice, int pork, int chicken, int shrimp, int squid)
        +ClearMaterial()
    }
    class CSV{
        -path = @"D:\งานคอม bro\IN401105 (OOP)\Final Project\Final Project\Data.csv";
        +SavetoFile(Menu1 mateial)
        +Menu1 ReadFile()
    }

```

### ผู้พัฒนาโปรแกรม
        นายสินสมุทร ขุนพิมูล 663450310-9

# Final-Project
ความเป็นมาของโปรแกรม
```
โปรแกรมบันทึกรายรับรายจ่ายของของตนเอง เป็นโปรแกรมที่สร้างขึ้นมาก็เพื่อแก้ปัญหาการใช้จ่ายเงินและต้องการที่จะทราบว่าเราใช้จ่ายอะไรบ้าง
และใช้เงินเป็นจำนวนเท่าไหร่ และต้องการทราบว่ารายรับเรามีเท่าไหร่
```
วัตถุประสงค์ของโปรแกรม
```
1.เพื่อช่วยในการบันทึกรายรับและรายจ่ายของตนเอง แสดงรายรับรายจ่ายรวม แสดงรายการรายรับสูงสุดและต่ำสุด แสดงรายการรายจ่ายสูงสุด
และต่ำสุด
2.เพื่อที่จะสามารถทราบว่าเราได้ใช้เงินไปกับอะไรบ้าง
```

Class Diagram
```mermaid
classDiagram
  direction LR
  class form1{
  -Loging()
  -Logout()
  }
  class form2{
  -Ok()void
  -Exit()void
  }
  class Income{
  selectedRow:int 
  -Add():void
  -Delete():void
  -Reset():void
  -Exit():void
  -Save():void
  }
  class Expenses{
   selectedRow:int 
  -Add():void
  -Delete():void
  -Reset():void
  -Exit():void
  -Save():void
  }
  class SumIncome{
  -date:string
  -listmin:string
  -listmax:string
  -amountIn:int
  -min:double
  -max:double
  -sum:double
  +addSumIn(income double,list string)void
  +getSumIn()double
  +deleteSumIn(income double,list string)void
  +getDeleteSumIn()double
  +getMin()double
  +getMax()double
  +getListMin()string
  +getListMax()string
  +reSum()double
  +reMin()double
  +reMax()double
  +reListMin()string
  +reListMax()string
  }
  class SumExpenses{
  -date:string
  -listmin:string
  -listmax:string
  -amountEx:int
  -min:double
  -max:double
  -sum:double
  +addSumEx(expenses double,list string)void
  +getSumEx()double
  +deleteSumEx(expenses double,list string)void
  +getDeleteSumEx()double
  +getMin()double
  +getMax()double
  +getListMin()string
  +getListMax()string
  +reSum()double
  +reMin()double
  +reMax()double
  +reListMin()string
  +reListMax()string
  }
  SumExpenses -- Expenses
  SumIncome -- Income
```
ผู้พัฒนาโปรแกรม
```
นางสาวนภาปิลันธ์ ชาวชายโขง รหัสนักศึกษา 643450327-0
```

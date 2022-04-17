# Final-Project
ความเป็นมาของโปรแกรม
```

```
วัตถุประสงค์ของโปรแกรม
```

```

Class Diagram
```mermaid
classDiagram
  direction LR
  class form1{
  bottonLoging()
  }
  class form2{
  bontonAdd()
  oponFile()
  saveFile()
  }
  class Income{
  }
  class SumIncome{
  -date:string
  -listmin:string
  -listmax:string
  -amountin:int
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
  }
  class SumExpenses{
  -date:string
  -listmin:string
  -listmax:string
  -amountex:int
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
  }
  form2 --|> form1
  SumExpenses --|> SumIncome 
```
ผู้พัฒนาโปรแกรม
```
นางสาวนภาปิลันธ์ ชาวชายโขง รหัสนักศึกษา 643450327-0
```

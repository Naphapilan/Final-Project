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
  -string date
  -string listmin
  -string listmax
  -int amountin
  -double min
  -double max
  -double sum
  +addSumIn()void
  +getSumIn()double
  +deleteSumIn()
  +getDeleteSumIn()
  +getMin()
  +getMax()
  +getListMin()
  +getListMax()
  }
  class SumExpenses{
  addSumEx()
  getSumEx()
  }
  form2 --|> form1
  SumIncome --|> form2
  SumExpenses --|> form2
```
ผู้พัฒนาโปรแกรม
```
นางสาวนภาปิลันธ์ ชาวชายโขง รหัสนักศึกษา 643450327-0
```

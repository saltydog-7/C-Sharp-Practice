// class 類別
// object 物件

//Person為資料型態 - class
//由class所創建的東西person_1為物件

Person person_1 = new Person();
person_1.height = 170.5; //代入170.5到person_1的height
person_1.age = 42;
person_1.name = "Tom";
System.Console.WriteLine(person_1.height);

//Create new object
Person person_2 = new Person();
person_2.height = 162.3;
person_2.age = 37;
person_2.name = "Mary";
System.Console.WriteLine(person_2.height);
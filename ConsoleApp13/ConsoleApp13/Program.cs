// namespace & using

using Animal.Human; //表示正於此C#檔案使用Animal版模
              //如不使用using Animal方式，可於下方Person前加上Animal. →　Animal.Person 以代表正使用Animal版模
Person person_1 = new Person();
person_1.height = 170.5; //代入170.5到person_1的height
person_1.age = 42;
person_1.name = "Tom";
System.Console.WriteLine(person_1.height);

Person person_2 = new Person();
person_2.height = 162.3;
person_2.age = 37;
person_2.name = "Mary";
System.Console.WriteLine(person_2.name);
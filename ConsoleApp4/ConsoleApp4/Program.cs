// 取得用戶輸入

System.Console.WriteLine("請輸入名字：");
string name = System.Console.ReadLine();
System.Console.WriteLine("你好！" + name + "，歡迎使用。");

System.Console.WriteLine("請輸入年齡：");
string age = System.Console.ReadLine();
System.Console.WriteLine(name + "今年" + age + "歲。");

// 基本計算機
// 由於 System.Console.ReadLine(); 預設輸入資料型態為字串
// 因此不能直接把變數的資料型態設定為int
// 需要為字串進行轉換成為整數 System.Convert.ToInt32()

System.Console.WriteLine("請輸入第一個數字：");
int num_1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("請輸入第二個數字：");
int num_2 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(num_1+num_2);

// 如在使用int時輸入浮點數，程式將出現錯誤
// 因此需要將字串轉換為浮點數 System.Convert.ToDouble

System.Console.WriteLine("請輸入第一個數字：");
double num_3 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("請輸入第二個數字：");
double num_4 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine(num_3 + num_4);
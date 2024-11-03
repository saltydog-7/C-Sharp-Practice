// C# WriteLine使用
// Console呼叫執行視窗
// WriteLine請電腦輸出內容
System.Console.WriteLine("Hello World!");

// 常見資料型態

// 字串 string ""
// 字串表達一段純文字
// ""內的Hello World為字串
System.Console.WriteLine("Hello World!");

// 字元 char ''
// 字元表達一個純文字
// 例子：'K'
System.Console.WriteLine('K');

// 整數 int 1960
// int不能表達點數，只能表達整數
// 不需要使用字串或字元，整數就是一個完整的資料型態
System.Console.WriteLine(1960);

// 浮點數 double 160.5

// 布林值 bool true false
// 布林值表達是或否
// true 是/真
// false 否/假



// 變數

// 假設創建字串變數name
// name為容器，內容為Risa
string name = "Risa";

// 假設創建字元變數
// sex為容器，內容為F
char sex = 'F';

// 假設創建整數變數age
// age為容器，內容為34
int age = 34;

// 假設創建浮點數變數height
// height為容器，內容為153.0
double height = 153.0;

// 假設創建布林值變數is_female
// is_female為容器，內容為true
bool is_female = true;

System.Console.WriteLine("她的名字叫" + name);
System.Console.WriteLine(name + "今年" + age + "歲");

//變數可進行修改，但無法更改資料型態
//把name代入字串"Saori"後，再次執行程式時name的內容會更變為"Saori"
name = "Saori";
System.Console.WriteLine("她的名字叫" + name);




// 字串常見用法
// 可用\n進行換行
// 可用\顯示"符號
System.Console.WriteLine("Hello" + "\nWorld!");
System.Console.WriteLine("Hello\" World!");
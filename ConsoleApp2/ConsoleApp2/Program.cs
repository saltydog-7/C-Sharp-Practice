// 字串常見用法

// 可用\n進行換行
// 可用\顯示"符號
System.Console.WriteLine("Hello" + "\nWorld!");
System.Console.WriteLine("Hello\" World!");

// 使用變數
// 於字串或變數後加上.Length可得知字串長度
string phrase = "Hello World!";
System.Console.WriteLine(phrase.Length);

// 於字串或變數後加上.ToUpper()可把字母全部轉換為大寫
System.Console.WriteLine(phrase.ToUpper());

// 於字串或變數後加上.ToLower()可把字母全部轉換為小寫
System.Console.WriteLine(phrase.ToLower());

// 於字串或變數後加上.Contains()可判斷字串是否有子字串
// ()內需要寫上判斷字串
System.Console.WriteLine(phrase.Contains("Hello"));
System.Console.WriteLine(phrase.Contains("Hi"));

// 使用[]去確認字串第幾位為什麼
// 注意：電腦由0開始順序
// 如果想顯示"Hello World!"中的"H"應於[]內輸入0檢視
System.Console.WriteLine(phrase[0]);

// 使用.IndexOf()可確認字串的位置
// 如果字串內有重覆字元/字串，將回傳最先出現的一個的位置
System.Console.WriteLine(phrase.IndexOf('o'));

// 使用.Substring()將字串切割
// 如於()內輸入3，在第3位之前的東西都被切割
// 如於()內輸入5,4則於第5位開始切割，並取後面4位的字串
System.Console.WriteLine(phrase.Substring(3));
System.Console.WriteLine(phrase.Substring(5,4));
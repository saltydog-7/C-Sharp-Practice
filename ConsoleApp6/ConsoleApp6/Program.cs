// if 判斷句

// 情況一
using System.ComponentModel.Design;

bool hungry = true; // 使用變數判斷是否正確
if (hungry) // 如果我肚子餓了
{
    System.Console.WriteLine("Go and eat."); // 我就去吃飯
}

// 情況二
bool rain = true; // 使用變數判斷是否正確
if (rain) //如果今天下雨
{
    System.Console.WriteLine("我就開車去上班。");
} else {
    System.Console.WriteLine("我就走路上班。");
}

// 情況三
System.Console.WriteLine("Please enter your score:"); // 顯示"Please enter your score:"
int score = System.Convert.ToInt32(System.Console.ReadLine()); //輸入整數並代入score
if(score == 100) { //如果score等於100
    System.Console.WriteLine("I pay you $1000.");
} else if (score >= 80) { //如果score大過等於80
    System.Console.WriteLine("I pay you $800.");
} else if (score >= 60) { //如果score大過等於60
    System.Console.WriteLine("I pay you $600.");
} else { //如果score是以上以外的數字
    System.Console.WriteLine("You pay me $400.");
}

// 情況四
// && 代表 「且」
System.Console.WriteLine("Please enter your score:"); // 顯示"Please enter your score:"
int score_2 = System.Convert.ToInt32(System.Console.ReadLine()); // 輸入整數並代入score_2
System.Console.WriteLine("Please enter the weather:"); // 顯示"Please enter the weather:"
string weather =  System.Console.ReadLine(); // 輸入字串並代入weather
if (score_2 == 100 && weather == "sunny") { // 如果score_2等於100以 且 weather等於sunny
    System.Console.WriteLine("Today is a good day.");
} else { // 如果非以上情況
    System.Console.WriteLine("Today may not be a good day.");
}

// 情況五
// || 代表 「或」
System.Console.WriteLine("Please enter your score:"); // 顯示"Please enter your score:"
int score_3 = System.Convert.ToInt32(System.Console.ReadLine()); // 輸入整數並代入score_3
System.Console.WriteLine("Please enter the weather:"); // 顯示"Please enter the weather:"
string weather_2 = System.Console.ReadLine(); // 輸入字串並代入weather_2
if (score_3 == 100 || weather_2 == "sunny") // 如果score_3等於100 或 weather_2等於sunny
{ 
    System.Console.WriteLine("Today is a good day.");
}
else
{ // 如果非以上情況
    System.Console.WriteLine("Today may not be a good day.");
}

// 情況六
// != 判斷 是否不等於
System.Console.WriteLine("Please enter your score:"); // 顯示"Please enter your score:"
int score_4 = System.Convert.ToInt32(System.Console.ReadLine()); // 輸入整數並代入score_4
System.Console.WriteLine("Please enter the weather:"); // 顯示"Please enter the weather:"
string weather_3 = System.Console.ReadLine(); // 輸入字串並代入weather_3
if (score_4 != 100 || weather_3 != "sunny") // 如果score_4 不等於 100 或 weather_3不等於sunny
{
    System.Console.WriteLine("Today is a good day.");
}
else
{ // 如果非以上情況
    System.Console.WriteLine("Today may not be a good day.");
}
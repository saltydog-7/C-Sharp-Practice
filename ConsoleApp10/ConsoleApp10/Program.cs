// for 迴圈

/* 將以下while迴圈以for迴圈表示
 * int i = 1;
 * while(i<=5){
 * System.Console.Write(i);
 * i++
 * }
*/


//for()內有3個部分
//第一個部分設定變數初始值 即 int i = 1
//第二個部分設定條件 即 i<=5
//第三個部分設定每次執行完迴圈後要處理的事

for(int i=1; i<=5; i++)
{
    System.Console.WriteLine(i);
}

//Array應用
int[] nums = { 5, 10, 17, 21, 26, 28 }; //設置陣列
for(int a=0; a<nums.Length; a++)
    //a初始值為0 即 陣列第一個數字
    //a小於nums陣列內有多少組數字（目前nums內有6組數字）
    //每次執行迴圈後a會+1
{
    System.Console.WriteLine(nums[a]); //輸出陣列
}
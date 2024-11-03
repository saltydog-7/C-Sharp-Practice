// while 迴轉

// 情況一
int num = 1; // 設定變數num=1

while (num<=5) // 當num小於等於5
{
    System.Console.WriteLine(num); //輸出num
    num = num + 1; // 在num=1時再+1
}

/* while將判斷num有沒有小於等於5
 * 如有，將一直執行程式至num小於等於5後停止*/


// 情況二
int num_2 =  10;
do //先執行大括號內的程式
{
    System.Console.WriteLine(num_2);
    num_2++;
}
while (num_2<=20); // 後判斷num_2<=20是否成立
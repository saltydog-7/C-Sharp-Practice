// 猜數字遊戲

int answer = 7; //答案
int num_1; //空白變數由玩家輸入
int num_count = 0; //遊玩次數
int num_limit = 3; //遊玩限制次數
bool win = false; //判斷玩家有沒有勝出（一開始沒有勝出所以設定值是false）


do
{
    System.Console.WriteLine("Please enter a number:");
    num_1 = System.Convert.ToInt32(System.Console.ReadLine());
    num_count++; // 每遊玩一次增加1

    if (num_1 > answer)
    {
        System.Console.WriteLine("Too big, please enter another number.");
    }
    else if (num_1 < answer)
    {
        System.Console.WriteLine("Too small, please enter another number.");
    }
    else
    {
        System.Console.WriteLine("You Win!! You got the corrent number!!");
        win = true; //玩家勝出
    }
}
while (num_1 != answer && num_count<num_limit);

if (!win) //如果win=false 即 玩家沒有勝出
{
    System.Console.WriteLine("You Lose.");
}
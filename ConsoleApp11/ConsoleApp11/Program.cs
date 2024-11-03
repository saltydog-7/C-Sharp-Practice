// 二維陣列 = 於陣列內再放陣列

// row 橫排
// column 直排

//int[,]代表創建二維陣列
int[,] nums = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
};
//nums[2,0]代表row 3的第一個數字
System.Console.WriteLine(nums[2,0]);

//創建空白二維陣列
//new int[3,4]代表有3個橫排4個直排
int[,] nums_2 = new int[3, 4];
nums_2[0,0] = 1;
nums_2[0,1] = 2;
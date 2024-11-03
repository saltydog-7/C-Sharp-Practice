// 進階計算機

System.Console.Write("Please enter the first nuber:");
double num_1 = System.Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("Please enter the method:");
string oper = System.Console.ReadLine();

System.Console.Write("Please enter the second nuber:");
double num_2 = System.Convert.ToDouble(System.Console.ReadLine());

if (oper == "+")
{
    System.Console.WriteLine(num_1 + num_2);
} else if (oper == "-")
{
    System.Console.WriteLine(num_1 - num_2);
} else if (oper == "*")
{
    System.Console.WriteLine(num_1 * num_2);
} else if (oper == "/")
{
    System.Console.WriteLine(num_1 / num_2);
} else
{
    System.Console.WriteLine("Error!! Wrong method.");
}
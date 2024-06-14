// 計算機運算

System.Console.Write("請輸入第一個數字：");
double num1 = System.Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("請輸入要做的運算符號：");
string oper = System.Console.ReadLine();

System.Console.Write("請輸入第二個數字：");
double num2 = System.Convert.ToDouble(System.Console.ReadLine());

if (oper == "+")
{
    System.Console.WriteLine(num1 + num2);
}

else if (oper == "-") 
{
    System.Console.WriteLine(num1 - num2);     
}

else if (oper == "*")
{
    System.Console.WriteLine(num1 * num2);
}

else if (oper == "/")
{
    System.Console.WriteLine(num1 / num2);
}

else
{
    System.Console.WriteLine("錯誤的運算符號");
}
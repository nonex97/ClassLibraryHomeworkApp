using Helpers;

CalcHelpers calchelper = new CalcHelpers();
int a = 2;
int b = 5;

int addResult = calchelper.AddNumbers(a, b);
Console.WriteLine($"{a}+{b}={addResult}");

int multiplyResult = calchelper.MultiplyNumbers(a, b);
Console.WriteLine($"{a}*{b}={multiplyResult}");


Console.ReadLine();
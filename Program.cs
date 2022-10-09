// See https://aka.ms/new-console-template for more information
Console.Write("Введите х:");
string x = Console.ReadLine();
Console.Write("Введите у:");
string y = Console.ReadLine();
int xx = Convert.ToInt32(x);
int yy = Convert.ToInt32(y);
int sum = xx + yy;
if (xx == yy)
{
    Console.WriteLine($"Сумма равняется {xx}");
}
else
{
    Console.WriteLine($"Сумма равняется{sum}");
}
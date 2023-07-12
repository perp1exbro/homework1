Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов:\n");
for (int i=1;i<=n;i++)
{
int k = i*i*i;
Console.Write($"{k}, ");
}
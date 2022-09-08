Console.Write("Введите номер дня недели: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A >= 1 && A < 6)
{
    Console.WriteLine("No");
}
if (A >= 6 && A <= 7)
{
    Console.WriteLine("Yes");
}
if (A < 1)
{
    Console.WriteLine("Это не номер дня недели");
}
if (A > 7)
{
    Console.WriteLine("Это не номер дня недели");
}
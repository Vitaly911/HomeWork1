Console.WriteLine("Введите любое число от 1 до 7");
int A = Convert.ToInt32(Console.ReadLine());
if(A < 1 || A > 7)
{
Console.WriteLine("Введите любое число от 1 до 7 (1, 2, 3, 4, 5, 6, 7.)");
}
if(A < 6)
{
Console.WriteLine("Нет");
}
if(A < 8)
{
Console.WriteLine("Да");
}
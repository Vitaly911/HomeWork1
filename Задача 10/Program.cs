Console.Write("Введите любое трехзначное число: ");
int A = Convert.ToInt32(Console.ReadLine());
if(A / 100 <= 0 || A / 100 >= 10)
{
    Console.WriteLine("Введите число от 100 до 1000");
}
else
{
    int B = A / 10;
    int C = B % 10;
    Console.WriteLine(C);
}
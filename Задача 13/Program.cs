Console.WriteLine("Введите любое число от 100");
int A = Convert.ToInt32(Console.ReadLine());
if(A < 100)
{
Console.WriteLine("Третьей цифры нет.");
}
else
{
int B = 0;
int X = 100;
while(B <= 0)
    if(A / X < 10)
    {
        B = B + 1;
    }
    else
    {
        X = X * 10;
    }
    X = X / 100;
    int C = A / X;
    int finishnumber = C % 10;
    Console.WriteLine(finishnumber);
}
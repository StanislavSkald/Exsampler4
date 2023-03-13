// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Write(string maesageToUser)
{
    Console.WriteLine(maesageToUser);
    return Convert.ToInt32 (Console.ReadLine());
}

int Sum (int N)
{   
    int Nt = 0;
    while(N > 0)
    {
    Nt += N % 10;
    N /= 10;
    }
    return(Nt);
}

int N = Write("Введите чисто");
int res = Sum (N);
Console.WriteLine(res);
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Write(string maesageToUser)
{
    Console.WriteLine(maesageToUser);
    return Convert.ToInt32 (Console.ReadLine());
}

int Degree(int a, int b)
{
    int Degree1 = 1;
    for(int R = 1; R <= b; R++)
{
    Degree1 *=a;  
}
return Degree1;
}

int a = Write("Введите число a");
int b = Write("Введите число b");
int Deg = Degree(a,b);
Console.WriteLine(Deg);
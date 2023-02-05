//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int PowOfNumber(int n1, int n2)
{
    int result = n1;
    for (int i = 1; i < n2; i++)
    {
        result *= n1;
    }
    return result;
}








Console.WriteLine("Задача 25");
Console.Write("Введите первое число для позведения его в степень: ");
int n1;
while(!int.TryParse(Console.ReadLine(), out n1))
{
    Console.Write("Введен неверный параметр, введите целое пятизначное число: ");
}
Console.Write("Введите второе число, которое будет являться степенью первого: ");
int n2;
while(!int.TryParse(Console.ReadLine(), out n2))
{
    Console.Write("Введен неверный параметр, введите целое пятизначное число: ");
}
int powed = PowOfNumber(n1, n2);
Console.WriteLine($"Результат возведения числа - {n1} в степень - {n2} является число: {powed}");
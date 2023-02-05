//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfNumbers(int n)
{
    int result = 0;
    int last_num = 0;
    n = Math.Abs(n);
    while(n > 0)
    {
        last_num = n % 10;
        result += last_num;
        n = n / 10;
    }
    
    
    return result;
}




Console.WriteLine("Задача 27");
Console.Write("Введите число для подсчёта суммы цифр в числе: ");
int number;
while(!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Введен неверный параметр, введите целое пятизначное число: ");
}

Console.WriteLine(SumOfNumbers(number));
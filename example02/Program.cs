// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

while(number > 0)
{
    result += number % 10;
    number = number / 10;
}

System.Console.WriteLine(result);
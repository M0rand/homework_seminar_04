// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите целое число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите целое число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = 1;

while(numberB > 0)
{
    result *= numberA;
    numberB -= 1; 
}

System.Console.WriteLine(result);
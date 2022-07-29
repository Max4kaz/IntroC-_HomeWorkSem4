// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int number = InputInt("Введите число А: ");
int degree = InputInt("Введите число В: ");
int result = 1;

for (int i = 1; i <= degree; i++)
{
    result *= number;
}
Console.WriteLine($"Результат возведения числа А в натуральную степень В равен {result}");

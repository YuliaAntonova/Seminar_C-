// Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго
Console.Write ("Введите число a: ");
string numberA = Console.ReadLine();
Console.Write ("Введите число b: ");
string numberB = Console.ReadLine();
int a = Int32.Parse(numberA);
int b = Int32.Parse(numberB);
if (b == a * a)
{
    Console.WriteLine ("ДА, первое число является квадратом второго");
}
else
{
   Console.WriteLine ("НЕТ, первое число не является квадратом второго"); 
}
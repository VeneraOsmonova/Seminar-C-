/*12. Напишите программу, которая будет принимать 
1.на вход два числа
2.выводить, является ли второе число
кратным первому.
3.Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/


Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)      // == 0, без остатка
    Console.WriteLine("Кратно");
else
Console.WriteLine($"Не кратно, остаток {number1 % number2}");






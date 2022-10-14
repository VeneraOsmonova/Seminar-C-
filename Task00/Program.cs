/*0. 
1. на вход принимает число
2. выдаёт его квадрат (число
умноженное на само себя).
Например: 4 -> 16;  -3 -> 9;   -7 -> 49*/

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
// string str = "4";
// string str = Console.ReadLine();
// int number = Convert.ToInt32;
int square = number * number;
System.Console.WriteLine($"Kвадрат числа {number} = {square}");

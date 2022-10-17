/*9. Напишите программу, которая 
1. выводит случайное число из отрезка [10, 99]
2. показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8*/
                          //1 ВАРИАНТ:
/*int ran = new Random().Next(10, 100);
System.Console.WriteLine($"Случайное число из отрезка 10 99 => {ran}");

int firstDigit = ran / 10;
int secondtDigit = ran % 10;

if (firstDigit > secondtDigit)
System.Console.WriteLine(firstDigit);
else 
System.Console.WriteLine(secondtDigit);*/


                           
                           //2 ВАРИАНТ (Method):
int MaxDigit(int num)
{
    int firstDigit = num / 10; // 78 / 10 = 7
    int secondDigit = num % 10; // 78 % 10 = 8
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");

                          
                          
                          
                          //3 ВАРИАНТ:
/*int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10; // 78 % 10 = 8

if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа равна {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа равна {secondDigit}");*/




                           //4 ВАРИАНТ (Условный оператор):
/*int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10; // 78 % 10 = 8         
int result = default;
if(firstDigit > secondDigit) result = firstDigit;
else result = secondDigit;
Console.WriteLine($"Наибольшая цифра числа равна {result}");*/


                            
                            
                            //5 ВАРИАНТ (Тернарный оператор 1):
/*int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10; // 78 % 10 = 8 
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа равна {maxDigit}");*/


                            
                            
                            //6 ВАРИАНТ (Тернарный оператор 2):
/*int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10; // 78 % 10 = 8
Console.Write($"Наибольшая цифра числа {number} равна ");
Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);*/




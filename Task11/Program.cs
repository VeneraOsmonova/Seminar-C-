/*11. Напишите программу, которая
1. выводит случайное трёхзначное число
2. удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/
                               //1 ВАРИАНТ:
/*int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число от 100 до 999: {number}");
int firstDigit = number / 100;         // 456 / 100 = 4
Console.WriteLine($"1 цифра: {firstDigit}");
int thirdDigit = number % 10;           // 456 % 10 = 6
Console.WriteLine($"3 цифра: {thirdDigit}");

int result = firstDigit * 10 + thirdDigit;  // 4 * 10 = 40 + 6 = 46
Console.WriteLine($"вывод: {result}");*/


                              //2 ВАРИАНТ (Method):
int RmSecondNum (int number)
{
    int firstDig = number / 100;
    int thirdhDig = number % 10;
    int num1_3 = firstDig * 10 + thirdhDig;
    Console.WriteLine(number);
    return num1_3;
}

int res = RmSecondNum(new Random().Next(100, 1000));
Console.WriteLine(res);





                             //3 ВАРИАНТ:
/*int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число {number}");

int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;

    return firstDigit * 10 + thirdDigit;
}

int result = DelSecondDigit(number);
Console.WriteLine($"Полученное число {result}");*/





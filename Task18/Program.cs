/*Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/

Console.WriteLine("Введите номер четверти");
//int loc = Convert.ToInt32(Console.ReadLine());
string loc = Console.ReadLine();


//string Quarter(int x)
string Quarter(string x)
{
    //if (x == 1) return "x > 0 и y > 0";
    if (loc == "1") return "x > 0 и y > 0";
    //if (x == 2) return "x > 0 и y < 0";
    if (loc == "2") return "x > 0 и y < 0";
    //if (x == 3) return "x > 0 и y > 0";
    if (loc == "3") return "x > 0 и y > 0";
    //if (x == 4) return "x < 0 и y > 0";
    if (loc == "4") return "x < 0 и y > 0";
    return "Введены некорректные данные";
}

//string quater = Quarter(x);
string quater = Quarter(loc);
System.Console.WriteLine(quater);

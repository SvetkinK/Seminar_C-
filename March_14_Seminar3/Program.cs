
// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
CheckKoord(x, y);
Console.WriteLine($" это четверть № {CheckKoord2(x,y)}");


void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Четверть № 1");
    else if (x < 0 && y > 0)
        Console.WriteLine("Четверть № 2");
    else if (x < 0 && y < 0)
        Console.WriteLine("Четверть № 3");
    else if (x > 0 && y < 0)
        Console.WriteLine("Четверть № 4");
    else
        Console.WriteLine("Точка находится на координатной оси");
}

int CheckKoord2(int x, int y)
{
    int res = 0;
    if (x > 0 && y > 0)
        res = 1;
    else if (x < 0 && y > 0)
        res = 2;
    else if (x < 0 && y < 0)
        res = 3;
    else if (x > 0 && y < 0)
        res = 4;
    return res;
}



//По заданному номеру четверти показать диапазон возможных координат точек в этой четверти (х и у)

// try
// {
//     Console.WriteLine("Введите номер четверти");
//     int num = Convert.ToInt32(Console.ReadLine());
//     CheckQuat(num);
//     Console.WriteLine(CheckQuat2(num));

// }
// catch
// {
//     Console.WriteLine("Нужно было ввести целое число");
// }


// void CheckQuat(int num)
// {
//     if (num == 1)
//         Console.WriteLine("Координаты X>0 и Y>0");
//     else if (num == 2)
//         Console.WriteLine("Координаты X<0 и Y>0");
//     else if (num == 3)
//         Console.WriteLine("Координаты X<0 и Y<0");
//     else if (num == 4)
//         Console.WriteLine("Координаты X>0 и Y<0");
//     else
//         Console.WriteLine("Введено некорректное значение");
// }

// string CheckQuat2(int num)
// {
//     string res = "Введено некорректное значение";
//     if (num == 1)
//         res = "Координаты X>0 и Y>0";
//     else if (num == 2)
//         res = "Координаты X<0 и Y>0";
//     else if (num == 3)
//         res = "Координаты X<0 и Y<0";
//     else if (num == 4)
//         res = "Координаты X>0 и Y<0";
//     return res;
// }



//1)Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21
//Даниил Пузиков 20:10
// Console.WriteLine("Введите координаты X и Y для первой точки");
// int x1= Convert.ToInt32(Console.ReadLine());
// int y1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты X и Y для второй точки");
// int x2= Convert.ToInt32(Console.ReadLine());
// int y2= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(distance(x1,y1,x2,y2));


// double distance(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
// }


//2)Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// kvadrat(n);

// void kvadrat (int n)
// {
//     int s = 0;
//     for(int i = 1; i<=n; i++)
//     {
//         s=i*i;
//         Console.Write($"{s}, ");
//     }
// }



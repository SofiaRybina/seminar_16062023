// Задача 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

void FindQuater(int X, int Y)
{
    if(X > 0 && Y > 0)
        {
            Console.WriteLine($"x={X},y={Y} -> Quater 1");
        }
        else if(X < 0 && Y < 0)
        {
            Console.WriteLine($"x={X},y={Y} -> Quater 3");
        }
        else if(X > 0 && Y < 0)
        {
            Console.WriteLine($"x={X},y={Y} -> Quater 4");
        }
        else if(X < 0 && Y > 0)
        {
            Console.WriteLine($"x={X},y={Y} -> Quater 2");
        }
        else 
        {
            Console.WriteLine($"x={X},y={Y} -> Wrong!");
        }
}

int x = Prompt("Input x: ");
int y = Prompt("Input y: ");
Console.WriteLine();
Console.WriteLine(x + " " + y);
FindQuater(x,y);

//Альтернативный способ

// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int xCoordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yCoordinate = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(xCoordinate, yCoordinate);
// string result = quarter > 0
// ? $"Указанные координаты соответствуют четверти {quarter}"
// : "Введены некорректные координаты";

// Console.WriteLine(result);

// int Quarter(int x, int y)
// {
// if(x > 0 && y > 0) return 1;
// if(x < 0 && y > 0) return 2;
// if(x < 0 && y < 0) return 3;
// if(x > 0 && y < 0) return 4;
// return 0;
// }

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
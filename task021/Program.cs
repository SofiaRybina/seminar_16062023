// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int x1 = Prompt("Input x1: ");
int y1 = Prompt("Input y2: ");
Console.WriteLine();

int x2 = Prompt("Input x1: ");
int y2 = Prompt("Input y2: ");
Console.WriteLine();

Console.WriteLine($"X1={x1},Y1={y1}");
Console.WriteLine($"X2={x2},Y2={y2}");

double AB = Math.Sqrt(((x2-x1)*(x2-x1)) + (y2-y1)*(y2-y1));
Console.WriteLine($"AB -> {AB}");

//тестовый коммит
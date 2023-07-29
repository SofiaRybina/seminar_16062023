// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Math.Abs(Convert.ToInt32(value));
    return result;
}

void GetNum(int num)
{
    int i = 1;
    while(i <= num)
    {
        if(i == 1)
        {
            Console.Write(((i * i)));
            i++;
        }
        else
        {
            Console.Write(","+ " "+ (i * i));
            i++;
        }
    }
}

int n = Prompt("Input N: ");
GetNum(n);

//Альтернативный код

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 1)
// {
// Console.WriteLine("Некорректные данные");
// return;
// }
// SquareTable(number);

// void SquareTable(int num)
// {
// for (int i = 1; i <= num; i++)
// {
// int square = i * i;
// Console.WriteLine($"{i} {square}");
// }
// }

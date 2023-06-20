// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Input num of quater: ");
FindNumQuater(number);


void FindNumQuater(int num)
{
    if(num == 1)
        {
            Console.WriteLine("X > 0, Y > 0 -> Quater 1");
        }
        else if(num == 3)
        {
            Console.WriteLine("X < 0, Y < 0 -> Quater 3");
        }
        else if(num == 4)
        {
            Console.WriteLine("X > 0, Y < 0 -> Quater 4");
        }
        else if(num == 2)
        {
            Console.WriteLine("X < 0, Y > 0 -> Quater 2");
        }
        else 
        {
            Console.WriteLine("-> Wrong!");
        }
}
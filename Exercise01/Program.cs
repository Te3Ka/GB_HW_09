/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

void PrintNumber(int num)
{
	if (num == 1)
	{
		Console.WriteLine($"{num}");
	}
	else
	{
		Console.Write($"{num}, ");
		PrintNumber(num - 1);
	}
}


//Получение числа от пользователя.
int GetNumber()
{  
    Console.Write($"Введите значение N =  ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Программа не может быть выполнена. Введите заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

Console.WriteLine("Программа выводит все натуральные числа от введённого N до 1.\n");
PrintNumber(GetNumber());
Author();
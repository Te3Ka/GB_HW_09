/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

int SumNumber(int m, int n)
{
	if (m == n)
        return m;
    else if (m > n)
    {
        return m + SumNumber(m - 1, n);
    }
    else if (m < n)
    {
        return n + SumNumber(m, n - 1);
    }
    else
    {
        return -1;
    }
}


//Получение числа от пользователя.
int GetNumber(string name)
{  
    Console.Write($"Введите значение {name} =  ");
    int.TryParse(Console.ReadLine(), out int num);
    while (num <= 0)
    {
        Console.WriteLine("Число меньше 1! Это не натуральное число. Введите заново: ");
        int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

Console.WriteLine("Программа выводит сумму натуральных чисел в промежутке между введёнными M и N (включая M и N).\n");
int M = GetNumber("M");
int N = GetNumber("N");
if (M > N)
    Console.WriteLine($"Сумма чисел между {N} и {M} = {SumNumber(M, N)}");
else
    Console.WriteLine($"Сумма чисел между {M} и {N} = {SumNumber(M, N)}");
Author();
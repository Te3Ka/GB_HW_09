/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

//Функция Аккермана
int FunctionAckerman(int m, int n)
{

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

Console.WriteLine("Программа выводит значение функции Аккермана по введённым числам M и N.\n");
int M = GetNumber("M");
int N = GetNumber("N");
Console.WriteLine($"Функция Аккермана для чисел {M} и {N} = {FunctionAckerman(M, N)}");
Author();
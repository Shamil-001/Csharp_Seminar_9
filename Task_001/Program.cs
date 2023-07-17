// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNum(int firstNum, int secondNum)
{
    int sum = 0;
    for (int i = firstNum; i <= secondNum; i++)
    {
        sum += i;
    }
    return sum;
}

int firstNum = ReadInt("Введите первое число: ");
int secondNum = ReadInt("Введите второе число: ");
int sum = SumNum(firstNum, secondNum);

Console.WriteLine("Сумма натуральных элементов от {0} до {1}: {2}", firstNum, secondNum, sum);

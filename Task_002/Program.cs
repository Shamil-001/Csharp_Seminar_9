// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int firstNum, int secondNum)
{
    if (firstNum == 0)
        return secondNum + 1;

    if (secondNum == 0)
        return Ackermann(firstNum - 1, 1);

    return Ackermann(firstNum - 1, Ackermann(firstNum, secondNum - 1));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int firstNum = ReadInt("Введите первое значение: ");
int secondNum = ReadInt("Введите второе значение: ");

int result = Ackermann(firstNum, secondNum);

Console.WriteLine($"Результат: {result}");

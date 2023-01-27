//Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.

int InputNum(string message)
{
    System.Console.Write(message + ": ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int number = InputNum("Введите число");
for (int i = 1; i <= number; i++)
{
    int result = i*i*i;
    System.Console.Write($"{result} ");
}
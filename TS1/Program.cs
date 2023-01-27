
int InputNum(int message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

bool CheckNum(int num)
{
    if (num > 9999 && num < 100000)
    {
        return true;
    }
    return false;
    Console.WriteLine("Некорректное число!");
}

int Calculate(int number)
{
    int step1 = number / 10000;
    int step2 = number % 10;
    if (step1 == step2)
    {
        number = number / 10;
        int step3 = number / 100;
        int step4 = number % 10;
        if (step3 == step4)
        {
            System.Console.WriteLine($"{number} является палиндромом");
        }
    }
    else
    {
        System.Console.WriteLine($"{number} не является палиндромом");
    }
}


    
//Напишите программу, которая принимает
//на вход координаты 3 точек и находит расстояние между ними в 3D 
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double dotX1 = InputCoords("Введите X1 для первой точки");
double dotY1 = InputCoords("Введите Y1 для первой точки");
double dotZ1 = InputCoords("Введите Z1 для второй точки");
double dotX2 = InputCoords("Введите X2 для второй точки");
double dotY2 = InputCoords("Введите Y2 для второй точки");
double dotZ2 = InputCoords("Введите Z2 для второй точки");

double lengthBetwDot = findLength(dotX1, dotY1, dotX2, dotY2, dotZ1, dotZ2);
System.Console.Write($"Растояние между точками равно {lengthBetwDot:F2}"); //F2 округление до двух знаков после запятой

double InputCoords(string message)
{
    System.Console.Write(message + ": ");
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}

double findLength(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double dotOneX = Math.Pow(x2 - x1, 2);
    double dotOneY = Math.Pow(y2 - y1, 2);
    double dotOneZ = Math.Pow(z2 - z1, 2);
    double gipotenusa = Math.Sqrt(dotOneX + dotOneY + dotOneZ);
    return gipotenusa;
}


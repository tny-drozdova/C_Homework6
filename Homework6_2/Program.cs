// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Examples: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter the values for the first line (y = k1 * x + b1):");
double k1 = GetUserInput("k1");
double b1 = GetUserInput("b1");

Console.WriteLine("Enter the values for the second line (y = k2 * x + b2):");
double k2 = GetUserInput("k2");
double b2 = GetUserInput("b2");

if (k1 == k2)
{
    Console.WriteLine("The lines are parallel and do not intersect.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);  //The formula find the coordinates of X;
    double y = k1 * x + b1;   //The formula find the coordinates of Y;
    Console.WriteLine($"The point of intersection is ({x}; {y})");
}


double GetUserInput(string variableName)
{
    Console.Write($"Enter the value for {variableName}: ");
    string input = Console.ReadLine();
    double value;

    while (!double.TryParse(input, out value))  //We converting and passing a string (input) into a double (value) by using 'OUT' parameter.
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        Console.Write($"Enter the value for {variableName}: ");
        input = Console.ReadLine();
    }
    return value;
}


// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  Examples:   0, 7, 8, -2, -2 -> 2
//              1, -7, 567, 89, 223-> 3


// Firts desicion:
Console.Write("Enter the number of values: ");
//string value = Console.ReadLine();
int m = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write($"Enter value {i + 1}: ");
    int number = Convert.ToInt32(Console.ReadLine());       

    if (number > 0)
        count++;
}

Console.WriteLine($"The count of numbers greater than 0 is: {count}");

Console.ReadLine();



/* 

// The IDEAL desicion:
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($" Enter #{i + 1} element: "); //the number will be inclusive of min and max to that element
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
    System.Console.WriteLine($"element[{i}] = {array[i]}");
}
}

int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
    if (array[i] > 0)
    {
        count++;
    }
}
return count;
}

int lenght = Prompt ("Enter a number of elements > ");
int [] array;
array = GenerateArray(lenght);
PrintArray(array);
System.Console.WriteLine($"The munber of elements larger than 0 is {CountPositiveNum(array)}");

*/
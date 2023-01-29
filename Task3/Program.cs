// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

void PrintArray(int[] array)                    
{
    Console.Write(String.Join(' ', array));
    Console.WriteLine();
}

int[] CreateArray (int size, int min, int max)
{
    int[]array = new int[size];
    for (int i=0; i< array.Length; i++)    
    array[i] = new Random().Next(min, max+1);
    return array;
}
/*
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int size =ReadInt("Для задания массива введите длинну: ");
int min =ReadInt("Для задания массива введите  меньшee трёхзначное число: ");
int max =ReadInt("Для задания массива введите большее трёхзначное число: ");
*/

int[] massiv= CreateArray (15, 123,321);
Console.Write("Ваш массив: ");
PrintArray(massiv);
int searchChet =0;
int searchNechet =0;
for (int i=0; i< massiv.Length; i++) 

    if (massiv[i] %2==0 )  
    {
        searchChet =searchChet+1;
    }
    else
    {
        searchNechet=searchNechet+1;
    }

Console.WriteLine ("Чётное число в массиве встречается " + searchChet +  " раз");
Console.WriteLine ("Нечётное число в массиве встречается " + searchNechet +  " раз");
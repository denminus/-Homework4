// Найти сумму чисел одномерного массива стоящих на нечетной позиции
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

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int size =ReadInt("Для задания массива введите длинну: ");
int min =ReadInt("Для задания массива введите меньшую часть диапазона: ");
int max =ReadInt("Для задания массива введите большую часть диапазона: ");

int[] massiv= CreateArray (size, min,max);
Console.Write("Ваш массив: ");
PrintArray(massiv);
int sum =0;
for (int i=0; i< massiv.Length; i++) 

    if (i%2 ==1 )  
    {
        sum=sum+massiv[i];
    }

Console.WriteLine ("сумма чисел на нечётной позиции массива равна " + sum);


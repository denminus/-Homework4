// Определить, присутствует ли в заданном массиве, некоторое число

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


void Swap<T> (ref T first, ref T second) 
{ 
    T tmp =first;
    first = second;
    second = tmp;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int size =ReadInt("Для задания массива введите длинну: ");
int min =ReadInt("Для задания массива введите меньшую часть диапазона: ");
int max =ReadInt("Для задания массива введите большую часть диапазона: ");
int value =ReadInt("Введите искомое число: ");

if (min>max)
{
    Swap(ref min, ref max);
}

int[] massiv= CreateArray (size, min,max);
Console.Write("Ваш массив: ");
PrintArray(massiv);
int search =0;
for (int i=0; i< massiv.Length; i++) 

    if (massiv[i] ==value )  
    {
        search =search+1;
    }

if (search>0) Console.WriteLine ("Искомое число " + value+ " имеется в массиве " + search+ " раз");
if (search==0) Console.WriteLine ("Искомое число " + value+ " отсутствует в массиве");
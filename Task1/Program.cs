// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void PrintArray(int[] array)                     
{
    Console.Write(String.Join(' ', array));
    Console.WriteLine();
}


int[] CreateArray (int size, int a)
{
    int[]array = new int[size];
    for (int i=0; i< array.Length; i++)    
    array[i] = a;
    return array;
}

int[] CreateArrayRandom (int size, int min, int max)
{
    int[]array = new int[size];
    for (int i=0; i< array.Length; i++)    
    array[i] = new Random().Next(min, max+1);
    return array;
} 
int size =8;
int min =0;
int max = 1;


 for (int i=0; i< 2; i++)
 {
    int[] massiv= CreateArray (size, i);
    Console.WriteLine();
    PrintArray(massiv);

 }
int [] massiv01 = CreateArrayRandom(size, min,max);
Console.Write("Массив 0 и 1:  ");
PrintArray(massiv01);







// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
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
int[] massiv= CreateArray (123,0,123);
Console.WriteLine("Ваш массив: ");
PrintArray(massiv);
int search =0;

for (int i=0; i< massiv.Length; i++) 
{
    int j=10;
    while (j<=99)
    {
        if (massiv[i] ==j )  
        {
            search =search+1;
        }
        j++;

    }

}
    

Console.WriteLine ("Количество элементов из отрезка [10,99], в данном массиве  встречается " + search +  " раз");


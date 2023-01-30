// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void PrintArrayDouble(double[] array)                     
{
    Console.Write(String.Join(' ', array));
    Console.WriteLine();
}

double[] CreateArrayDouble (int size, double min, double max)
{
    double[]array = new double[size];
    for (int i=0; i< array.Length; i++)    
    array[i] = (new Random().NextDouble()*(max-min))+min;
    return array;
}

double ReadDouble(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double DifArray (double[] array) // сортировка и диф большего- меньшего
{
           
    for (int i=0; i< array.Length-1; i++)
    {
        int minPosition=i;
        for (int j=i+1; j< array.Length; j++)
        {
            if (array[j]<array[minPosition])
            {
                minPosition=j;
            }
        }
        double temp=array[i];
        array[i]= array[minPosition];
        array[minPosition]=temp;
    }

    
    double dif= array[array.Length-1] - array[0];
    return dif;


}

Console.Write("Введите длинну массива: ");
int size =int.Parse(Console.ReadLine()!);

double min =ReadDouble("Введите левую часть диапазона: ");
double max =ReadDouble("Введите правую часть диапазона: ");

double[]Massiv= CreateArrayDouble (size, min, max);



Console.Write("Ваш массив: ");
PrintArrayDouble(Massiv);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементом массива: ");
double razn= DifArray(Massiv);
Console.WriteLine(razn);
//PrintArrayDouble(Massiv);
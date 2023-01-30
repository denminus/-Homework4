// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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


int LenMassiv= massiv.Length;
int[]massivRevers = new int[LenMassiv];
for (int i=0; i< LenMassiv; i++) 
{    
     massivRevers[i] = massiv[(LenMassiv-1)-i];
}


int SizeMassivLR=0;
if(LenMassiv%2==0)
{
    SizeMassivLR= LenMassiv/2;
}
else 
{
    SizeMassivLR= (LenMassiv-1)/2;
}

int[]NewMassivL = new int[SizeMassivLR];
int[]NewMassivR = new int[SizeMassivLR];
int[]MassivProd = new int[SizeMassivLR];

for (int i=0; i< SizeMassivLR; i++) 
{
     NewMassivL[i] = massiv[i];
     NewMassivR[i] = massivRevers[i];
     MassivProd[i] =NewMassivL[i] * NewMassivR[i];

}    

Console.Write("Произведение пар  элементов в одномерном массиве: ");
PrintArray(MassivProd);   
//PrintArray(NewMassivL); 
//PrintArray(NewMassivR); 

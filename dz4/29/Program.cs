// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
int items = 8;
int[] array = new int[items];
FillArray (array);
PrintArray (array);
void FillArray(int [] arr)
{
Random rnd = new Random();
for (int i = 0; i < arr. Length; i=i+1)
{
arr[i] = rnd.Next(100);
}}
void PrintArray(int[ ] arr)
{
for (int i = 0; i < array. Length; i=i+1)
{
Console.Write(array[i] + " ");
}
}


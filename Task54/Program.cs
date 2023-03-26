// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Prompt (string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());  
}

int [,] GetNewArray(int m, int n, string text)
{
   Console.WriteLine(text);   
    int [,] newArray = new int [m,n];
    for (int i =0; i < newArray.GetLength(0);i++)
     {
        for (int j =0; j < newArray.GetLength(1); j++)
         {
            newArray[i,j] = new Random().Next(1,11);
            Console.Write(newArray[i,j]+"\t");
         }
    Console.WriteLine();
     }
    return newArray;
}

void ArraySort (int [,] array) // сортировка методом пузырька
{
   for (int i = 0; i < array.GetLength(0);i++)
   {
     for (int j = 0; j < array.GetLength(1); j++)
     { 
       for (int k =0; k < array.GetLength(1);k++ )
        { if (array[i,j] >=  array[i,k])
          {
            int tmp = array[i,j]; // замена элементов массива
            array[i,j] = array[i,k];
            array[i,k] = tmp;
          } 
        }
     }
     
   }
}

void PrintArray(int [,] array, string text)
{ 
   Console.WriteLine(text);
    for (int i = 0; i < array.GetLength(0);i++)
   {
     for (int j = 0; j < array.GetLength(1); j++)
     { 
        Console.Write(array[i,j]+"\t");
     }
Console.WriteLine();
   }
}    


int m = Prompt("Введите количество строк");
int n = Prompt("Введите количество столбцов");
int [,] array = GetNewArray (m,n, "Ваш исходный массив:");
ArraySort(array);
PrintArray(array, "Ваш новый массив:");


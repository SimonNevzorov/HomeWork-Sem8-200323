// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Prompt(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}


int [,] CreateArray(int n)
{ 
    int[,] array = new int[n,n];
  // for(int i =0; i < array.GetLength(0); i++)
  //   {
  //       for (int j =0; j<array.GetLength(1);j++)
  //     {
         
  //        Console.Write(array[i,j]+" ");
  //     }
  //   Console.WriteLine();
  //   }
   return array;
}

int [,] FillArray (int [,]array)
{
  int cell =1;
  int i =0;
  int j =0;

  while (cell <= array.GetLength(0)*array.GetLength(1))
  {
    array[i,j]= cell;
    cell++;
    if (i<=j+1 && i+j<array.GetLength(1)-1)
      {
         j++; 
      }
    else if (i<j && i+j >= array.GetLength(0)-1)
      {
        i++;
      }
    else if (i>=j && i+j > array.GetLength(1)-1)
      {
        j--;
      }
    else 
      {
        i--;
      }  
  }


return array;
}

void PrintArray(int [,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j<array.GetLength(1);j++)
      {
        if (array[i,j]<10)
         Console.Write("0"+array[i,j]+" ");
        else 
        Console.Write(array[i,j]+" "); 
      }
    Console.WriteLine();
    }

}

int z = Prompt("Введите размерность квадратной матрицы");
int [,] array1 = CreateArray(z);
// FillArray(array1);
PrintArray(FillArray(array1));

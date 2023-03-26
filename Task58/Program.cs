//  
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateArray(int m, int n)
{ 
    int[,] array = new int[m,n];
  for(int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j<array.GetLength(1);j++)
      {
         array[i,j] = new Random().Next(1,11); //- заполняем массив случайными числами
         Console.Write(array[i,j]+"\t");
      }
    Console.WriteLine();
    }
   return array;
}

int [,] MultMatrix (int [,] array1, int [,] array2)
{   Console.WriteLine("Произведение матриц равно:");
    int [,] newArray = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i =0; i < newArray.GetLength(0);i++)
     { 
        for (int j =0; j < newArray.GetLength(1);j++)

        {
            newArray[i,j] = 0;
            for (int d =0; d < array1.GetLength(1);d++)
            {
                newArray [i,j] += (array1[i,d]*array2[d,j]);
            }
        Console.Write(newArray[i,j] + "\t");
        }
     Console.WriteLine();
     }
    return newArray;
}

int m = Prompt("Введите количество строк 1 матрицы");
int n = Prompt("Введите количество столбцов 1 матрицы");
Console.WriteLine();
int [,] array1 = CreateArray(m,n);
int a = Prompt("Введите количество строк 2 матрицы");
int b = Prompt("Введите количество столбцов 2 матрицы");
Console.WriteLine();
int [,] array2= CreateArray(a,b);
if ( n !=a) 
  Console.WriteLine("Матрицы перемножить нельзя!");
else
Console.WriteLine();
MultMatrix(array1, array2);  




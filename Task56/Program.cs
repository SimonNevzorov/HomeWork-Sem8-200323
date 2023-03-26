// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void SumLine (int [,] array)
{
  int [] SumLine = new int [array.GetLength(0)]; // cоздаем одномерный массив (с размером количсетва строк двмерного), в значения которого заносим построчную сумму двмерного массива, чтобы потом сравнивать значения
 
  for (int i =0; i < array.GetLength(0);i++)
   {
    for (int j =0; j <array.GetLength(1);j++)
     {
        SumLine[i] += array[i,j];
     }
  }    
int MinLine=0; // Задаем, что первый элемент массива - минимальный. Дальше проверем по индексам, есть ли меньшие занчения и если есть, передаем их в MinLine
for (int i =0; i < SumLine.Length;i++)
 if (SumLine[MinLine] > SumLine[i]) MinLine=i;
 Console.WriteLine($"Строка с наименьшей суммой элементов имеет номер {MinLine+1}"); // Добавляем к индексу строки 1 , так как начали с нулевого индекса

}

int m = Prompt("Введите количество строк массива");
int n = Prompt("Введите количество столбцов массива");
int [,] array1 = CreateArray(m,n);
SumLine(array1);

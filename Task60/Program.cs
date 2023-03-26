// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Prompt(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int [,,] CreateArray(int m, int n, int z)
{ 
    int[,,] array = new int[m,n,z];
  for(int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j<array.GetLength(1);j++)             
          {
            for (int p = 0; p < array.GetLength(2);p++)
                {
                    array[i,j,p] = new Random().Next(10,100); //- заполняем массив случайными числами
                 
                Console.Write($"{array[i,j,p]} ({i},{j},{p})" +"\t");
                //  Console.Write(array[i,j,p]+"\t");
                }
          }
    Console.WriteLine();
    }
    //Console.WriteLine();

   return array;
}

int m = Prompt("Введите количество строк  ");
int n = Prompt("Введите количество столбцов");
int z = Prompt("Введите количество измерения");

Console.WriteLine();
int [,,] array1 = CreateArray(m,n,z);
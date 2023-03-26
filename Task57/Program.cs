// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// 5
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());

int [,] CreateArray(int n,int m) // функция по созданию и заполнению нового массива
{
    int [,] array = new int [n,m];
    for (int i = 0; i < array.GetLength(0);i++)
    { for (int j = 0; j < array.GetLength(1);j++)
    {
        array[i,j] = new Random().Next(0,10);
        Console.Write(array[i,j]+"\t");
    }
    Console.WriteLine();

    }
return array;
}

int [] ExchangeArray(int [,] array) 
{   int count =0;
    int [] newArray = new int [array.GetLength(0)*array.GetLength(1)]; // перевод двумерного массива в одномерный!
    for (int i =0; i<array.GetLength(0);i++)
    {
      for (int j=0; j < array.GetLength(1);j++)  
        {
            newArray[count] = array[i,j]; //обращаемся к каждому элементу двумерного массива и присваиваем его в одномерный
            count++; // переходим к следюущему элементу одномерного массива!
        }   
    }
    return newArray;

}

void FindNum (int[] newArray)
{
    int count =1;
    Array.Sort(newArray); // Сортируем массив от меньшего к большему
    Console.WriteLine(String.Join(",", newArray));
    Console.WriteLine();
    int figure = newArray[0]; // присваиваем переменной первое значение нашего массива, чтобы начать с чем-то сравнивать
    for (int i =1; i < newArray.Length;i++)
    {
      if (figure ==newArray[i])
      count++;
    
    else 
     {
        Console.WriteLine($"Количество {figure} равно {count} ");
        count =1;
        figure = newArray[i];
     }
    }
    Console.WriteLine($"Количество {figure} равно {count} ");
}




int [,] array1 = CreateArray(n,m);
int [] array2 =ExchangeArray(array1);

FindNum (array2);

// Ниже алтернативное решение через случайные величины строк и столбцов массива

int [,] CreateNewArray()
{
int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);
int [,] matrix = new int [m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(1, 10);
}

}
return matrix;
}


 void PrintArray(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
 {
  for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + "\t");
    }
   Console.WriteLine();
 }

}



// int [,] matrix = CreateNewArray();
// PrintArray(matrix);
// int [] array1 = ExchangeArray(matrix);
// FindNum(array1);




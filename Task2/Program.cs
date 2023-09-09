// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] AddArray()
{
    Console.WriteLine("Введите длину массива ");
    int lengthArray = int.Parse(Console.ReadLine());
    int getArray = int.Parse(Console.ReadLine());
    int[,] array = new int[lengthArray, getArray];
    return array;
}

int[,] array = AddArray();
int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
Console.WriteLine("Массив _______________________________");
int[,] array1 = FillArray(array);
Console.WriteLine();

void MultiArray(int[,] array1)
    {
        int count1 = -1, count2 = -1, min = 100;
        int[,] newArray = new int[array1.GetLength(0)-1, array1.GetLength(1)-1];
        for(int i = 0; i < array1.GetLength(0); i++) {
            for(int j = 0; j < array1.GetLength(1); j++) {
                if (array[i,j] == min){
                    continue;
                } else if (array[i,j] < min) {
                    min = array[i,j];
                    count1 = i;
                    count2 = j;
                }
            }
        }
        Console.WriteLine("Минимальное число - " + min + " на " + (count1+1) 
        + " строке, в " + (count2+1) + " столбце");
        Console.WriteLine("Результат _______________________________");
        int k = 0, l = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (count1 != i && count2 != j){
                newArray[k, l] = array[i, j];
                Console.Write(newArray[k, l] + " ");
                l++;
            }
        }
        l = 0;
        if (count1 != i){
            k++;
            Console.WriteLine();
        }
    }
}

MultiArray(array1);
    
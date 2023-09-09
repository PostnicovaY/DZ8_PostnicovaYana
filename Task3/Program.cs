// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];

void FillArray(int[,] array){
    int count = 1, k = 0, l = 0;
    while (count <= array.GetLength(0) * array.GetLength(1)){
        array[k, l] = count;
        count++;
        if (k <= l + 1 && k + l < array.GetLength(1) - 1)
            l++;
        else if (k < l && k + l >= array.GetLength(0) - 1)
            k++;
        else if (k >= l && k + l > array.GetLength(1) - 1)
            l--;
        else
            k--;
    }
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

FillArray(array);

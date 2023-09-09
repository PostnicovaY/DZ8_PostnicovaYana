// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] AddArray(string text)
{
    Console.WriteLine(text);
    int lengthArray = int.Parse(Console.ReadLine());
    int getArray = int.Parse(Console.ReadLine());
    int[,] array = new int[lengthArray, getArray];
    return array;
}

int[,] array = AddArray("Введите размеры первой матрицы");
int[,] arrayArr = AddArray("Введите размеры второй матрицы");

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
Console.WriteLine("Первый _______________________________");
int[,] array1 = FillArray(array);
Console.WriteLine("Второй _______________________________");
int[,] array2 = FillArray(arrayArr);
Console.WriteLine("Произведение _______________________________");

// Если массивы равны по столбцам и строкам
if (array1.GetLength(0) == array2.GetLength(0) && array1.GetLength(1) == array2.GetLength(1)){
    void MultiArray(int[,] array1, int[,] array2){
        var matrix = new int[array1.GetLength(0), array1.GetLength(1)];

        for (var i = 0; i < array1.GetLength(0); i++){
            for (var j = 0; j < array1.GetLength(1); j++){
                matrix[i, j] = 0;

                for (var k = 0; k < array1.GetLength(0); k++){
                    matrix[i, j] += array1[i, k] * array2[k, j];
                }
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    MultiArray(array1, array2);
}
else{
// Если массивы не равны по столбцам и строкам
    Console.WriteLine("Умножение не возможно! Размеры матриц не совпадают.");
}

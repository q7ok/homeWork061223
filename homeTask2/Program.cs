/* Задайте двумерный массив. Напишите программу, которая поменяет
местами первую и последнюю строку массива. */

// 4 3 1        4 6 2
// 2 6 9   =>   2 6 9
// 4 6 2        4 3 1

int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray (int [,] array) {
    
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void CangedRows (int [,] array) {

    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (i == 0) {
                Console.Write(array[array.GetLength(0) - 1,j] + " ");
            }
            else if (i == array.GetLength(0) - 1) {
                Console.Write(array[0,j] + " ");
            }
            else {
                Console.Write(array[i,j] + " ");
            }
        }
        Console.WriteLine();
    }   
}

Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row, col, min, max);
Show2dArray(created2dArray);
Console.WriteLine();
CangedRows(created2dArray);
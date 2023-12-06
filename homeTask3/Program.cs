/* Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов. */

// 4 3 1    => Строка с индексом 0
// 2 6 9
// 4 6 2

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

void ShowArray (int [] array) {
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

int [] ArraySumOfLines(int [,] array) {
    int [] createdArray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++ ) {
        int sumOfLine = 0;
        for (int j = 0; j < array.GetLength(1); j++) {
            sumOfLine = sumOfLine + array[i, j];
        }
        createdArray[i] = sumOfLine;
    }

    return createdArray;
}

void ShowMinSumLine (int [] array) {
    int minNumber = array[0];
    int minIndex = 0;

    for (int i = 0; i < array.Length; i++){
        if (minNumber > array[i]) {
            minNumber = array[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Строка с индексом {minIndex}");

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
int [] arraySumOfLines = ArraySumOfLines(created2dArray);
ShowArray(arraySumOfLines);
Console.WriteLine();
ShowMinSumLine(arraySumOfLines);

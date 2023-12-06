/* Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же 
указание, что такого элемента нет.*/

// 4 3 1    (1, 2) => 9
// 2 6 9 

int [,] Create2dArray(int row, int col ){
    int [,] array = new int [row,col];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            array[i,j] = i + j;
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

void ShowTheElement (int [,] array, int row, int col) {
    if (row < array.GetLength(0) && col < array.GetLength(1)) {
        Console.WriteLine($"Елемент равен: {array[row, col]}");
    } else {
        Console.WriteLine("Такого элемента нет!");
    }
}

Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine());


int [,] created2dArray = Create2dArray(4, 4);
Show2dArray(created2dArray);
Console.WriteLine();
ShowTheElement(created2dArray, row, col);

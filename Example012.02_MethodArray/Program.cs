int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)    // метод вывода данного массива на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // метод сортировки нашего массива
{
    for (int i = 0; i < array.Length - 1; i++) // блок нахождения минимальной позиции
    {
        int minPosition = i;
        // ниже блок, который ищет максимальный элемент
        for (int j = i + 1; j < array.Length; j++) // начинаем прокручивать массив уже со следующей позиции
        {   //если элемент array[i] меньше пердполагаемого элемента на минимальной позиции, то эту позицию нужно сохранить
            if (array[j] < array[minPosition]) minPosition = j; // если поменять знак < на >, то массив будет от большего
                                                                                                            // к меньшему
        }
        int temporary = array[i]; // меняем минимальную позицию с той позицией на которой находимся
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
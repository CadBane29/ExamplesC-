// Возможности записи массивов:
// ТИП ДАННЫХ[] ИМЯ = {Значение1, Значение2, ...}
// int[] array = { 9, 28, 1, 32, 1990 };

// int[] array = { 0, 0, 0, 0, 0};
// int[] array = new int[5];
// int[] array = new int[] { 0, 0, 0, 0, 0 };
// int[] array = new int[5] { 1, 0, 2, 0, 3 };

// Функции в програмировании

// ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ...])
// {
//     Тело Метода
//     return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }

// f(x) = x*x + 1;

// double f (double x) // возвращаемыйТип (типАргумента имяАргумента)
// { // телоМетода
//     double result = x * x + 1;
//     return result; // возвращаемоеЗначение
// }

// double f(double x)
// {
//     result x * x + 1;
// }

void FillArray(int[] collection) // void - метод который ничего не возвращает
{
    int length = collection.Length; // Длина массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Для того чтобы понять корректное ли значение было введено, меняем position на -1
                        // и если числа в массиве нет, то выводится та самая -1.

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Создаем новый массив, в данном случае из 10 элементов, по умолчанию [0]

FillArray(array);
array[4] = 1;
array[6] = 2;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
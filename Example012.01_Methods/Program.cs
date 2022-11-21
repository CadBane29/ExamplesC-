// Create a calculator.

// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ==== Работа с текстом 
// Дан текст. В тексте нужно все пробелы заменить черточками, - что значит "дан текст" и что заначит "черточками"?
// маленькие буквы "к" заменить большими "К", - какой алфавит должен использоваться в работе?
// а большие "С" заменить маленькими "с". 

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] - r  // мы можем обратиться к какому-то символу строки [] 

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;  // заводим пустую строку
    int length = text.Length; // для получения длины нашей строки
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";// если текущий символ совпал с тем, который мы хотим заменить
        else result = result + $"{text[i]}"; // если совпадений не найдено, то наш результат нужно добавить символ, который и был
    }
    return result;
}

string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);

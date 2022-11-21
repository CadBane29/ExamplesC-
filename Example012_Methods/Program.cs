// View 1 - Вид 1 Метод, который не принимает никаких аргументов и ничего не возвращает
// void Method1()
// {
//     Console.WriteLine("Autor ...");
// }
// Method1();

// View 2 Принимают какие-то аргументы, но ничего не возращают

// void Method2(string msg) // в методе можно уточнять к какому аргументу он принадлежит
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Text message."); 

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Text", count: 4);
// Method21(count: 4, msg: "New text");

// View 3 Методы которые возвращают аргументы, но ничего не принимают :

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// View 4 Методы, которые что-то принимают и что-то возвращают в виде каких-то аргументов

// string Method4(int count, string text) // можно поменять название переменной во всем коде нажав F2
// {
//     int i = 0;
//     string result = String.Empty; // пустая строка, можно так же отметить ее "", но правильней будет команда

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "Wash me faster!!! ");
// Console.WriteLine(res);

string Method4(int count, string text) // можно поменять название переменной во всем коде нажав F2
{
    string result = String.Empty; // пустая строка, можно так же отметить ее "", но правильней будет команда

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Wash me faster!!! ");
Console.WriteLine(res);
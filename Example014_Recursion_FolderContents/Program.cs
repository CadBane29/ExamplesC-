// Как посмотреть содержимое папки

void CatalogInfo(string path, string indent = "")
//Метод называется CatalogInfo. В качестве аргумента принимаем
// путь к текущей папке, а в качестве второго аргумента используем искусственный приём,
// позволяющий делать отступы, чтобы примерно видеть структуру папки
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    //Далее получаем информацию о той директории, в которую зашли, по указанному пути

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    //Затем получаем массив всех файлов, находящихся в этой папке, и пробегаем по ним, выводя информацию о текущем 
    //каталоге
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
            //Мы будем рекурсивно заныривать и, соответственно, смотреть все папки, которые
            //получим на этом этапе.
    }

    FileInfo[] files = catalog.GetFiles();
    // После того как закончим вывод папок, получим весь список файлов в
    //текущей директории текущего каталога и покажем их.

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = "C:/Users/Cad Bane/Desktop/HomeWorck/C#/Examples/Examples001_HelloConsole";
CatalogInfo(path);
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }


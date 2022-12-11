﻿// Подсчет чисел Фибоначчи, с помощью рекурсии, не самый лучший выбор


// Здесь я уже привожу пример кода, но с небольшими модификациями. У меня есть две
// переменные, одна из которых будет использоваться для подсчёта вызова рекурсии,
// рекурсивного метода, а вторая — считать количество итераций цикла для итеративного
// подхода. Вызовем демонстрацию для каждого числа.

decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

DateTime dt = DateTime.Now;

Console.ReadLine();

// Здесь я уже привожу пример кода, но с небольшими модификациями. У меня есть две
// переменные, одна из которых будет использоваться для подсчёта вызова рекурсии,
// рекурсивного метода, а вторая — считать количество итераций цикла для итеративного
// подхода. Вызовем демонстрацию для каждого числа.

for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");
    fIte = 0;
    // После того как посчитали очередное число, обнуляем fIte и на новой итерации этого цикла, то
    // есть для следующего числа Фибоначчи, будем иметь новое представление этого значения.
    // Аналогичным образом делаем всё для рекурсивного подхода, только здесь станет выводиться
    // своя переменная и составляться будет она же. Запустим и посмотрим — числа от 10 до 39
    // показались практически моментально.
}

Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
    fRec = 0;
}
Console.ReadLine();
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// При использовании рекурсии вы можете наблюдать следующее: чтобы посчитать 10 число
// Фибоначчи, потребовалось 177 вызовов рекурсивного метода. Когда мы считаем число 11, их
// уже 287. А когда считаем число 38, сразу получается 126 491 971 вызов, и так далее. Как
// видите, у нас сильно меняется время. Засечём время и посмотрим, как ещё можно установить
// время выполнения кода. Запомним время до момента начала подсчёта и выведем на экран
// разницу между временем после введения и подсчёта всех чисел и временем, которое мы
// запомнили.
// Аналогичным образом проделаем расчёт для рекурсивного подхода. Console.ReadLine
// используется, чтобы после запуска можно было сделать консоль больше.
// Итак, посчитав 29 чисел, получилось 45 миллисекунд. Соответственно, чтобы посчитать те же
// числа, используя рекурсивный подход, серверам приходится страдать. И если вашим
// сервисом пользуются миллионы людей, а код написан, мягко говоря, не оптимально, то, с
// одной стороны, пользователь ждёт, а, с другой — приходится ещё оплачивать это впустую
// потраченное на работу серверов время. Как видите, для той же задачи потребовалось почти
// 20 секунд. В одной секунде — 1 000 миллисекунд.
// Таким образом, это одна из обратных сторон рекурсии, когда всё начинает работать плохо.
// Хотя в качестве практической задачи предлагаю написать метод вычисления чисел
// Фибоначчи рекурсивно, но, чтобы он работал в несколько раз быстрее. Попробуйте
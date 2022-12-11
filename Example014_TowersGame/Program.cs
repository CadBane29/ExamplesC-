﻿// Есть замечательная детская игра «Ханойские башни».

// Сделаем шпиль рабочим и возьмём из него текущий блинчик. Вторым аргументом передадим шпиль, на котором должна
// оказаться пирамидка. Далее дадим название нашему промежуточному шпилю, потому что всего их по умолчанию
// три, и укажем, какое количество блинов есть всего.
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();

// Затем запустим метод и посмотрим, что конкретно потребуется выполнить для трёх пирамидок.
// Итак, мы должны с 1 шпиля переместить блины на 3, а с 1 — на 2. Соответственно, с 1 — на 3, с
// 1 — на 2. Дальше с 3 — на 2, с 1 — на 3. С 3 — на 2, с 1 — на 3, далее со 2 — на 1, со 2 — на 3. Со 2
// — на 1, со 2 — на 3. И далее с 1 — на 3. Как видите, наш алгоритм отработал.
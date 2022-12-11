﻿// Бинарное дерево


//Итак, у нас есть одномерный массив, представляющий собой дерево. emp мы используем, чтобы вся строчка помещалась
//без горизонтального скролла.
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11


//Дальше описываем метод, позволяющий делать обход.
// Соответственно, в качестве аргумента указываем ту позицию, с которой будем начинать этот
// обход, и делаем проверку. То есть если наша позиция вылетела за количество элементов,
// хранящихся в нашем дереве, на этом наша рекурсия закончится. Это условие продолжения,
// когда позиция превзошла количество узлов в нашем дереве
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        // Далее считаем позицию левого поддерева.То есть если посмотреть, например, операцию
        // деления, то обнаружим у неё левое поддерево и правое. У операции умножения также есть
        // левая и правая части.Левая часть находится на позиции 2i, или 2 pos в моём случае, а правая
        // — на 2i + 1.

        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        // Затем делаем проверку. Если есть левое поддерево, мы не вылетаем за границы нашего
        // дерева, и элемент, который там хранится, не считается пустым, например, ситуация 6 и 7 здесь
        // обозначена специально, надо рекурсивно запустить обход дерева с текущей позиции.
        Console.Write($"{tree[pos]} ");
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
        // Далее выводим узел, в нашем случае будет значение конкретной операции или числа, и
        // аналогичным образом делаем для правого поддерева. Если правое поддерево существует, и
        // элемент, в который мы попали, непустой, надо рекурсивно запустить обход.
    }
}
InOrderTraversal();

// Статья о способах обхода деревьев
// Оставлю вам статейку о том, какие бывают способы обхода деревьев. В нашем случае есть
// прямой, центрированный и обратный обход. Они примерно одинаковые. Как я говорил
// немного ранее, в рекурсии мы можем просто поменять две строчки местами, и по факту, это
// будет уже абсолютно другой обход. Потренируйтесь на практике и посмотрите, в каком случае
// InOrder становится PreOrder, и так далее.
﻿using Maze;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
Для удобной игры нужно сделать следующие:

1. Нажмите правой кнопкой мыши на панель консоли и выберите СВОЙСТВА.
2. Выберите вкладку ШРИФТ и укажите РАЗМЕР:20, ШРИФТ: Lucida Console.
3. Открыть консоль на весь экран.

Если все сделали нажмите: Enter");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine(@"
Руководство:

1. Движение осуществляется стрелками.
2. Вся информация нужная для прохождения выводится на панель консоли.
3. Stage - этаж на котором вы в данный момент. Всего этажей 5.
4. Враги - O. Отнимают одно здоровье.
5. Врагов с каждым этажом больше и больше.
6. Что бы открыть дверь на следующий этаж нужно взять ключ - K.
7. Ключ появляется в момент открытия последней комнаты на этаже.
8. Дверь всегда находится в последней комнате.
9. Здоровье пополняется на 3 с каждым этажом. И с помощью подбора H на 1.
11. После смерти не перезаходите. Игра сама начнется заново.
12. Если в момент игры захотите выйти нажмите Escape.



Если все понятно нажмите: Enter");
        Console.ReadKey(true);
        Console.Clear();
        Maze.Maze maze = new Maze.Maze();
        maze.StartGame();
    }
}
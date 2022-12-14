**Итоговая проверочная работа**

*Задача:*

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.

*Общее описание решения:*

Ввод исходного массива осуществляется пользователем через ", ". 
Для решения поставленной задачи написаны 2 функции:
- `CheckArrayElement()` - в качестве аргумента принимает массив строк, возвращает также массив строк;
- `PrintStringArray()` - void-функция, выводит на консоль элементы массива строк, ничего не возвращает;

Основной код выполняется внутри блока *`try-catch`*, при возникновении ошибки ввода на консоль выводится сообщение.

Функция `CheckArrayElement()` выполняет следующее:
- создается новый массив *`checkedArray`* с таким же количеством элементов, как исходный массив;
- внутри цикла *`for`* проверяется длина каждого элемента исходного массива, и, если длина меньше или равна 3, тогда элемент исходного массива добавляется в новый массив *`checkedArray`* с таким же индексом, как в исходном;
- при помощи метода *`array.Where`* из массива *`checkedArray`* отбираются элементы, не равные *`null`*, и возвращается массив строк, в котором длина элементов массива меньше или равна 3.
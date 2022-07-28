# Задание

## Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которого меньше или равна 3 символа. Первоначальный массив можно внести с клавиатуры, либо задать на старте выполнения алгоритма. 


# Решение
1. Задаем размерность массива - ввод с клавиатуры
2. Объявляем массив типа строка,который будет содержать в себе массив строк
3. Создаем временный массив, размерностью такой же, как обычный массив, который мы создавали и куда мы будем потом прописывать значения, элементы массива, чьи символы меньше или равны трем
4. В отдельном методе мы создаем массив 
5. Пользователь вводит элементы массива с помощью клавиатуры
6. Далее мы преобразуем метод для преобразования массива, в котором мы передаем параметры:
* массив
* размерность массива
* временный массив

7. Дальше циклом мы проходимся по элементам массива, который мы задали с клавиатуры
8. Если длина символа меньше или равна трем, то мы ее переписывем во временный массив
9. Выводим преобразованный массив, в котором остались элементы, где количество символов меньше или равно трем
10. Передаем массив, размерность, временный массив
11. Вывод в передаем в заявленном формате квадратных скобочек
12. Радуемся решенной задаче
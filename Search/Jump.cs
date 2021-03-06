public static int JumpSearch(int[] array, int x)
{
    int B = (int) Math.Sqrt(array.Length); // вычисляем размер блока(прыжка)
    int start = 0; // начальная позиция блока
    int end = B - 1; // конечная позиция блока

    while (array[end] < x) // пока конец блока меньше искомого элемента
    {
        if (end == array.Length - 1) break; // если дошли до конца массива, выходим

        start = Math.Min(array.Length - 1, start + B); // перемещаем начало блока в право
        end = Math.Min(array.Length - 1, end + B); // перемещаем конец блока в право
    }

    if (x > array[end]) return -1; // если искомый элемент больше, чем последний элемент блока, значит не нашли нужный элемент

    for (int i = end; i >= start; i--) // линейным поиском проходим по найденному блоку
    {
        if (array[i] == x) return i; // если текущий элемент равен искомому, то возвращаем его индекс
    }

    return -1; // если дошли до сюда значит не нашли в массиве искомый элемент
}
    
    
// Нахождение самого левого вхождения
public static int LeftJumpSearch(int[] array, int x)
{
    int B = (int) Math.Sqrt(array.Length); // вычисляем размер блока(прыжка)
    int start = 0; // начальная позиция блока
    int end = B - 1; // конечная позиция блока

    while (array[end] < x) // пока конец блока меньше искомого элемента. Прервемся при равенстве
    {
        if (end == array.Length - 1) break; // если дошли до конца массива, выходим

        start = Math.Min(array.Length - 1, start + B); // перемещаем начало блока в право
        end = Math.Min(array.Length - 1, end + B); // перемещаем конец блока в право
    }


    if (x > array[end]) return -1; // если искомый элемент больше, чем последний элемент блока, значит не нашли нужный элемент

    for (int i = start; i <= end; i++) // линейным поиском слева направо проходим по найденному блоку
    {
        if (array[i] == x) return i; // если текущий элемент равен искомому, то возвращаем его индекс
    }

    return -1; // если дошли до сюда значит не нашли нужного элемента в массиве 
}
    
    
// Нахождение самого правого вхождения
public static int JumpSearch(int[] array, int x)
{
    int B = (int) Math.Sqrt(array.Length); // вычисляем размер блока(прыжка)
    int start = 0; // начальная позиция блока
    int end = B - 1; // конечная позиция блока

    while (array[end] <= x  && end < array.Length - 1 && array[end + 1] <= x) // пока конец блока меньше либо равно искомого элемента и в следующем блоке есть такой же элемент
    {
        start = Math.Min(array.Length - 1, start + B); // перемещаем начало блока в право
        end = Math.Min(array.Length - 1, end + B); // перемещаем конец блока в право
    }

    if (x > array[end]) return -1; // если искомый элемент больше, чем последний элемент блока, значит не нашли нужный элемент

    for (int i = end; i >= start; i--) // линейным поиском справа налево проходим по найденному блоку
    {
        if (array[i] == x) return i; // если текущий элемент равен искомому, то возвращаем его индекс
    }

    return -1; // если дошли до сюда значит не нашли нужного элемента в массиве 
}

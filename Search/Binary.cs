static int BinarySearch(int[] array, int x)
{
  int left = 0;
  int right = array.Length - 1;
  while (left <= right)
  {
    int m = left + (right - left) / 2; // вычисление серединного элемента

    if (array[m] == x) return m; // если серединный элемент равен ключу, то выводим индекс серединного элемента

    if (array[m] < x) left = m + 1; // если серединный элемент меньше ключа, то смещаем левую границу

    else right = m - 1; // если серединный элемент больше ключа, то смещаем правую границу
  }

  return -1; // если не нашли соответствуюшего элемента, возвращаем "-1"
}

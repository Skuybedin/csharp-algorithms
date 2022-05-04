static bool LinearSearch(int[] array, int key)
{
	for (int i = 0; i < array.Length; i++) // проходимся по массиву
	{
		if (array[i] == key) // если текущий элемент равен ключу
		{
			return true; // нашли нужный элемент
		}
	}

	return false; // не нашли нужного элемента
}

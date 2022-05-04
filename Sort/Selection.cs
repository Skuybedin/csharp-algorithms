static void SelectionSort(int[] array)
{
	for (int i = array.Length - 1; i > 0; i--) // на какое место будем ставим наибольший элемент
	{
		int maxIndex = i; // индекс максимального элемента
		for (int j = 0; j < i; j++) // проходим по не отсортированной последовательности
		{
			if (array[j] >= array[maxIndex])// ищем максимальный элемент (неубывание)
			{
				maxIndex = j; // запоминаем индекс
			}
		}

		// если нашли максимальный элемент, отличный от текущего числа
		if (maxIndex != i)
		{
			// меняем местами
			int temp = array[maxIndex];
			array[maxIndex] = array[i];
			array[i] = temp;
		}
	}
}

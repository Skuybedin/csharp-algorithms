static void BubbleSort(int[] array)
{
	for (int i = array.Length - 1; i > 0; i--) // на какое место будем ставим наибольший элемент
	{
		for (int j = 0; j < i; j++) // проходим по не отсортированной последовательности
		{
			if (array[j] > array[j + 1])// если порядок элементов неправильный
			{
				// меняем местами пары
				int temp = array[j];
				array[j] = array[j + 1];
				array[j + 1] = temp;
			}
		}
	}
}

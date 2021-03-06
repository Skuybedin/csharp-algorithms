static void InsertionSort(int[] array)
{
	int buffer;
	for (int i = 1; i < array.Length; i++)
	{
		buffer = array[i]; // запоминаем в буфер элемент, который нужно вставить нужное место

		int j = i; // индекс места, куда будем вставлять buffer

		// пока не дошли до начала массива и очередной элемент больше буфера
		while (j > 0 && array[j - 1] > buffer) // (неубывание)
		{
			array[j] = array[j - 1]; // перемещаем больший элемент на одну позицию вправо
			j--; // передвигаем индекс для просмотра элемента, который стоит левее
		}

		array[j] = buffer; // место найдено, вставить элемент
	}
}

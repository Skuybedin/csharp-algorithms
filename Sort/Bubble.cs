static void BubbleSort(int[] array)
{
	for (int i = array.Length - 1; i > 0; i--) // на какое место будем ставим наибольший элемент
	{
		for (int j = 0; j < i; j++) // проходим по не отсортированной последовательности
		{
			if (array[j] > array[j + 1])// если порядок элементов неправильный (неубывание)
			{
				// меняем местами пары
				int temp = array[j];
				array[j] = array[j + 1];
				array[j + 1] = temp;
			}
		}
	}
}


// Реализация с оптимизацией
static void BubbleSort(int[] array)
{
	for (int i = array.Length - 1; i > 0; i--) // на какое место будем ставим наибольший элемент
	{
		bool flag = false; // false - не было обменов, true - был хотя бы 1 обмен
		for (int j = 0; j < i; j++) // проходим по не отсортированной последовательности
		{
			if (array[j] > array[j + 1])// если порядок элементов неправильный (неубывание)
			{
				// меняем местами пары
				int temp = array[j];
				array[j] = array[j + 1];
				array[j + 1] = temp;
				flag = true; // меняем флажок
			}
		}
		if(flag == false) return; // если значение флага не поменялось, то массив отсортирован. Выходим с функции
	}
}
	

static void RadixSort(int[] array)
{
	int digitCounts = 10; // количество различных цифр 
	int maxLengthOfNumber = 9; // максимальная длина числа
	int p = 1; // степень 10. Нужна для получения очередного разряда 

	List<int>[] pocket = new List<int>[digitCounts]; // массив для распределения элементов по "корзинам"
	for (int i = 0; i < pocket.Length; i++)
		pocket[i] = new List<int>();

	for (int i = 0; i < maxLengthOfNumber; i++) // проходимся по разрядам
	{
		for (int j = 0; j < array.Length; j++) // проходимся по числам
		{
			int index = array[j] / p % 10; // находим индекс корзины
			pocket[index].Add(array[j]); // добавляем
		}

		int count = 0; // на каком месте вставляем в первоначальном массиве
		for (int j = 0; j < digitCounts; j++) // проходимся по корзине
		{
			for (int k = 0; k < pocket[j].Count; k++) // проходимся по элементам очередной корзины
			{
				array[count] = pocket[j][k]; // перебрасываем обратно в первоначальный массив
				count++; // увеличиваем место вставки элемента в первоначальном массиве
			}
			pocket[j].Clear(); // очищаем корзину
		}
		p *= 10; // получаем следующую степень
	}
}

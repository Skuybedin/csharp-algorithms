static void CounterSort()
{
	int k = 10; // ширина используемого диапазона
	int[] counts = new int[k];
	int n = Convert.ToInt32(Console.ReadLine());
	for (int i = 0; i < n; i++)
	{
		int x = Convert.ToInt32(Console.ReadLine());
		counts[x] = counts[x] + 1; // подсчитываем
	}

	for (int i = 0; i < k; i++)
	{
		for (int j = 0; j < counts[i]; j++) // counts[i]-количество чисел i
		{
			Console.Write(i + " ");
		}
	}
}


// Невозрастание
static void CounterSort()
{
	int k = 10; // ширина используемого диапазона
	int[] counts = new int[k];
	int n = Convert.ToInt32(Console.ReadLine());
	for (int i = 0; i < n; i++)
	{
		int x = Convert.ToInt32(Console.ReadLine());
		counts[x] = counts[x] + 1; // подсчитываем
	}

	for (int i = k - 1; i >= 0; i--)
	{
		for (int j = 0; j < counts[i]; j++) // counts[i]-количество чисел i
		{
			Console.Write(i + " ");
		}
	}
}

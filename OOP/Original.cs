using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Show
{
	public class UsersStorageEnumeratorBase : IEnumerator
	{
		private readonly User[] users;
		private int currentIndex = -1;
		public UsersStorageEnumeratorBase(User[] users)
		{
			this.users = users;
		}
		public object Current => users[currentIndex]; // Возвращает текуещее (после MoveNext) значение массива по индексу
		public bool MoveNext()
		{
			currentIndex++;
			if (currentIndex >= users.Length) return false; // Проверка на выход за границу массива
			return true;
		}
		public void Reset() => currentIndex = -1; // Сбросить индекс до начального параметра -1
	}
	public class UsersStorageBase : IEnumerable
	{
		private readonly User[] users;
		public UsersStorageBase(User[] users)
		{
			this.users = users;
		}
		public IEnumerator GetEnumerator() => new UsersStorageEnumeratorBase(users); // Достаем перечислитель
	}
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show
{
	public class UsersStorage : IEnumerable<User>
	{
		private readonly User[] users;
		public UsersStorage(User[] users)
		{
			this.users = users;
		}
		IEnumerator<User> IEnumerable<User>.GetEnumerator() => new UsersStorageEnumerator(users); // Реализация для IEnumerable<T>
		IEnumerator IEnumerable.GetEnumerator() => new UsersStorageEnumerator(users); // Реализация для IEnumerable
	}

	public class UsersStorageEnumerator : IEnumerator<User>
	{
		private readonly User[] users;
		private int currentIndex = -1;
		public UsersStorageEnumerator(User[] users)
		{
			this.users = users;
		}
		public User Current => users[currentIndex]; // Реализация классового Current
		object IEnumerator.Current => users[currentIndex]; // Реализация интерфейсного Current
		public bool MoveNext()
		{
			currentIndex++;
			if (currentIndex >= users.Length) return false;
			return true;
		}
		public void Reset() => currentIndex = -1;
		public void Dispose() {} // Нужен для освобождения занятых ресурсов
	}
}

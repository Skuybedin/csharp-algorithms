using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show
{
	public class UsersStorageEnumeratorDuck // Не наследуемся от интерфейса
	{
		private readonly User[] users;
		private int currentIndex = -1;
		public UsersStorageEnumeratorDuck(User[] users)
		{
			this.users = users;
		}
		public User Current => users[currentIndex]; // Вместо object идет User
		public bool MoveNext()
		{
			currentIndex++;
			if (currentIndex >= users.Length) return false;
			return true;
		}
		public void Reset() => currentIndex = -1;
	}

	public class UsersStorageDuck // Не наследуемся от интерфейса
	{
		private readonly User[] users;
		public UsersStorageDuck(User[] users)
		{
			this.users = users;
		}
		public UsersStorageEnumeratorDuck GetEnumerator() => new UsersStorageEnumeratorDuck(users); // Вместо IEnumerator идет UsersStorageEnumeratorDuck
	}
}

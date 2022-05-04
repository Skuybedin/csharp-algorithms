using System;
using System.Collections;
using System.Collections.Generic;

namespace Show
{
	public class User
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public User(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}

    //public class User : IComparable<User> // ЕСЛИ МЫ ХОТИМ СРАВНИТЬ ТЕКУЩИЙ ОБЪЕКТ С ДРУГИМ ОБЪЕКТОМ
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public User(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //    public int CompareTo(User other) => Age.CompareTo(other.Age);
    //}

    public class AgeComparer : IComparer<User> // Правило AgeCompare (если мы хотим сравнить Х и Y объект)
	{
		public int Compare(User x, User y) => x.Age.CompareTo(y.Age);
	}

	public class AgeAndNumberComparer : IComparer<User> // Правило AgeAndNumberComparer (если мы хотим сравнить Х и Y объект)
	{
		public int Compare(User x, User y)
		{
			int ageCompare = x.Age.CompareTo(y.Age);
			if (ageCompare == 0) return x.Name.CompareTo(y.Name);
			return ageCompare;
		}
	}

	internal class Program
    {
		static void Original() // Оригинальный IEnumerable
        {
			User user1 = new User("Nikita", 25);
			User user2 = new User("Lera", 23);

			UsersStorageBase usersStorage = new UsersStorageBase(new User[] { user1, user2 });

			foreach (var user in usersStorage)
			{
				Console.WriteLine(((User)user).Name); // конвертация к User
			}
		}

		static void DuckType() // Утиная типизация
        {
			User user1 = new User("Nikita", 25);
			User user2 = new User("Lera", 23);

			User[] users = new User[] { user1, user2 };

			UsersStorageDuck usersStorage = new UsersStorageDuck(users);

			foreach (var user in usersStorage)
			{
				Console.WriteLine(user.Name); // конвертация к User НЕ нужна
			}
		}

		static void OriginalT() // IEnumerable<T>
		{
			User user1 = new User("Nikita", 25);
			User user2 = new User("Lera", 23);

			User[] users = new User[] { user1, user2 };

			UsersStorageDuck usersStorage = new UsersStorageDuck(users);

			foreach (var user in usersStorage)
			{
				Console.WriteLine(user.Name); // конвертация к User НЕ нужна
			}
		}

		static void CompareShow()
        {
			User user1 = new User("Nikita", 25);
			User user2 = new User("Lera", 23);
			User user3 = new User("Lera2", 13);

			User[] users = new User[] { user1, user2, user3 };

			Array.Sort(users, new AgeComparer()); // Сортируем users по правилу AgeComparer
			//Array.Sort(users); // Для public class User : IComparable<User> 

			foreach (var user in users)
			{
				Console.WriteLine(user.Name);
			}
		}
        static void Main(string[] args)
        {
			//Original();
			//DuckType();
			//OriginalT();
			//CompareShow();
		}
    }
}

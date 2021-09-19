using System;

class MainClass
{
	public static void Main(string[] args)
	{
		for (int q = 0; q < 3; q++)
		{
			(string Name, string LastName, string Login, int Loginlength, bool pet, double age, string[] favcolors) user;

			Console.WriteLine();

			Console.WriteLine("Введите имя: ");
			user.Name = Console.ReadLine();

			Console.WriteLine("Введите фамилию: ");
			user.LastName = Console.ReadLine();

			Console.WriteLine("Введите Ваш логин: ");
			user.Login = Console.ReadLine();

			user.Loginlength = user.Login.Length;

			Console.WriteLine("У Вас есть питомцы?");

			var result = Console.ReadLine();

			if (result == "да")
			{
				user.pet = true;
			}
			else
			{
				user.pet = false;
			}

			Console.WriteLine("Введите Ваш возраст: ");
			user.age = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите три любимых цвета: ");
			user.favcolors = new string[3];

			for (int i = 0; i < user.favcolors.Length; i++)
			{
				user.favcolors[i] = Console.ReadLine();
			}
			Console.WriteLine();

			Console.WriteLine("||Информация о пользователе|| \n \t Имя: {0} \n \t Фамилия: {1} \n \t Возраст: {2} \n \t Логин: {3} \n \t Длина логина: {4} \n \t Питомцы: {5} \n \t Любимые цвета: {6}, {7}, {8}", user.Name, user.LastName, user.age, user.Login, user.Loginlength, user.pet, user.favcolors[0], user.favcolors[1], user.favcolors[2]);
		}

	}
}
using System;

class MainClass
{
	public static void Main(string[] args)
	{
		(string name, int age) anketa;

		Console.WriteLine("Введите ваше имя: ");
		anketa.name = Console.ReadLine();

		Console.WriteLine("Введите ваш возраст: ");
		anketa.age = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Вас зовут {0}, и вам {1} лет", anketa.name, anketa.age);

		Console.ReadKey();
	}
}

using System;

class MainClass
{
	public static void Main(string[] args)
	{
		(string name, string type, double age, int namecount) anketa;

		Console.WriteLine("Введите имя Вашего питомца: ");
		anketa.name = Console.ReadLine();

		Console.WriteLine("Введите тип Вашего питомца: ");
		anketa.type = Console.ReadLine();

		Console.WriteLine("Введите возраст Вашего питомца: ");
		anketa.age = Convert.ToDouble(Console.ReadLine());

		anketa.namecount = anketa.name.Length;

		Console.WriteLine("У Вас {0}, зовут {1}, ему(ей) {2} лет, а длинна имени составляет {3}", anketa.type, anketa.name, anketa.age, anketa.namecount);

		Console.ReadKey();
	}
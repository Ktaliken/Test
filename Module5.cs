using System;

namespace module5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string lastname, int age, string pet, int manypet, string[] petnames, int colors, string[] favcolors) User;

            User = UserEnter();

            UserInfo(User.name, User.lastname, User.age, User.pet, User.manypet, User.petnames, User.colors, User.favcolors);
        }

        static (string, string, int, string, int, string[], int, string[]) UserEnter()
        {
            (string name, string lastname, int age, string pet, int manypet, string[] petnames, int colors, string[] favcolors) User;

            string name;
            string stringname;

            do
            {
                Console.WriteLine("Введите ваше имя");
                name = Console.ReadLine();

            } while (CheckWord(name, out stringname));

            User.name = stringname;

            string lastname;
            string stringlastname;

            do
            {
                Console.WriteLine("Введите вашу фамилию");
                lastname = Console.ReadLine();

            } while (CheckWord(lastname, out stringlastname));

            User.lastname = stringlastname;
            string age;
            int intage;

            do
            {
                Console.WriteLine("Введите ваш возраст");
                age = Console.ReadLine();

            } while (CheckNum(age, out intage));

            User.age = intage;
            Console.WriteLine("У вас есть питомец?");
            User.pet = Console.ReadLine();

            if (User.pet == "Да")
            {
                string pet;
                int intpet;

                do
                {
                    Console.WriteLine("Сколько у вас питомцев?");
                    pet = Console.ReadLine();

                } while (CheckNum(pet, out intpet));

                User.manypet = intpet;
                User.petnames = CheckPetNames(User.manypet);

            }

            else
            {
                User.manypet = 0;
                User.petnames = new string[1];
                User.petnames[0] = ("Нет питомцев");
            }
            string color;
            int intcolor;
            do
            {
                Console.WriteLine("Сколько у вас любимых цветов?");
                color = Console.ReadLine();
            } while (CheckNum(color, out intcolor));

            User.colors = intcolor;
            User.favcolors = FavoriteColors(User.colors);
            return User;
        }

        static string[] CheckPetNames(in int pet)
        {
            string[] PetNames = new string[pet];

            for (int i = 0; i < PetNames.Length; i++)
            {
                string petname;
                string stringpetname;

                do
                {
                    Console.WriteLine("Введите кличку питомца № {0}", i + 1);
                    petname = Console.ReadLine();

                } while (CheckWord(petname, out stringpetname));

                PetNames[i] = stringpetname;

            }

            return PetNames;
        }

        static string[] FavoriteColors(in int colors)
        {
            string[] Favcolors = new string[colors];

            for (int i = 0; i < Favcolors.Length; i++)
            {
                string color;
                string stringcolor;

                do
                {
                    Console.WriteLine("Введите ваш любимый цвет № {0}", i + 1);
                    color = Console.ReadLine();

                } while (CheckWord(color, out stringcolor));

                Favcolors[i] = stringcolor;
            }
            return Favcolors;
        }

        static bool CheckNum(string number, out int cornumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    cornumber = intnum;
                    return false;
                }
            }
            {
                cornumber = 0;
                return true;
            }
        }

        static void UserInfo(string name, string lastname, int age, string pet, int manypet, string[] petnames, int colors, string[] favcolors)
        {
            Console.WriteLine("Ваше имя:\n {0}", name);
            Console.WriteLine("Ваша фамилия:\n {0}", lastname);
            Console.WriteLine("Ваш возраст:\n {0}", age);
            Console.WriteLine("Есть ли у вас питомец?\n{0}", pet);
            Console.WriteLine("Количество ваших питомцев:\n{0}", manypet);

            if (manypet != 0)
            {
                Console.WriteLine("Имена ваших питомцев:");

                for (int i = 0; i < petnames.Length; i++)
                {
                    Console.WriteLine("Имя вашего питомца №{0}:\n{1}", i + 1, petnames[i]);
                }
            }

            Console.WriteLine("Количество ваших любимых цветов:\n{0}", colors);
            Console.WriteLine("Ваши любимые цвета:");

            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Ваш любимый цвет № {0}:\n{1}", i + 1, favcolors[i]);
            }
        }
        static bool CheckWord(string word, out string corword)
        {
            if (int.TryParse(word, out int intnum))
            {
                corword = "Неверно";
                return true;
            }
            {
                corword = word;
                return false;
            }
        }
    }
}
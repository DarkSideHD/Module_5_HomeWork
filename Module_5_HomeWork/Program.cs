using System;

namespace ModuleFive
{
    class Program
    {

        static (string FirstName, string LastName, int Age) UserFirstInfo()
        {
            (string FirstName, string LastName, int Age) UserName;

            Console.WriteLine("Привет, давайте познакомимся!");
            
            Console.WriteLine("\nВведите Ваше имя:");
            UserName.FirstName = Console.ReadLine();

            Console.WriteLine("\nВведите Вашу фамилию:");
            UserName.LastName = Console.ReadLine();

            string age;
            int intage;
            do
            {
                Console.WriteLine("\nВведите Ваш возраст цифрами:");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));

            UserName.Age = intage;

            return UserName;
        }

        static (bool HasPet, int CountPet, string[] NamePet, int CountColors, string[] FavColors) UserSecondInfo()
        {
            (bool HasPet, int CountPet, string[] NamePet, int CountColors, string[] FavColors) UserPetsColors;

            Console.WriteLine("\nУ Вас есть питомцы? да/нет");
            var Answer = Console.ReadLine();

            if (Answer == "да")
                UserPetsColors.HasPet = true;
            else
                UserPetsColors.HasPet = false;

            if (UserPetsColors.HasPet == true)


            {
                Console.WriteLine("\nВведите цифрами количество Ваших питомцев:");
            }

            UserPetsColors.CountPet = int.Parse(Console.ReadLine());
            int num = UserPetsColors.CountPet;

            UserPetsColors.NamePet = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nВведите имя Вашего {0} питомца:", i + 1);
                UserPetsColors.NamePet[i] = Console.ReadLine();
            }

            Console.WriteLine("\nВведите цифрами количество Ваших любимых цветов:");
            UserPetsColors.CountColors = int.Parse(Console.ReadLine());
            int colornum = UserPetsColors.CountColors;

            UserPetsColors.FavColors = new string[colornum];
            for (int j = 0; j < colornum; j++)
            {
                Console.WriteLine("\nВведите ваш любимый цвет {0}", j + 1);
                UserPetsColors.FavColors[j] = Console.ReadLine();
            }


            return UserPetsColors;
        }

        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intage))
            {
                if (intage > 0)
                {
                    corrnumber = intage;
                    return false;
                }
            }
            {
                corrnumber = 0;
                return true;
            }
        }

        static void Main(string[] args)
        {
            var (FirstName, LastName, Age) = UserFirstInfo();
            var (HasPet, CountPet, NamePet, CountColors, FavColors) = UserSecondInfo();

            Console.WriteLine("\nВаше имя и фамилия: {0} {1}", FirstName, LastName);
            Console.WriteLine("Ваш возраст: {0}", Age);

            if (HasPet == true)
            {
                Console.WriteLine("Количество ваших питомцев: {0}", CountPet);
                foreach (string Names in NamePet)
                    Console.WriteLine($"Имя вашего питомца: {Names}");
            }

            Console.WriteLine("Количество ваших любимых цветов: {0}", CountColors);
            foreach (string Colors in FavColors)
                Console.WriteLine($"Ваш любимый цвет: {Colors}");

            Console.WriteLine("\nЯ рад знакомству {0} {1}!", FirstName, LastName);
        }

    }

}
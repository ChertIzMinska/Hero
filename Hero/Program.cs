using System;
using System.Collections.Generic;

namespace Hero
{
    class Program
    {
        static void the_main_menu(int x)
        { 
        }
        static void Main(string[] args)
        {
            Dictionary<int, Hero> dictionary = new Dictionary<int, Hero>();
            int x = 0;
            int count = 0;
            while (x != 3)
            {

                Console.WriteLine("Выберите действие:\n1.Создать нового героя \n2.Просмотреть существующих героев\n3.Выйти\n");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка!Некорректно введен запрос\n");
                    continue;
                }
                Console.Clear();
                switch (x)
                {
                    case 1:
                        Hero hero=new Hero();
                        dictionary.Add(count++, hero);
                        break;
                    case 2:
                        if (dictionary.Count == 0)
                        {
                            Console.WriteLine("У вас еще нету персонажа\n");
                        }
                        else
                        {
                            for (int i = 0; i < dictionary.Count; i++)
                            {
                                Console.WriteLine(i+")Персонаж:"  + dictionary[i].get_Name() + "\n");
                            }
                            Console.WriteLine(dictionary.Count+")Выход\n");
                            try
                            {
                                x = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Ошибка!Некорректно введен запрос\n");
                                continue;
                            }
                            if(dictionary.Count==x)
                            {
                                continue;
                            }
                            else 
                            {
                                dictionary[x].show();
                            }
                             

                        }
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Ошибка!Некорректно введен запрос\n");
                        break;

                }

            }

        }
    }
}

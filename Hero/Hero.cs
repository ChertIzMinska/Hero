using System;
using System.Collections.Generic;
using System.Text;

namespace Hero
{
    class Hero
    {
        ICharacteristic classe;
        ICharacteristic gender;
        ICharacteristic race;
        IWeapon weapon;
        string Name;

        void choose_classe()
        {
            int x;
            Console.WriteLine("Выберите класс:\n1.Воин \n2.Лучник\n3.Друил\n4.Некромант\n5.Маг\n");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                choose_classe();
                return;
            }
            switch (x)
            {
                case 1:
                    classe = new Warrior();
                    break;
                case 2:
                    classe = new Archer();
                    break;
                case 3:
                    classe = new Druid();
                    break;
                case 4:
                    classe = new Necromancer();
                    break;
                case 5:
                    classe = new Mage();
                    break;
                default:
                    Console.Clear();
                    choose_classe();
                    return;
            }
        }
        void choose_race()
        {
            int x;
            Console.WriteLine("Выберите расу:\n1.Человек\n2.Эльф\n3.Хоббит\n4.Орк\n5.Гном\n");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                choose_race();
                return;
            }
            switch (x)
            {
                case 1:
                    race = new Human();
                    break;
                case 2:
                    race = new Elf();
                    break;
                case 3:
                    race = new Hobbit();
                    break;
                case 4:
                    race = new Orc();
                    break;
                case 5:
                    race = new Dwarf();
                    break;
                default:
                    Console.Clear();
                    choose_race();
                    return;
            }
        }

        void choose_gender()
        {
            int x;
            Console.WriteLine("Выберите пол:\n1.Мужчина \n2.Женщина\n");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                choose_gender();
                return;
            }
            switch (x)
            {
                case 1:
                    gender = new Male();
                    break;
                case 2:
                    gender = new Female();
                    break;
                default:
                    Console.Clear();
                    choose_gender();
                    return;
            }
        }

        void take_weapon()
        {
            int x;
            Console.WriteLine("Выберите действие:\n1.Взять одноручный мед \n2.Взять двуручный меч\n3.Взять топор\n4.Взять копье\n5.Взять лук\n6.Выйти\n");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                take_weapon();
                return;
            }
            switch (x)
            {
                case 1:
                    weapon = new OneHanded();
                    break;
                case 2:
                    weapon = new TwoHanded();
                    break;
                case 3:
                    weapon = new Axe();
                    break;
                case 4:
                    weapon = new Staff();
                    break;
                case 5:
                    weapon = new Bow();
                    break;
                default:
                    take_weapon();
                    break;
            }

        }
    

        public string get_Name()
        {
            return Name;
        }
        public void show()
        {
            Console.WriteLine("Имя персонажа:" + Name + "\nПол:" + gender.get_info() + "\nКласс:" + classe.get_info() + "\nРаса:" + race.get_info() + "\nУрон оружия:" + weapon.get_damage() + "\nРедкость оружия:" + weapon.get_rare() + "\n");
        }

        public Hero()
        {
            int x = 0;
            int[] checked_pos = new int[5];
            while (x != 5)
            {
                Console.WriteLine("Выберите действие:\n0.Выберите оружие\n1.Выберите класс вашего героя \n2.Выберите расу вашего класса\n3.Выберите пол\n4.Введите имя\n5.Выйти\n");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    continue;
                }
                switch (x)
                {
                    case 0:
                        take_weapon();
                        checked_pos[0]= 5;
                        break;

                    case 1:
                        choose_classe();
                        checked_pos[1] = 1;
                        break;
                    case 2:
                        choose_race();
                        checked_pos[2] = 2;
                        break;
                    case 3:
                        choose_gender();
                        checked_pos[3] = 3;
                        break;
                    case 4:
                        Name = Console.ReadLine();
                        checked_pos[4] = 4;
                        break;
                    default:
                        if (x == 5)
                        {
                            int res = 1 + 2 + 3 + 4+5;
                            for (int i = 0; i < checked_pos.Length; i++)
                            {
                                res -= checked_pos[i];
                            }
                            if (res == 0)
                                break;
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Вы не ввели все необходимые данные для вашего персонажа\n");
                                x = 4;
                            }
                        }
                        continue;
                }
                Console.Clear();

            }
        }
        
    }
}

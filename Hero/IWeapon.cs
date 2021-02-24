using System;
using System.Collections.Generic;
using System.Text;

namespace Hero
{
    public interface IWeapon
    {
        const int damage = 0;
        static string rare = "";
        public string get_damage();
        public string get_rare();
    }

    public class OneHanded : IWeapon
    {
        const int damage = 5;
        static string rare = "normal";
        public string get_damage()
        {
            return "" + damage;
        }
        public string get_rare()
        {
            return rare;
        }
    }
    public class TwoHanded : IWeapon
    {
        const int damage = 15;
        static string rare = "rare";
        public string get_damage()
        {
            return "" + damage;
        }
        public string get_rare()
        {
            return rare;
        }
    }
    public class Axe : IWeapon
    {
        const int damage = 18;
        static string rare = "ultra-rare";
        public string get_damage()
        {
            return "" + damage;
        }
        public string get_rare()
        {
            return rare;
        }
    }
    public class Bow : IWeapon
    {
        const int damage = 10;
        static string rare = "mythic";
        public string get_damage()
        {
            return "" + damage;
        }
        public string get_rare()
        {
            return rare;
        }
    }
    public class Staff : IWeapon
    {
        const int damage = 13;
        static string rare = "legendary";
        public string get_damage()
        {
            return "" + damage;
        }
        public string get_rare()
        {
            return rare;
        }
    }





}

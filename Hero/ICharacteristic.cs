using System;
using System.Collections.Generic;
using System.Text;

namespace Hero
{
    interface ICharacteristic
    {
        static string description = "";
        public string get_info();
    }
    public class Orc : ICharacteristic
    {
        static string description = "Orc";
        public string get_info()
        {
            return description;
        }
    }
    public class Elf : ICharacteristic
    {
        static string description = "Elf";
        public string get_info()
        {
            return description;
        }
    }
    public class Hobbit : ICharacteristic
    {
        static string description = "Hobbit";
        public string get_info()
        {
            return description;
        }
    }
    public class Human : ICharacteristic
    {
        static string description = "Human";
        public string get_info()
        {
            return description;
        }
    }

    public class Dwarf : ICharacteristic
    {
       static string description = "Dwarf";
        public string get_info()
        {
            return description;
        }
    }

    public class Warrior : ICharacteristic
    {
        static string description = "Warrior";
        public string get_info()
        {
            return description;
        }
    }
    public class Mage : ICharacteristic
    {
        static string description = "Mage";
        public string get_info()
        {
            return description;
        }
    }
    public class Archer : ICharacteristic
    {
        static string description = "Archer";
        public string get_info()
        {
            return description;
        }
    }
    public class Druid : ICharacteristic
    {
        static string description = "Druid";
        public string get_info()
        {
            return description;
        }
    }
    public class Necromancer : ICharacteristic
    {
        static string description = "Necromancer";
        public string get_info()
        {
            return description;
        }
    }
    public class Female : ICharacteristic
    {
        static string description = "Female";
        public string get_info()
        {
            return description;
        }
    }
    public class Male : ICharacteristic
    {
        static string description = "Male";
        public string get_info()
        {
            return description;
        }
    }




}

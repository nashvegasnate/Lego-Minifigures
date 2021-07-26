using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_Minifigures.Figures
{
    class Character
    {
      

        public string Name { get; set; }
        public string Hair { get; set; }
        public string Shirt { get; set; }
        public string Pants { get; set; }
        public string Weapon { get; set; }

        public Character(string name, string hair, string shirt, string pants, string weapon)
        {
            Name = name;
            Hair = hair;
            Shirt = shirt;
            Pants = pants;
            Weapon = weapon;
        }

        public void Desc()
        {
            Console.WriteLine($"{Name} has {Hair} hair and wears a {Shirt} shirt and {Pants} pants. {Name} is equipped with a {Weapon}.");
        }

        public void Action()
        {
            Console.WriteLine($"{Name} is approached by an ominous figure.");
        }
    }
}

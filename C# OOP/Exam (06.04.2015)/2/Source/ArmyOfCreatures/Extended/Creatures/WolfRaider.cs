using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Extended.Specialties;
using ArmyOfCreatures.Logic.Specialties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    /*•	Add class WolfRaider. The WolfRaider is a creature with attack 8, defense 5, health points 10, damage 3.5 and:
o	DoubleDamage specialty for 7 rounds
*/
    public class WolfRaider : Creature
    {
        public WolfRaider()
            :base(8,5,10,3.5M)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}

using ArmyOfCreatures.Logic.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    /*•	Add class Goblin. The Goblin is a creature with attack 4, defence 2, health points 5 and damage 1.5 and has no specialties.
o	Hint: Examine other successors of the Creature class
*/
    public class Goblin : Creature
    {
        public Goblin()
            :base(4, 2, 5, 1.5M)
        {

        }

    }
}

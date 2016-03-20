using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    /*•	Add class Griffin. The Griffin is a creature with attack 8, defense 8, damage 4.5 and health points 25. It also has the following specialties:
o	DoubleDefenseWhenDefending for 5 rounds
o	AddDefenseWhenSkip with 3 defense points
o	Hate specialty to WolfRaider creatures
	Hint: The Angel, Archangel, Devil and ArchDevil creatures also have Hate specialty.
*/
    public class Griffin : Creature
    {
        public Griffin()
            :base(8, 8, 25, 4.5M)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}

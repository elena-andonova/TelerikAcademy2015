using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Creatures
{
    /*•	Add class AncientBehemoth. The AncientBehemoth is a creature with attack 19, defense 19, damage 40, health points 300 and has the following specialties:
o	ReduceEnemyDefenseByPercentage specialty with 80% damage reduction
o	DoubleDefenseWhenDefending specialty for 5 rounds
o	Hint: The class AncientBehemoth is similar to Behemoth creature class.
*/
    public class AncientBehemoth : Creature
    {
        public AncientBehemoth()
            :base(19, 19, 300, 40M)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(40));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }

    }
}

using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Specialties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended.Specialties
{
    /*•	Add class DoubleDamage. The DoubleDamage is a specialty that doubles the current damage during battle.
o	The DoubleDamage class should have only one constructor that accepts one argument – the number of rounds for the specialty to has effect. After these rounds (attacks) the effect of this specialty stops.
	The number of rounds in the constructor should be greater than 0
	The number of rounds in the constructor should be less than or equal to 10
o	Override the default ToString() implementation to return the name of the specialty with the number of rounds remaning in parentesis. Example: “DoubleDamage(7)”
o	Hint: The class Hate (specialty) also changes the damage during the battle.
o	Hint: The class DoubleDefenseWhenDefending also has fixed rounds of effectiveness.
*/
    public class DoubleDamage : Specialty
    {
        private int rounds;
        //private readonly Type creatureTypeToAttack;
        public DoubleDamage(int rounds)
        {
            if (rounds <= 0 && rounds >= 10)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0 and less than 10");
            }

            this.rounds = rounds;
        }

        //TODO implement the specialty
        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty,
            ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return currentDamage;
            }

            this.rounds--;
            return currentDamage * 2.0M;            
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }

    }
}

namespace ArmyOfCreatures.Extended.Specialties
{
    using Logic.Battles;
    using Logic.Specialties;
    using System;
    using System.Globalization;

    public class DoubleAttackWhenAttacking : Specialty
    {
        private int rounds;

        public DoubleAttackWhenAttacking(int rounds)
        {
            if (rounds <= 0)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }

            this.rounds = rounds;
        }

        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            if (this.rounds < 0)
            {
                return;
            }

            var doubleAttack = attackerWithSpecialty.CurrentAttack * 2;
            attackerWithSpecialty.CurrentAttack = doubleAttack;
            this.rounds--;
            
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", this.GetType().Name, this.rounds);
        }
    }
}

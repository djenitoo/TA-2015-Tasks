﻿namespace ArmyOfCreatures.Extended.Specialties
{
    using Logic.Battles;
    using Logic.Specialties;
    using System;
    using System.Globalization;

    public class AddAttackWhenSkip : Specialty
    {
        private int attackToAdd;

        public AddAttackWhenSkip(int attackToAdd)
        {
            if (attackToAdd < 1 || attackToAdd > 10)
            {
                throw new ArgumentOutOfRangeException("attackToAdd", "attackToAdd should be between 1 and 10, inclusive");
            }

            this.attackToAdd = attackToAdd;
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackToAdd;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", this.GetType().Name, this.attackToAdd);
        }
    }
}

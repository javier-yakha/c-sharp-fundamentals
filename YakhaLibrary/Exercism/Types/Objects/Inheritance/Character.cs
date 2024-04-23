using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Objects.Inheritance
{
    abstract class Character
    {
        string _characterType;
        protected Character(string characterType)
        {
            _characterType = characterType;
        }
        public abstract int DamagePoints(Character target);

        public virtual bool Vulnerable() => false;

        public override string ToString() => $"Character is a {_characterType}";
    }

    class Warrior : Character
    {
        public Warrior() : base("Warrior") { }

        public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
    }

    class Wizard : Character
    {
        bool _preparedSpell = false;
        public Wizard() : base("Wizard") { }

        public override int DamagePoints(Character target) => _preparedSpell ? 12 : 3;

        public void PrepareSpell()
        {
            _preparedSpell = true;
        }
        public override bool Vulnerable() => !_preparedSpell;
    }
}

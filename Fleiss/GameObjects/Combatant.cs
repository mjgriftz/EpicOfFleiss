using System;
namespace Fleiss.GameObjects
{
    public enum Race
    {
        //todo
        Hooman, 
        Cat, 
        Doggo
    };
    public abstract class Combatant
    {
        public CombatProfile Profile { get; protected set; }
        public CombatStatus Status { get; protected set; }
        public Equipment Equip { get; protected set; }

        public Combatant(CombatProfile cp, CombatStatus cs, Equipment eq)
        {
            this.Profile = cp;
            this.Status = cs;
            this.Equip = eq;
        }
        public class CombatProfile
        {
            public string Name { get; private set; }
            public string Origin { get; private set; }
            public string Description { get; private set;  }
            public Race Race { get; private set;  }


        }
        public class CombatStatus
        {
            //todo
        }
        public class Equipment
        {
            //todo
        }
    }

    public class Ally: Combatant
    {
        //todo
    }
    public class Enemy: Combatant
    {
        //todo
    }

}

using System;
namespace Fleiss.GameObjects
{
    public abstract class Item
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Item(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
    public abstract class Consumable: Item
    {
        public Consumable(string name, string description) : base(name, description)
        {
            
        }
        //todo
    }
    public abstract class Equipment: Item
    {
        public int AtkRating { get; protected set; }
        public int DefRating { get; protected set; }
        public int DdgRating { get; protected set; }
        public int StrRating { get; protected set; }
        public int AgiRating { get; protected set; }
        public int Weight { get; protected set; }

        public Equipment(string name, string description) : base(name, description)
        {
            
        }
    }
    public class KeyItem: Item
    {
        public KeyItem(string name, string description) : base(name, description)
        {
            
        }
        //todo
    }
}

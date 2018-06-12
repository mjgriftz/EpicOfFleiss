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
        //todo
    }
    public abstract class Equipment: Item
    {
        //todo
    }
    public class KeyItem: Item
    {
        //todo
    }
}

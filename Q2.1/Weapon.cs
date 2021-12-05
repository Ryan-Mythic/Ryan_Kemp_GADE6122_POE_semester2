using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    abstract class Weapon : Item
    {
        protected int Damage;
        protected int range;            //(the accessor for this should be virtual to be overridden by the subclasses)
        protected int Durability;
        protected int Cost;
        protected string WeaponType;    //CORRECT?
                                        //It also contains a constructor that receives a symbol as well as optional X and Y
                                        //positions(because a weapon can either be equipped to a Character or exists on the
                                        //Map). This data is delegated to the Tile superclass via a constructor initializer.
                                        //All weapon‐specific data is set in the subclasses.

        public Weapon(int x, int y, TileType tileType, char symbol) : base(x, y, tileType, symbol)
        {
            int iRange = new int();
            iRange.Range();
        }

        public int getDamage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public virtual void Range()
        {
        
        }

    public int getDurability
        {
            get { return Durability; }
            set { Durability = value; }
        }

        public int getCost
        {
            get { return Cost; }
            set { Cost = value; }
        }

        public string TypeOfWeapon
        {
            get { return WeaponType; }
            set { WeaponType = value; }
        }
    }
}
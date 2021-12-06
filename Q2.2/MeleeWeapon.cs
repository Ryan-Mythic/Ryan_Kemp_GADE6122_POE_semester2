using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    abstract class MeleeWeapon : Weapon
    {
        protected int _X;
        protected int _Y;
        protected char WeaponSymbol;
        protected Types MeleeWeaponType;

        public enum Types
        {
            Dagger,
            LongSword
        }
        public MeleeWeapon(int x, int y, TileType tileType, char symbol) : base(x, y, tileType, symbol)
        {
            _X = x;
            _Y = y;
            WeaponSymbol = symbol;
            
            Random rndNum = new Random();               //2.2 second point?
            int mTypes = rndNum.Next(1, 3);             //
            switch (mTypes)                             //
            {                                           //
                case 1:                                 //
                    MeleeWeaponType = Types.Dagger;     //
                    break;                              //
                case 2:                                 //
                    MeleeWeaponType = Types.LongSword;  //
                    break;                              //
            }                                           //
            //MeleeWeaponType = //Types.Dagger;         //2.2 second point   ** done above with random??
        }
        public int getMeleeX
        {
            get { return X; }
            set { X = value; }
        }

        public int getMeleeY
        {
            set { Y = value; }
            get { return Y; }
        }

        public char getMeleeSymbol
        {
            set { Symbol = value; }
            get { return Symbol; }
        }

        public Types GetWeaponType
        {
            set { MeleeWeaponType = value; }
            get { return MeleeWeaponType; }

        }

        public override int Range //(Weapon range) ReturnRange     <--dumb mistakes :)
        {
            get { return range; }
            set { range = 1; }
        }

        public abstract override string ToString();
    }
}
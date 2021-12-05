using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;

namespace Task_1
{
    abstract class MeleeWeapon : Weapon
    {
        public MeleeWeapon(int x, int y, TileType tileType, char symbol) : base(x, y, tileType, symbol)
        {

        }

        public enum Types
        {
            Dagger,
            LongSword
        }

        public override void Range() //ReturnRange
        {
            return 1;
        }
    }
}
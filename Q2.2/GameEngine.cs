using System;                       //Ryan Kemp
using System.Collections.Generic;   //20100423
using System.Text;
using static Task_1.Character;

namespace Task_1
{
    class GameEngine
    {
        private Map map;
         public Map GetMap
        {
            get { return map; }
            set { map = value; }
        }
        
       public GameEngine()
        {
            map = new Map(10, 10, 15, 15, 6,5);
        }

        public void MovePlayer(MovementDirection movement)
        {
            switch (movement)
            {
                case MovementDirection.up:
                    map.GetPlayer.Move(map.GetPlayer.ReturnMove(MovementDirection.up));
                    break;

                case MovementDirection.down:
                    map.GetPlayer.Move(map.GetPlayer.ReturnMove(MovementDirection.down));
                    break;

                case MovementDirection.left:
                    map.GetPlayer.Move(map.GetPlayer.ReturnMove(MovementDirection.left));
                    break;

                case MovementDirection.right:
                    map.GetPlayer.Move(map.GetPlayer.ReturnMove(MovementDirection.right));
                    break;
            }
           
        }

        public string PlayerAttack(int Enemy)
        {
            bool EnemyInRange = false;

            foreach(Tile T in map.GetPlayer.Vision)
            {
                if(T.getX == map.GetEnemies[Enemy].getX && (T.getY == map.GetEnemies[Enemy].getY))
                {
                    EnemyInRange = true;
                    break;
                }
            }
             
            if (EnemyInRange)
            {
                map.GetPlayer.attack(map.GetEnemies[Enemy]);
                return "You did attack" + map.GetPlayer.getDamage + " damage to a " + map.GetEnemies[Enemy].GetTileType
                +"they now have" + map.GetEnemies[Enemy].getHP + "HP";
            }
            else
            {
                return "Target was not in range";
            }
        }        

        public override string ToString()
        {
           return map.DrawMap();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureText
{
    public class Player : EntityWithInventory
    {
        public Room CurrentRoom { get; }

        public Player(Room startRoom)
        {
            CurrentRoom = startRoom;
        }
    }
}

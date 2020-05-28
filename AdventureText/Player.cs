using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureText
{
    public class Player : EntityWithInventory
    {
        public Room CurrentRoom { get; private set; }

        public Player(Room startRoom)
        {
            CurrentRoom = startRoom;
        }

        public void Go(string roomName)
        {
            CurrentRoom = CurrentRoom.Go(roomName);
        }
    }
}

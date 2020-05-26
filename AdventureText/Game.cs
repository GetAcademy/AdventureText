using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureText
{
    public class Game
    {
        public void PickupThingFromRoom(PickupableThing pickupableThing, Player player, Room room)
        {
            var hasRemoved = room.RemoveFromInventory(pickupableThing);
            if (!hasRemoved) return;
            player.AddToInventory(pickupableThing);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureText
{
    public class Player : EntityWithInventory
    {
        public Room CurrentRoom { get; private set; }
        private readonly List<Key> _keys;

        public Player(Room startRoom)
        {
            CurrentRoom = startRoom;
            _keys = new List<Key>();
            _keys.Add(new KeyWithChallenge("rød"));
        }

        public void Go(string roomName)
        {
            CurrentRoom = CurrentRoom.Go(roomName);
        }

        public void UnlockDoor(string color)
        {
            var key = _keys.FirstOrDefault(k => k.Color == color);
            if (key == null) return;
            var door = CurrentRoom.GetDoorByColor(color);
            if (door == null) return;
            door.Unlock(key);
        }
    }
}

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
            _keys.Add(new Key("rød"));
        }

        public void Go(string roomName)
        {
            CurrentRoom = CurrentRoom.Go(roomName);
        }

        public void UnlockDoor(string keyColor)
        {
            var hasCorrectKey = _keys.Any(k => k.Color == keyColor);
            if (!hasCorrectKey) return;
            var door = CurrentRoom.GetDoorByColor(keyColor);
            if (door == null) return;
            door.Unlock();
        }
    }
}

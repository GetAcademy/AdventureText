using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureText
{
    public class Door
    {
        //private Tuple<Room, Room> _rooms;
        private readonly Room[] _rooms;
        private bool _isOpen;
        public string Color { get; }

        public Door(Room roomA, Room roomB, string color)
        {
            Color = color;
            _rooms = new[] {roomA, roomB};
            _isOpen = false;
        }


        public bool HasRoom(string roomName)
        {
            return _rooms.Any(r => r.Name == roomName);
        }

        public Room GoThroughDoor(Room room)
        {
            if (!_isOpen) return null;
            return _rooms.First(r => r != room);
        }

        public void Unlock()
        {
            _isOpen = true;
        }
    }
}

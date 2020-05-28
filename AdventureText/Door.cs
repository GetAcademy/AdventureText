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

        public Door(Room roomA, Room roomB)
        {
            _rooms = new[] {roomA, roomB};
            //_rooms = new Tuple<Room, Room>(roomA, roomB);
        }

        public bool HasRoom(string roomName)
        {
            return _rooms.Any(r => r.Name == roomName);
        }

        public Room GetOtherRoom(Room room)
        {
            return _rooms.First(r => r != room);
        }
    }
}

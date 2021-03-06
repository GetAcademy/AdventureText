﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureText
{
    public class Room : EntityWithInventory
    {
        public string Name { get; }
        private readonly List<Door> _doors;

        public Room(string name)
        {
            Name = name;
            _doors = new List<Door>();
        }

        public string GetDescription()
        {
            return $"Du er i rom {Name}. ";
        }

        public void Connect(Room roomB, string color)
        {
            var door = new Door(this, roomB, color);
            this._doors.Add(door);
            roomB._doors.Add(door);
        }

        public Room Go(string roomName)
        {
            var door = GetDoorByRoomName(roomName);
            return door?.GoThroughDoor(this) ?? this;
        }

        private Door GetDoorByRoomName(string roomName)
        {
            return _doors.FirstOrDefault(d => d.HasRoom(roomName));
            //foreach (var door in _doors)
            //{
            //    if (door.HasRoom(roomName)) return door;
            //}
            //return null;
        }

        public Door GetDoorByColor(string keyColor)
        {
            return _doors.FirstOrDefault(d => d.Color == keyColor);
        }
    }
}

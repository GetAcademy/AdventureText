using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureText
{
    public class Room : EntityWithInventory
    {
        private readonly string _name;

        public Room(string name)
        {
            _name = name;
        }

        public string GetDescription()
        {
            return $"Du er i rom {_name}. ";
        }
    }
}

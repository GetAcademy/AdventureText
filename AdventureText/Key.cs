using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureText
{
    public class Key : PickupableThing
    {
        public string Color { get; }

        public Key(string color)
        {
            Color = color;
        }

        public virtual bool IsUnlockApproves()
        {
            return true;
        }
    }
}

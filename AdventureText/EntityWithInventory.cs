using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureText
{
    public class EntityWithInventory
    {
        public List<PickupableThing> Inventory { get; set; }

        public EntityWithInventory()
        {
            Inventory = new List<PickupableThing>();
        }

        public void AddToInventory(PickupableThing pickupableThing)
        {
            Inventory.Add(pickupableThing);
        }

        public bool RemoveFromInventory(PickupableThing pickupableThing)
        {
            return Inventory.Remove(pickupableThing);
        }
    }
}

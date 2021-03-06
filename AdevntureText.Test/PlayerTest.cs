﻿using NUnit.Framework;

namespace AdventureText.Test
{
    class PlayerTest
    {
        [Test]
        public void TestPlayerTakeThing()
        {
            var key = new Key("red");
            var player = new Player(new Room("A"));
            player.AddToInventory(key);
            Assert.AreEqual(1, player.Inventory.Count);
            Assert.AreEqual(key, player.Inventory[0]);
        }

        [Test]
        public void TestPlayerDropThing()
        {
            var key = new Key("red");
            var player = new Player(new Room("A"));
            player.AddToInventory(key);
            player.RemoveFromInventory(key);
            Assert.AreEqual(0, player.Inventory.Count);
        }
    }
}

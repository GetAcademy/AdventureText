using NUnit.Framework;

namespace AdventureText.Test
{
    public class GameTest
    {
        [Test]
        public void TestSuccessfulPickup()
        {
            var key = new Key();
            var room = new Room();
            room.AddToInventory(key);
            var player = new Player();
            var game = new Game();
            game.PickupThingFromRoom(key, player, room);
            Assert.AreEqual(0, room.Inventory.Count);
            Assert.AreEqual(1, player.Inventory.Count);
        }

        [Test]
        public void TestUnsuccessfulPickup()
        {
            var key = new Key();
            var room = new Room();
            var player = new Player();
            var game = new Game();
            game.PickupThingFromRoom(key, player, room);
            Assert.AreEqual(0, room.Inventory.Count);
            Assert.AreEqual(0, player.Inventory.Count);
        }
    }
}
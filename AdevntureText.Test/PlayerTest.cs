using NUnit.Framework;

namespace AdventureText.Test
{
    class PlayerTest
    {
        [Test]
        public void TestPutThingInRoom()
        {
            var key = new Key();
            var player = new Player();
            player.AddToInventory(key);
            Assert.AreEqual(1, player.Inventory.Count);
            Assert.AreEqual(key, player.Inventory[0]);
        }
    }
}

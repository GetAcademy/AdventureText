using NUnit.Framework;

namespace AdventureText.Test
{
    class RoomTest
    {
        [Test]
        public void TestPutThingInRoom()
        {
            var key = new Key();
            var room = new Room();
            room.AddToInventory(key);
            Assert.AreEqual(1, room.Inventory.Count);
        }
    }
}

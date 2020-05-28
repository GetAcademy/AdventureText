using NUnit.Framework;

namespace AdventureText.Test
{
    class RoomTest
    {
        [Test]
        public void TestPutThingInRoom()
        {
            var key = new Key("red");
            var room = new Room("A");
            room.AddToInventory(key);
            Assert.AreEqual(1, room.Inventory.Count);
        }
    }
}

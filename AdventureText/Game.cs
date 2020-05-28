using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureText
{
    public class Game
    {
        private List<Room> _rooms;
        private Player _player;

        public Game()
        {
            var roomA = new Room("A");
            _rooms = new List<Room>();
            _rooms.Add(roomA);
            _player = new Player(roomA);
        }

        public bool HandleCommand(string command)
        {
            if (command == "exit") return false;
            return true;
        }

        private string GetCurrentDescription()
        {
            var room = _player.CurrentRoom;
            return room.GetDescription();
        }

        public void PickupThingFromRoom(PickupableThing pickupableThing, Player player, Room room)
        {
            var hasRemoved = room.RemoveFromInventory(pickupableThing);
            if (!hasRemoved) return;
            player.AddToInventory(pickupableThing);
        }



        public static void RunConsoleGame()
        {
            var game = new Game();
            Console.WriteLine("Velkommen til spillet.");

            while (true)
            {
                Console.WriteLine(game.GetCurrentDescription());
                Console.Write("Kommando: ");
                var command = Console.ReadLine();
                if (!game.HandleCommand(command)) break;
            }

            Console.WriteLine("Takk for at du spilte AdventureText. Velkommen tilbake!");
        }
    }
}

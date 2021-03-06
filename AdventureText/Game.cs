﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureText
{
    public class Game
    {
        private List<Room> _rooms;
        private readonly Player _player;

        private static Game _instance;
        public static Game Instance => _instance ??= new Game();

        private Game()
        {
            var roomA = new Room("A");
            var roomB = new Room("B");
            var roomC = new Room("C");
            var roomD = new Room("D");
            var roomE = new Room("E");
            var roomF = new Room("F");
            roomA.Connect(roomB, "rød");
            roomA.Connect(roomD, "grønn");
            roomB.Connect(roomC, "grå");
            roomB.Connect(roomE, "blå");
            roomE.Connect(roomF, "hvit");

            _rooms = new List<Room>();
            _rooms.Add(roomA);
            _player = new Player(roomA);
        }

        public bool HandleCommand(string command)
        {
            if (command == "exit") return false;
            if (command.StartsWith("go ")) _player.Go(command.Substring(3));
            if (command.StartsWith("unlock ")) _player.UnlockDoor(command.Substring(7));

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

        public string AskUser(string question)
        {
            Console.Write(question);
            var answer = Console.ReadLine();
            return answer;
        }
    }
}

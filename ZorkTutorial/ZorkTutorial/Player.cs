﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace Zork
{
    public enum Directions
    {
        North,
        South,
        East,
        West
    }

    public class Player
    {
        public World World { get; }

        [JsonIgnore]
        public Room Location { get; private set; }

        public int Moves { get; set; }

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }

            return isValidMove;
        }
    }
}

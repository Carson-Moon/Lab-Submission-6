using System;

namespace Zork
{

    internal class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Rooms.json";
            string gameFilename = (args.Length > 0 ? args[0] : defaultGameFilename);

            Game.Start(gameFilename);
            Console.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
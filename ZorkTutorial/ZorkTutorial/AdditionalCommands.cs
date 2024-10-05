using System;

namespace Zork
{
    [CommandClass]
    public static class LookCommand
    {
        [Command("LOOK", new string[] { "LOOK", "L" })]
        public static void Look(Game game, CommandContext commandContext) => Console.WriteLine(game.Player.Location.Description);
    }

    [CommandClass]
    public static class QuitCommand
    {
        [Command("QUIT", new string[] {"QUIT", "Q", "GOODBYE", "BYE" })]
        public static void Quit(Game game, CommandContext commandContext)
        {
            if(game.ConfirmAction("Are you sure you want to quit? "))
            {
                game.Quit();
            }
        }
    }

    [CommandClass]
    public static class RestartCommand
    {
        [Command("RESTART", "RESTART")]
        public static void Restart(Game game, CommandContext commandContest)
        {
            if(game.ConfirmAction("Are you sure you want to restart? "))
            {
                game.Restart();
            }
        }
    }
}

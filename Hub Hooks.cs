﻿using System;
using System.Collections.Generic;
using System.Linq;
using TerrariaApi.Server;
using TShockAPI;

namespace TEHub
{
    public static class HubHooks
    {
        public static void OnServerLeave(LeaveEventArgs args)
        {
            // Kick players out of events if they leave the game.

            TSPlayer tSPlayer = TShock.Players[args.Who];

            HubEvent.RemovePlayerFromEvent(tSPlayer);
        }

        public static void OnGameUpdate(EventArgs args)
        {
            // Auto start the game if there are enough players.
            // TODO.
            foreach (var hubEvent in HubEvent.eventList)
            {
                Console.WriteLine(hubEvent.eventName);
                foreach (var p in hubEvent.tSPlayers)
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine();
            }
        }
    }
}

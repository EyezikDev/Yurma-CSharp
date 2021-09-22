using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yurma.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        Color embedColor = new Color(128, 17, 252);
        [Command("help")]
        public async Task Help()
        {
            var embedHelp = new EmbedBuilder { Title = "~~──────────────~~ Help ~~──────────────~~" };
            embedHelp = embedHelp.AddField("Commands",
                "**help** - Pulls up this menu \n" +
                "**ping** - pong! \n")
            .WithFooter("Command Run By " + Context.User)
            .WithColor(embedColor)
            .WithCurrentTimestamp();

            await Context.Channel.SendMessageAsync("", false, embedHelp.Build());
        }

        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong");
        }
        [Command("test")]
        public async Task TestAsync()
        {
            await ReplyAsync();
        }
    }
}

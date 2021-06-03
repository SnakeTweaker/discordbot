using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotApp.Commands
{
    public class MenuCommands : BaseCommandModule
    {
        [Command("Description")]
        [Description("Gives a generalized description of the Bot")]
        public async Task Description(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("cardBot competitive trading card game.").ConfigureAwait(false);
        }

        [Command("Register")]
        [Description("Register player")]
        public async Task Register(CommandContext ctx, 
            [Description("Username")] string userName)
        {
            await ctx.Channel
                .SendMessageAsync(("Welcome to cardBot " + userName + "!")
                .ToString())
                .ConfigureAwait(false);

            await ctx.Member.SendMessageAsync("Please specify the password you will use for your account: ").ConfigureAwait(false);

        }

    }
}

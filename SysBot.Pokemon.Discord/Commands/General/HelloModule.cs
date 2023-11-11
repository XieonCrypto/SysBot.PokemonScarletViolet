using Discord.Commands;
using System.Threading.Tasks;

namespace SysBot.Pokemon.Discord
{
    public class HelloModule : ModuleBase<SocketCommandContext>
    {
        [Command("hello")]
        [Alias("hi")]
        [Summary("Say hello to the bot and get a response.")]
        public async Task PingAsync()
        {
            var str = SysCordSettings.Settings.HelloResponse;
            var msg = string.Format(str, Context.User.Mention);
        }

        [Command("rules")]
        [Summary("Have the bot tell you the current rules: ")]
        public async Task Rules()
        {
            var msg = $"The rules are being re-added to the bot for user QOL and EOU improvements";
            await ReplyAsync(msg).ConfigureAwait(false);
        }

        [Command("ballmatch")]
        [Summary("Have an eye for the decorative? How about matching bals and Pokemon?"  )]
        public async Task BallMatching()
        {
            var msg = $"Hey there trainer, it seems you're much like Bede and have an eye for the fashionable.";
            msg = $"{msg}''``";
            var msg2 = $"``Thankfully at Xieon's Gaming Corner - we too are players of the game, we know what trainers like since we are trainers. Matching balls happens to be one of those things``";
            var sendmsg = $"{msg}\n{msg2}\n ``This feature is not finished yet but it being actively programmer, and will be available for all users to use``";
            await ReplyAsync(msg).ConfigureAwait(false);
        }
    }
}
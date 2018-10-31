using System;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;
using Discord;

namespace Piece_Of_Shit
{
    public class AdminCommands : ModuleBase<SocketCommandContext>
    { 
        [Command("admin")]
        [RequireUserPermission(GuildPermission.Administrator)]
        [RequireBotPermission(GuildPermission.Administrator)]
        public async Task admin()
        {

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{ Context.User.Username} Used Admin Command"));

            await Context.Message.DeleteAsync();

            var embed = new EmbedBuilder();
            embed.WithColor(new Color(0xFF1D8E));
            embed.WithAuthor("Current Admin Commands");
            embed.WithDescription("**Prune:** Deletes an x amount of messages.\n**Kick:** Kicks the selected user.\n**Ban:** Bans the selected user.\n");

            await Context.User.SendMessageAsync("", false, embed);
        }
        [Command("ban")]
        [RequireBotPermission(GuildPermission.BanMembers)]
        [RequireUserPermission(GuildPermission.BanMembers)]
        public async Task BanAsync(SocketGuildUser user = null, [Remainder] string reason = null)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{ Context.User.Username} Used Ban Command"));

            if (user == null)
            {
                Console.WriteLine("You must mention a user");
                await ReplyAsync("You must mention a user");
                return;
            }
            if (string.IsNullOrWhiteSpace(reason))
            {
                Console.WriteLine("You must provide a reason");
                await ReplyAsync("You must provide a reason");
                return;
            }
            if (user.Id == 399083954826641408)
            {
                await ReplyAsync("You cannot make me ban myself :rage:");
                return;
            }
            var Guild = Context.Guild as SocketGuild;
            var embed = new EmbedBuilder(); 
            embed.WithColor(new Color(0x4900ff)); 
            embed.Title = $"**{user.Username}** was banned";
            embed.Description = $"**Username: **{user.Username}\n**Banned by: **{Context.User.Username}\n**Reason: **{reason}";

            await user.SendMessageAsync("", false, embed);
            await Guild.AddBanAsync(user);

            var channel = Context.Client.GetChannel(399394237629595658) as SocketTextChannel;
            await channel.SendMessageAsync("", false, embed);
        }
        [Command("kick")]
        [RequireBotPermission(GuildPermission.KickMembers)]
        [RequireUserPermission(GuildPermission.KickMembers)]
        public async Task KickAsync(SocketGuildUser user = null, [Remainder] string reason = null)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{ Context.User.Username} Used Kick Command"));

            if (user == null)
            {
                Console.WriteLine("You must mention a user");
                await ReplyAsync("You must provide a reason");
                return;
            }
            if (string.IsNullOrWhiteSpace(reason))
            {
                Console.WriteLine("You must provide a reason");
                await ReplyAsync("You must provide a reason");
                return;
            }
            if (user.Id == 399083954826641408)
            {
                await ReplyAsync("You cannot make me kick myself :rage:");
                return;
            }

            var embed = new EmbedBuilder(); 
            embed.WithColor(new Color(0x4900ff)); 
            embed.Title = $" {user.Username} has been kicked"; 
            embed.Description = $"**Username: **{user.Username}\n**Kicked by: **{Context.User.Username}\n**Reason: **{reason}";

            await user.SendMessageAsync("", false, embed);
            await user.KickAsync(); 
            await Context.Channel.SendMessageAsync("", false, embed); 
        }
        [Command("prune")]
        [Alias("delete")]
        [RequireBotPermission(GuildPermission.ManageMessages)]
        [RequireUserPermission(GuildPermission.ManageMessages)]
        public async Task ClearMessage([Remainder] int x = 0)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{ Context.User.Username} Used Prune Command"));
            {
                if (x == 0)
                {
                    await ReplyAsync("You must provide a number");
                    return; 
                }
                var messagesToDelete = await Context.Channel.GetMessagesAsync(x + 1).Flatten();
                await Context.Channel.DeleteMessagesAsync(messagesToDelete);
            }
        }
    }
}

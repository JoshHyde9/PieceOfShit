using System;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;


namespace Piece_Of_Shit
{
    public class GeneralCommands : ModuleBase<SocketCommandContext>
    {
        [Command("nigger")]
        [Alias("slave")]
        public async Task nigger()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Used Nigger Command"));

            await ReplyAsync("https://imgur.com/a/Ux7b6");
        }
        [Command("say")]
        public async Task say([Remainder] string message)
        {
            await Context.Message.DeleteAsync();

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Used Say Command"));

            await ReplyAsync(message);
        }
        /*[Command("prank")]
        public async Task prank()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Used Prank Command"));

            var rand = new Random();
            var randomSocketGuildUser = Context.Guild.Users.OrderBy(r => rand.Next()).FirstOrDefault();

            await Context.Message.DeleteAsync();

            Console.WriteLine(randomSocketGuildUser);
            await ReplyAsync(randomSocketGuildUser.Mention);
        }*/

        [Command("imretarded")]
        public async Task imretarded()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Wanted The List Of The Available Commands"));

            var embed = new EmbedBuilder();
            embed.WithColor(new Color(0x00ECFF));
            embed.WithAuthor("Current Commands");
            embed.WithTitle("Using the prefix ')'.");
            embed.WithDescription("**Say:** Bot repeats what is said.\n**Nigger:** Sends a Nigger to your :house:\n**Insult:** Insults the selected user.\n**Meme:** Sends a dank AF meme.\n**Joke:** Lists the available jokes.\n**Urban:** Searches the Urban Dictionary with your query.\n**Lyric:** Posts lyrics of lit AF song.\n**Admin:** Sends the list of admin commands if user has Administrator role.\n***Invite To Your Server:*** http://www.burnniggers.org \n");
            await ReplyAsync("", false, embed);
        }
    }
}

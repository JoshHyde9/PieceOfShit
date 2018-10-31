using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Piece_Of_Shit.Commands
{
    public class SearchCommands : ModuleBase<SocketCommandContext>
    {
        [Command("urban")]
        public async Task Urban([Remainder] string search = null)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Used Urban Command"));

            if (string.IsNullOrWhiteSpace(search))
            {
                Console.WriteLine($"{Context.User.Username} Forgot To Search Something");
                await ReplyAsync("You must input a search");
                return;
            }
            using (var http = new HttpClient())
            {
                http.DefaultRequestHeaders.Clear();
                http.DefaultRequestHeaders.Add("Accept", "application/json");
                var result = await http.GetStringAsync($"http://api.urbandictionary.com/v0/define?term={Uri.EscapeUriString(search)}");
                Console.WriteLine("And Searched " + search);
                try
                {
                    var items = JObject.Parse(result);
                    var item = items["list"][0];
                    var word = item["word"].ToString();
                    var def = item["definition"].ToString();
                    var link = item["permalink"].ToString();


                    var embed = new EmbedBuilder();
                    embed.WithColor(new Color(0x2DFF00));
                    embed.WithUrl(link);
                    embed.WithAuthor(eab => eab.WithIconUrl("https://pbs.twimg.com/profile_images/838627383057920000/m5vutv9g.jpg").WithName(word));
                    embed.WithDescription(def);

                    await ReplyAsync("", false, embed);
                }
                catch
                {
                    await ReplyAsync("No Results Found");
                }
            }
        }
    }
}

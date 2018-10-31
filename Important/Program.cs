using System.Threading.Tasks;
using System;
using Discord.WebSocket;
using Discord;
using System.IO;

namespace Piece_Of_Shit
{
    public class Program
    {
        DiscordSocketClient _client;
        CommandHandler _handler;

        static void Main(string[] args)
       => new Program().StartAsync().GetAwaiter().GetResult();

        public async Task StartAsync()
        {
            if (Config.bot.token == "" || Config.bot.token == null) return;
            _client = new DiscordSocketClient(new DiscordSocketConfig { LogLevel = LogSeverity.Verbose });
            _client.Log += OnLogAsync;

            await _client.SetGameAsync("Fuck All | )Imretarded");
            await _client.SetStatusAsync(UserStatus.DoNotDisturb);

            await _client.LoginAsync(TokenType.Bot, Config.bot.token);
            await _client.StartAsync();
            _handler = new CommandHandler();
            await _handler.InitalizeAsync(_client);
            await Task.Delay(-1);
        }

        private async Task OnLogAsync(LogMessage msg)
        {
            Console.WriteLine(DateTime.Now +  $" {msg.Message}" + "\n");
        }
    }
}
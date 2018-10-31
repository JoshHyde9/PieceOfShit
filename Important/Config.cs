using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Piece_Of_Shit
{
    class Config
    {
        private const string ConfigFolder = "Recources";
        private const string ConfigFile = "config.json";

        public static BotConfig bot;

        static Config()
        {
            if (!Directory.Exists(ConfigFolder)) Directory.CreateDirectory(ConfigFolder);
            if (!File.Exists(ConfigFolder + '/' + ConfigFile))
            {
                bot = new BotConfig();
                string json = JsonConvert.SerializeObject(bot, Formatting.Indented);
                File.WriteAllText(ConfigFolder + '/' + ConfigFile, json); 
            }
            else
            {
                string json = File.ReadAllText(ConfigFolder + '/' + ConfigFile);
                bot = JsonConvert.DeserializeObject<BotConfig>(json); 
            }
        }
    }

    public struct BotConfig
    {
        public string token;
        public string cmdPrefix;
    }
}

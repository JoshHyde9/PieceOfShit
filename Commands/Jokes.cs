using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.Webhook;
using Discord;

namespace Piece_Of_Shit.Commands
{
    public class Jokes : ModuleBase<SocketCommandContext>
    {
        Random rand;

        string[] feminists = new string[]
        {
            "How do you confuse a feminist? Tell her that you refuse to allow her to make you a sandwich.","Feminists, If you hate men so much, why are you always trying to be like us?","What's the difference between a feminist and a gun? A gun has only one trigger.",
            @"How many feminists does it take to screw in a light bulb? Twelve:
 One to screw it in.
 One to excoriate men for creating the need for illumination.
 One to blame men for inventing such a faulty means of illumination.
 One to suggest the whole 'screwing' bit to be too 'rape-like'.
 One to deconstruct the lightbulb itself as being phallic.
 One to blame men for not changing the bulb.
 One to blame men for trying to change the bulb instead of letting a woman do it.
 One to blame men for creating a society that discourages women from changing light bulbs.
 One to blame men for creating a society where women change too many light bulbs.
 One to advocate that light bulb changers should have wage parity with electricians.
 One to alert the media that women are now 'out-lightbulbing' men.
 One to just sit there taking pictures for her blog for photo-evidence that men are unnecessary.","How many feminists does it take to change a lightbulb? Don't be stupid, feminists can't change anything!","I went to a feminist picnic the other day. It was great, apart from the fact no one made any sandwiches.",
            "What did the feminist woman get her family for Christmas? A bigger litter box and a brand new scratching post.","What's the difference between a baby and a feminist? At some point in it's life, a baby will grow up and stop crying.",
            "What's the first question during a feminist quiz night? What are you looking at?","What's the male equivalent of a feminist? A sexist.",
        };
        string[] offensives = new string[]
        {
            "My Grandpa said, 'Your generation relies too much on technology!' I replied, 'No, your generation relies too much on technology!' Then I unplugged his life support.","How do Ethiopians celebrate their kids first birthday? By putting flowers on the grave.",
            "How long does it take for a black woman to take a shit? Nine months.","What's the difference between jelly and jam? I can't jelly my dick down a baby's throat.","9 out of 10 people enjoy gang rape","What's the difference between cancer and black people? Cancer got Jobs.",
            "What did the boy with no hands get for Christmas? GLOVES! Nah, just kidding... He still hasn't unwrapped his present.",
        };
        string[] jews = new string[]
        {
            "How many Jews can you fit into a car? 2 in the front, 3 in the back, and 5,999,995 in the ashtray","Why do Jews have big noses? Because air is free.","Jesus Christ fed 2,000 people with 5 loaves of bread and 2 fish, but Adolf Hitler made 6 million Jews toast.",
            "How did Hitler kill so many Jews? Free transportation.",
        };
        string[] blondes = new string[]
        {
            "What do you call a brunette between two blondes? The translator.","What do you call a basement full of blondes? A whine cellar.","What do you call a blonde in a leather jacket? A rebel without a clue.","What's the difference between a blonde and a hole in the mattress? I still can't find the difference.","What do you call a fly in a blonde's brain? A space invader.",
            "How are blondes and computers similar? You never appreciate them until they go down on you.","Why do blondes wear green lipstick? Because red means stop.","How do you make a blonde laugh on Friday? Tell her a joke on Monday.","What do you call three blondes at Christmas? Ho, ho, ho!","Why don't blondes take birth control pills? The pills keep falling out.",
            "Why does the blonde have the biggest tits in the third grade? Because she's 21.","What does a blonde say when she finds out she's pregnant? 'Are you sure it's mine?'","Why did the blonde build a bridge across the river? So she could have shade when she swam across.",
            "A blonde goes to work in tears. Her boss asks, 'What's wrong?' She says, 'My mom died.'. He told her to go home, but she said, 'No, I'll be fine.' Later that day, her boss finds her crying again. He says, 'What's wrong?' She replies, 'I just talked to my sister, and her mom died, too!'",
        };
        string[] darks = new string[]
       {
           "What do you call a white girl that can run faster than her brothers? The redneck virgin.","Why can't orphans play baseball? They dont know where home is.","My daughter has gotten to the age where she asks me embarrassing questions about sex, Just this morning she asked me 'Is that the best you can do?'",
           "A thai woman runs into a wall, what does he break? Her boner."," How do you get a baby into a small box? With a Blender. How do you get a baby out of a small box? With Doritos"," Whats the best part of an ISIS joke? The Execution.",
           "So I was fucking my daughter the other night, and I don't know what was funnier.The look on my wife's face when she walked in on me or the fact that the abortion clinic let me keep her."," What do spinach and anal sex have in common?If you were forced to have it as a kid you will hate it as an adult.",
           "Dark humour is like food, not everyone gets it.","A man goes into a library and asks for a book on suicide. The librarian says, 'Fuck off, you won't bring it back.'","What do Sarah Palin and Iron Man have in common? They both had a Downey Jr. inside of them.","What's the best part about fucking a 12-year-old girl? If you flip her over she looks like her little brother",

       };
        string[] oneliners = new string[]
        {
            "Why is bleaching your anus not called 'changing your ringtone'?","Vodka might not be the answer, but it's worth a shot.","Helen Keller walks into a bar, and then into a table, and then into a chair.",
            "Just started dating a soccer player, she’s a keeper.","If you lose your tree, try stapling a picture of it to a cat.","I saw a sign that said 'watch for children' and I thought, 'That sounds like a fair trade'",
            "A man walked into his house and was delighted when he discovered that someone had stolen all of his lamps.","Used to be into S&M, Bestiality and Necrophilia until I realized I was beating a dead horse.",
            "Whiteboards are remarkable.","Like the leper said to the prostitute, 'keep the tip'.","This morning I was staring at my naked body in the mirror and thought 'I'm gonna get kicked out of this Ikea pretty soon'.",
        };
        [Command("joke")]
        public async Task joke()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine($"{Context.User.Username} Wanted The List Of The Available Jokes");

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Wanted The List Of The Available Jokes"));

            var embed = new EmbedBuilder();
            embed.WithColor(new Color(0x0000FF));
            embed.WithAuthor("Current Jokes");
            embed.WithDescription("**Feminist**\n**Offenisve**\n**Jew**\n**Blonde**\n**Dark**\n**Oneliner**\n");

            await ReplyAsync("", false, embed);
        }
        [Command("feminist")]
        public async Task feminist()
        {
            rand = new Random();
            int randomIndex = rand.Next(feminists.Length);
            string text = feminists[randomIndex];

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Sent A feminist Joke")); 
            Console.WriteLine(text);

            await ReplyAsync(text);
        }
        [Command("offensive")]
        public async Task offenisve()
        {
            rand = new Random();
            int randomIndex = rand.Next(offensives.Length);
            string text = offensives[randomIndex];
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Sent Am Offensive Joke")); 
            Console.WriteLine(text);

            await ReplyAsync(text);
        }
        [Command("jew")]
        public async Task jew()
        {
            rand = new Random();
            int randomIndex = rand.Next(jews.Length);
            string text = jews[randomIndex];

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Sent A Jew Joke"));
            Console.WriteLine(text);

            await ReplyAsync(text);
        }
        [Command("blonde")]
        public async Task blonde()
        {
            rand = new Random();
            int randomIndex = rand.Next(blondes.Length);
            string text = blondes[randomIndex];

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Sent A Blonde Joke"));
            Console.WriteLine(text);

            await ReplyAsync(text);
        }
        [Command("dark")]
        public async Task dark()
        {
            rand = new Random();
            int randomIndex = rand.Next(darks.Length);
            string text = darks[randomIndex];

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Sent A Dark Joke"));
            Console.WriteLine(text);

            await ReplyAsync(text);
        }
        [Command("oneliner")]
        public async Task oneliner()
        {
            rand = new Random();
            int randomIndex = rand.Next(oneliners.Length);
            string text = oneliners[randomIndex];

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Sent A Oneliner Joke"));
            Console.WriteLine(text);

            await ReplyAsync(text);
        }
    }
}

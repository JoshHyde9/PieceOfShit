using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Piece_Of_Shit.Commands
{
    public class Lyrics : ModuleBase<SocketCommandContext>
    {
        Random rand;

        string[] lyrics = new string[]
        {
@"I hear the drums echoing tonight
But she hears only whispers of some quiet conversation
She's coming in, 12:30 flight
The moonlit wings reflect the stars that guide me towards salvation
I stopped an old man along the way
Hoping to find some long forgotten words or ancient melodies
He turned to me as if to say, Hurry boy, it's waiting there for you
It's gonna take a lot to take me away from you
There's nothing that a hundred men or more could ever do
I bless the rains down in Africa
Gonna take some time to do the things we never had
The wild dogs cry out in the night
As they grow restless, longing for some solitary company
I know that I must do what's right
As sure as Kilimanjaro rises like Olympus above the Serengeti
I seek to cure what's deep inside, frightened of this thing that I've become
It's gonna take a lot to drag me away from you
There's nothing that a hundred men or more could ever do
I bless the rains down in Africa
Gonna take some time to do the things we never had
Hurry boy, she's waiting there for you
It's gonna take a lot to drag me away from you
There's nothing that a hundred men or more could ever do
I bless the rains down in Africa
I bless the rains down in Africa
(I bless the rain)
I bless the rains down in Africa
(I bless the rain)
I bless the rains down in Africa
I bless the rains down in Africa
(Ah, gonna take the time)
Gonna take some time to do the things we never had",

@"All I want to do when I wake up in the morning is see you eyes
Rosanna, Rosanna
Never thought that a girl like you could ever care for me, Rosanna
All I want to do in the middle of the evening is hold you tight
Rosanna, Rosanna
I didn't know you were looking for more than I could ever be
Not quite a year since she went away, Rosanna
Now she's gone and I have to say
Meet you all the way, meet you all the way
Meet you all the way, meet you all the way, Rosanna, yeah
Meet you all the way, meet you all the way
Meet you all the way, meet you all the way, Rosanna, yeah
I can see your face still shining through the window on the other side
Rosanna, Rosanna
I didn't know that a girl like you could make me feel so sad, Rosanna
All I want to tell you is now you'll never ever have to compromise
Rosanna, Rosanna
I never thought that losing you could ever hurt so bad
Not quite a year since she went away, Rosanna, yeah
Now she's gone and I have to say
Meet you all the way, meet you all the way
Meet you all the way, meet you all the way, Rosanna, yeah
Meet you all the way, meet you all the way
Meet you all the way, meet you all the way, Rosanna, yeah
Not quite a year since she went away, Rosanna, yeah
Now she's gone and I have to say
Meet you all the way, meet you all the way
Meet you all the way, meet you all the way, Rosanna, yeah
Meet you all the way, meet you all the way
Meet you all the way, meet you all the way, Rosanna, yeah
Meet you all the way, meet you all the way
Meet you all the way, meet you all the way, Rosanna, yeah
Meet you all the way, meet you all the way
Meet you all the way, meet you all the way, Rosanna, yeah",

@"Somebody once told me the world is gonna roll me
I ain't the sharpest tool in the shed
She was looking kind of dumb with her finger and her thumb
In the shape of an L on her forehead
Well the years start coming and they don't stop coming
Fed to the rules and I hit the ground running
Didn't make sense not to live for fun
Your brain gets smart but your head gets dumb
So much to do, so much to see
So what's wrong with taking the back streets?
You'll never know if you don't go
You'll never shine if you don't glow
Hey now, you're an all-star, get your game on, go play
Hey now, you're a rock star, get the show on, get paid
And all that glitters is gold
Only shooting stars break the mold
It's a cool place and they say it gets colder
You're bundled up now, wait till you get older
But the meteor men beg to differ
Judging by the hole in the satellite picture
The ice we skate is getting pretty thin
The water's getting warm so you might as well swim
My world's on fire, how about yours?
That's the way I like it and I never get bored
Hey now, you're an all-star, get your game on, go play
Hey now, you're a rock star, get the show on, get paid
All that glitters is gold
Only shooting stars break the mold
Hey now, you're an all-star, get your game on, go play
Hey now, you're a rock star, get the show, on get paid
And all that glitters is gold
Only shooting stars
Somebody once asked could I spare some change for gas?
I need to get myself away from this place
I said yep what a concept
I could use a little fuel myself
And we could all use a little change
Well, the years start coming and they don't stop coming
Fed to the rules and I hit the ground running
Didn't make sense not to live for fun
Your brain gets smart but your head gets dumb
So much to do, so much to see
So what's wrong with taking the back streets?
You'll never know if you don't go (go!)
You'll never shine if you don't glow
Hey now, you're an all-star, get your game on, go play
Hey now, you're a rock star, get the show on, get paid
And all that glitters is gold
Only shooting stars break the mold
And all that glitters is gold
Only shooting stars break the mold",

@"Ocean man, take me by the hand, lead me to the land that you understand
Ocean man, the voyage to the corner of the globe is a real trip
Ocean man, the crust of a tan man imbibed by the sand
Soaking up the thirst of the land
Ocean man, can you see through the wonder of amazement at the oberman
Ocean man, the crust is elusive when it casts forth to the childlike man
Ocean man, the sequence of a life form braised in the sand
Soaking up the thirst of the land
Ocean man, ocean man
Ocean man
Ocean man, take me by the hand, lead me to the land that you understand
Ocean man, the voyage to the corner of the globe is a real trip
Ocean man, the crust of a tan man imbibed by the sand
Soaking up the thirst of the land
Ocean man, can you see through the wonder of amazement at the oberman
Ocean man, the crust is elusive when it casts forth to the childlike man
Ocean man, the sequence of a life form braised in the sand
Soaking up the thirst of the land", 

        };

       [Command("lyric")]
        public async Task lyric()
        {
            rand = new Random();
            int randomIndex = rand.Next(lyrics.Length);
            string lyric = lyrics[randomIndex];

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Used Lyric Command"));
            Console.WriteLine(lyric);

            await ReplyAsync(lyric);
        }
    }
}

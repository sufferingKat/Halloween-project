using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Halloween_Project
{
    class TextManagement
    {
        public string InventoryList(Inventoriere inventory)
        {
            return inventory.ListItems(); ;
        }
        public string GettingStarted()
        {
            return "Welcome, stranger. What is your name?";
        }

        public string Intro1()
        {
            return "It is a dark and stormy night. The yellow moon is barely visible through the clouds once in a while, and while you have prepared plenty of candy for trick-or-treaters for the night, you have yet to have any arrive at your door. It is still quite early, so you don't think too much of it, but as the clock keeps ticking, and another hour passes and there still isn't anyone there, you decide it is time to take a look outside and see what is going on.\n";
        }
        public string Intro1B()
        {
            return "Open Door";
        }

        public string Intro2()
        {
            return "\nAs you open the front door a light gust blows into the house, as if the pressure is different outside, and a thick mist rolls in over your feet, before swiftly dissipating in the warmth inside. You don't think too much of it as you open the door fully and look outside. You sneeze slightly as a gust blows into your face, and it takes you a moment before you can focus on the street outside. As your vision clears, you can see there isn't anyone at all outside. The street, what little you can make out of it through the thick fog anyway, is empty and the single lamppost across the street gives off an eerie, yellow glow. You pull your jacket from it's hanger and put it on, ensuring you have your keys in your pocket.\nYou put on your shoes and prepare yourself mentally.\nShoes acquired.\nJacket acquired.\n";
        }
        public string Intro2B()
        {
            return "Advance!";
        }

        public string Intro3()
        {
            return "\nAs you step outside the air is thick with fog, yet an orange moon glares down at you from above as if the haze has no effect on it's visibility.\nYou have a choice now: Do you take the path up the street to the left, or do you check on the park down to your right?\n";
        }

        public string West1()
        {
            return "\nYour first step towards towards the hill to your left sends a feeling of dread up your spine, but far be it for you to back down so early. You set a quick pace as you head into the thick fog, once in a while you catch a glimpse of something in the corner of your eye, but for some reason you don't even turn to check, as if something is driving you onwards.\n";
        }
        public string West1B()
        {
            return "Worry";
        }

        public string West2()
        {
            return "\nThe fog thickens and you start feeling nervous, this is clearly not the right way. As you start turning back towards whence you came, you feel a presence behind you. It feels as if the moment you turn around, your life will end, as if something is standing right behind you just waiting for you to turn ever so slightly too much. As you swiftly face back towards the thick fog ahead, the presence fades ever so slightly. There is no choice, you have to press forward, the presence behind you feels horribly malicious, and you make no effort to prevent your feet starting to move ahead, even if you're sure it wasn't entirely your decision.\n";
        }
        public string West2B()
        {
            return "Tremble";
        }

        public string West3()
        {
            return "As you press onwards into the thick fog, you have a faint sense of realization that you are no longer on a sidewalk anymore and haven't been for quite a while. The ground beneath you is soft and keeps going up and up. Suddenly the air clears, no longer opressively thick and clinging to your very being, you take a single breath. As you sigh in relief and gaze up at the glaring moon, you find that your left foot is slipping, and as you glance down, you are the tip of a cliff, the fog dances beneath you as you fall forward and off.\n";
        }
        public string West3B()
        {
            return "Scream";
        }

        public string East1()
        {
            return "\nYou take a right, holding a comfortable pace towards the park. The fog is thick, but not thick enough to prevent you from still seeing a good few meters ahead. It doesn't take long before the road turns in a sharp turn and you take a moment to glance around. The mist is lighter here than it was by your house, or at least it is on the road. You can't see much past the houses on either side, and the sky is still covered in thick clouds.. or is that the mist too?\n";
        }
        public string East1B()
        {
            return "Go Parkways";
        }

        public string East2()
        {
            return "\nYou start walking again after a while, and just as the road straightens out again, you see a light glow in the distance, the park seems to be quite active. Perhaps there are people out after all!\n";
        }
        public string East2B()
        {
            return "Stroll on";
        }

        public string East3()
        {
            return "\nAs you get to the park, the obvious halloween decorations are quite a sight. Pumpkins stacked and carved, torches and skulls. An eerie yellowish slight green glow flickers from the park entrance, though with the tall hedge surrounding the park, you can't make out what makes the glow.\n";
        }
        public string East3B()
        {
            return "Enter park";
        }

        public string East4()
        {
            return "\nAs you enter the park, the most obvious thing are the bonfires, each with a bubbling cauldron over them. Old ladies seemingly dressed up as witches and crones each stand over their own cauldron, slowly adding things to the bubbling stews while slowly stirring them with large ladle. All across the park are figures, both large and small shuffling around, causing a rucus and otherwise seeming to enjoy themselves. \nIt takes you a few moments before you notice two figures speaking to you from down on the ground. After shifting your focus down, you look at a Bucket and a Pumpkin, both speaking to you with large gaping maws. The Pumpkin is large, round and with a jagged maw and sharp eyes carved into it's face. It somehow has an orange glow emanating from inside, though no candle or other source is visible.. in fact, it looks quite hollow. The large metal Bucket is filled to the brim with apples, a gaping maw and two empty holes are all rusted into it's front face. It clatters slightly when it moves, and when it speaks, apples occasionally get stuck in it's rusty maw, only getting out of the way as the bucket crushes them and spit out the remains. \nWhich one do you give your attention?\n";
        }

        public string Pumpkin0B()
        {
            return "The Pumpkin";
        }

        public string Pumpkin1()
        {
            return "\nThe pumpkin tells a bad joke your expense. At least the bucket is laughing.\n";
        }

        public string Pumpkin1B()
        {
            return "Laugh";
        }

        public string Pumpkin2()
        {
            return "The pumpkin gives you a knife for your good sport!\n";
        }
        public string Pumpkin2B()
        {
            return "Inspect it";
        }

        public string Pumpkin3()
        {
            return "You glance over the blade for a moment, it's a bit dull and seems to be quite old, scratches all over the blade appears to form a pattern, though you can't quite make it out. The bucket spits out another apple, demanding your attention.";
        }

        public string Bucket0B()
        {
            return "The Bucket";
        }

        public string Bucket1()
        {
            return "The bucket disapproves of your very existance, and demands you cease it at once.\n";
        }
        public string Bucket1B()
        {
            return "Look dismayed";
        }

        public string Bucket2()
        {
            return "The bucket is amused by your confusion and dismay. In a flash, you spin around and fall to the ground, feeling something drag your jacket off your still body.\n";
        }
        public string Bucket2B()
        {
            return "Suffer";
        }

        public string Bucketing1()
        {
            return "\nTurn to bucket now that you have a knife. It seems slightly less intimidating now that you are holding something sharp in your hands, though it must just be a trick of the mind.\n";
        }
        public string Bucketing1B()
        {
            return "Stare";
        }

        public string Bucketing2()
        {
            return "\nYou offer the bucket your jacket for an apple, an offer it greedily accepts. It's rusty clattering is swiftly silenced as you toss your jacket over the rusty bucket, and an undamaged apple rolls forwards over the grass towards you.\nYou pick up the apple.\n";
        }
        public string Bucketing2B()
        {
            return "Thank it";
        }

        public string Bucketing3()
        {
            return "\nYou thank the bucket for the kind offer and look around. It's a bit chilly without your jacket, so you decide that the best place to go would be to one of the bonfires with cauldrons.\n";
        }

        public string Witch1()
        {
            return "\nYou proceed into the park itself, and upon approaching the nearest witch, she demands you offer her an apple in return for the warmth of her fire.\n";
        }
        public string Witch1B()
        {
            return "Give it";
        }

        public string Witch2()
        {
            return "\nShe lets out a loud cackle as you gladly hand over the apple. With a flash of slightly yellow teeth, she points to your knife and demands you hand it over too.\n";
        }
        public string Witch2B()
        {
            return "Hand over";
        }

        public string Witch3()
        {
            return "\nTossing the apple into the air, she slashes wildly with the knife, before tossing it too into the cauldron. She swiftly starts chanting some unintelligible words that seem to rhyme as she starts stirring it with her ladle. Bubbles rise more and more in the thick fluid until a sudden \"pop\" brings it all to a boil. With a single move, she lifts the entire cauldron up and carries it to a puddle in the center of the park, where the moon is reflected, and with another loud laugh pours all within the cauldron into the moon's reflection. The moon slowly turns back to it's regular color and the eerie fog starts withdrawing. You feel tired. Looking away from the reflection of the moon to question the witch, you suddenly realize you are alone in the park.\n";
        }
        public string Witch3B()
        {
            return "Exit park";
        }

        public string Home1()
        {
            return "\nYou leave the park by the gate you entered by, the various shapes and shadows you had noticed earlier seem to all have gone already, leaving only an empty rusty bucket and an old carved pumpkin lying near the entrance, the bucket seems to have been kicked over at some point, and the pumpkin no longer glows from inside. As you walk back up the street, you can't help but notice it seems most of the gardens and hedges are a bit overgrown, but you think nothing of it.\n";
        }
        public string Home1B()
        {
            return "Homewards";
        }

        public string Home2()
        {
            return "\nIt takes you a while, but eventually you reach your own house. You stop in front of it and gaze up and down the street, confirming once again that there is not a living soul walking about. In fact, last you had a clear view of the street you could've sworn it was a lot more.. tidy. Fallen leaves cover the street and gardens, the lawns look unmowed at best, and overall everything seems to have gotten a little unkempt. You are however, too tired for such difficult lines of thought, and swiftly walk up to your front door.\n";
        }
        public string Home2B()
        {
            return "Enter";
        }

        public string Home3()
        {
            return "You close your front door behind you, lock it tightly and stretch slowly. Your jacket is gone, and it feels like you've been out walking for a week. In a sleepy daze, you stumble towards your living room and collapse on the large couch, and sleep for what feels like an eternity...";
        }


        public string Ded1()
        {
            return "\nThe darkness engulfs you slowly, and all you have left are your regrets and a sense that you have failed.\n";
        }

        public string Ded2()
        {
            return "All fades to black as you cease breathing. You have an uncomfortable sense that the orange moon still watches you.\n";
        }

        public string GameOver()
        {
            return "This is the end for you. Better try again!";
        }
    }
}

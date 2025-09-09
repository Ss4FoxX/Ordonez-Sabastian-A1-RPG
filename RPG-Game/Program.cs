using System.Numerics;

//actual game here!
Console.WriteLine("You awaken with a crash, you dropped from the sky into a large planetarian style greenhouse.");
Console.WriteLine("To the left is a door, all colour seems to fade near it. ");
Console.WriteLine("The middle path holds a large, sprawling tree that reaches beyond the glass panes.");
Console.WriteLine("Finally, to the right what appears to be lights and an exit to the emediet area.");
string Answer = Console.ReadLine();

//to Bunker and her insanity
if (Answer == "Left")
{
    Console.WriteLine("You begin to head left, you find a large steel bunker door, as you begin to turn back you hear the door 'Ka-Chink!' and it slowly opening");
    Console.WriteLine("Will you Enter or Turn-back?");
    Answer = Console.ReadLine();
    if (Answer == "Enter")
    {
        Console.WriteLine("You step into the building, directly past the door holds a staircase.");
        Console.WriteLine("The roof apears to have an expertly carved crawlspace. you swear you could see something moving inside.");
        Console.WriteLine("A hallway with multiple, labeled doors, at the very end, the only unlabled door is opened and somebody is inside.");
        Console.WriteLine("will you Search the rooms, or Confront the mystery person?");

        Answer = Console.ReadLine();

            if (Answer == "Search")
        {
            // 
            Console.WriteLine("You decided to search the labled doors, while most are storage closets, one has ''Living Quarters'' on it, out of curiosity you enter.");
            Console.WriteLine("While searching, you trip on.. a wire? the door behind you slams shut, while getting yourself picked up you notice the wire, you relise its a tendon of a muscle");
            Console.WriteLine("The room begins to fill with a watery substance, it stings to the touch. Before it reaches above your ankles you are grabbed by hands from the ceiling.");
            Console.WriteLine("'Don't go into any closed doors! simple etiquette is a thing y'know? why'd you curious ones always end up in MY home.' the feminine voice drops you into a room.");
            Console.WriteLine("  ");
        }
        else if (Answer == "Confront")
        {
            Console.WriteLine("As you aproach, you notice she has a large protrusion coming from her back, it reaches into the ceiling.");
            Console.WriteLine("She finally notices you when you open the door, she whips around, and fires what appears to be a stinger from her forearm");
            Console.WriteLine("While she misses, she does manage to nick your ear.");
            Console.WriteLine(" ");
        }

            Console.WriteLine("'Hey, HEY! are you alright? I apologise i'm not usually.. this skittish. My name is Bunker!'");
        Console.WriteLine("'At least.. That's what the other's called me, what's your name?");
        string Name = Console.ReadLine();
        Console.WriteLine($" '{Name}, huh? Nice to  meet you! follow me! I know a way out of this place.'");
        Console.WriteLine("'This place is dangerous, I've seen insect like beings scout my door, leave and come back with a small army. It's fight or flight here.'");
        Console.WriteLine("She leads you to a door, its latch immediently clicks and the door opens. Inside is a single  large spinning ring.");
        Console.WriteLine("'Before I became.. this, the ring was an emergency exit for me, the power fades for abit every warp, but it should get you home.'");
        Console.WriteLine("Bunker has already begun pushing you to the ring, your only option is to Enter it");
        Console.WriteLine(" ");

        Answer = Console.ReadLine();
         if (Answer == "Enter")
        {
            Console.WriteLine("You attempted to enter the ring slowly, but as soon as you touched it, a bright light blinded you and you open to see your in bed.");
            Console.WriteLine("Bunker's Warp Ring Ending");
        }
    }

    else if (Answer == "Turn-back")
    {
        //Evil forearm bone stinger
        Console.WriteLine("As you turn back, not even a step away a large stinger pierces through your stomoach.");
        Console.WriteLine("you have died to Bunker.");
    }
}
else if (Answer == "Middle")
{
    Console.WriteLine("");
}
string ender = Console.ReadLine();
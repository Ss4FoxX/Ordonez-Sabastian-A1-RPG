using System.Numerics;

Boolean keystone = false;

Console.WriteLine("You awaken with a crash, you dropped from the sky into a large planetarian style greenhouse.");
Console.WriteLine("To the left is a door, all colour seems to fade near it. ");
Console.WriteLine("The Right path holds a large, sprawling tree that reaches beyond the glass panes.");
Console.WriteLine("will you go Left or Right?");
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
        Console.WriteLine("you have died to Bunker. (victimless End)");
    }
}
else if (Answer == "Right")
{
    //Curious Light shows the ways
    Console.WriteLine("Heading towards the gaint tree, a yellow light suddenly reveals another set of choices");
    Console.WriteLine("the door to the building infront of you, the light appears to pull the planks keeping it shut off, opening the path.");
    Console.WriteLine("the light reveals a door in the bark of the tree, a possible escape perhaps?");
    Console.WriteLine("do you head into the Building, or try the Door?");
    Answer = Console.ReadLine();
    if (Answer == "Building")
    {
        Console.WriteLine("Entering the building, every wall is scratched and cracking.");
        Console.WriteLine("while walking, a star like object begins to shine.");
        Console.WriteLine("will you pick it up? (Pick-up , Do-not)");
        Answer = Console.ReadLine();
        if (Answer == "Pick-up")
        {
            Console.WriteLine("You pick up the shining stone");
            Console.WriteLine("before another second passes, you hear something behind you,");
            Console.WriteLine("Looking back, is a large, multi limbed, amalgamation. and every eye it has is staring at you");
            Console.WriteLine("while slow, you still only have 2 options, Run down the hallway, or Return to the door.");
            Answer = Console.ReadLine();
            if (Answer == "Run")
            {
                Console.WriteLine("you choose to run down the halls. you hear it stomping after you, swearing it's laughing.");
                Console.WriteLine("The halls quickly become an unending maze, and you begin to tire, the beast has not, however.");
                Console.WriteLine("as you slow, you feel it grab you. in an instant you black out. when you wake, you can't move your limbs, at least not willingly.");
                Console.WriteLine("You spot another poor soul in this mess, and is forced to begin chasing.");
                Console.WriteLine("Amalgamated End");
            }

            else if (Answer == "Return")
            {
                Console.WriteLine("you rush to the door, you try the handle but it doesn't budge.");
                Console.WriteLine("Noticing the hole, you shove the Star Stone into the hole. The lumbering beast rapidy approches");
                Console.WriteLine("the door swings open, you rush in, and you hear nothing but the birds at the window.");
                Console.WriteLine("You're in your home, just infront of the front door.");
                Console.WriteLine("true Escape Ending");

            }

        }
        else if (Answer == "Do-not")
        {
            if (Answer == "Run")
            {
                Console.WriteLine("you choose to run down the halls. you hear it stomping after you, swearing it's laughing.");
                Console.WriteLine("The halls quickly become an unending maze, and you begin to tire, the beast has not, however.");
                Console.WriteLine("as you slow, you feel it grab you. in an instant you black out. when you wake, you can't move your limbs, at least not willingly.");
                Console.WriteLine("You spot another poor soul in this mess, and is forced to begin chasing.");
                Console.WriteLine("Amalgamated End");
            }

            else if (Answer == "Return")
            {
                Console.WriteLine("you rush to the door, you try the handle but it doesn't budge.");
                Console.WriteLine("Noticing the hole, you shove the Star Stone into the hole. The lumbering beast rapidy approches");
                Console.WriteLine("the door swings open, you rush in, and you hear nothing but the birds at the window.");
                Console.WriteLine("You're in your home, just infront of the front door.");
                Console.WriteLine("true Escape Ending");

            }

        }

    }

    else if (Answer == "Door")
    {
            Console.WriteLine("You head to the door, and try to open it, the door doesn't budge, locked the ''Keyhole'' apears to be a star.");
            Console.WriteLine("Before you can notice any other details, you hear clicking. the floor breaks from under you.");
            Console.WriteLine("You fell into nothing (Voidbound End)");
    }
    
}
string ender = Console.ReadLine();
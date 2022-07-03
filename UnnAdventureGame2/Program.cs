using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnAdventureGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unn wakes up in the middle of a familiar forest, looking around, he sees a cave and a little shack in opposite directions. Which way will he travel?");

            string initialDirection = Console.ReadLine();
            if (initialDirection == "cave")
            {
                Console.WriteLine("Unn walks over to a dark cave with vines wrapped around the edges. Suddenly, Unn gets startled by a deep groan. Should Unn continue silently or call to the voice?");
                string caveAction1 = Console.ReadLine();
                if (caveAction1 == "continue silently")
                {
                    Console.WriteLine("Unn begins silently walking into the cave with such extreme sneakiness that not even he hears a sound or sees for that matter. Lost in the pitch black, silent cave, Unn wanders with no success. ");
                }
                else if (caveAction1 == "call to the voice")
                {
                    Console.WriteLine("Unn shouts back, \"Hey, you there! Come hither!\", slowly, Unn hears stomping approaching that makes the ground quake. Unn wonders, should he run or stand his ground?");
                    string caveAction2a = Console.ReadLine();
                    if (caveAction2a == "run")
                    {
                        Console.WriteLine("With overwhelming fear, Unn turns around and runs as far as he can from the cave. He runs and runs for longer than he can remember. Time loses all meaning to Unn as he bolts through distant lands never to be seen again. ");
                    }
                    else if (caveAction2a == "stand his ground")
                    {
                        Console.WriteLine("Unn stands his ground at the entrance ready to attack at a moments notice. Suddenly, a dragon emerges from the cave. Unn wonders how to react, should he attack or run?");
                        string caveAction3a = Console.ReadLine();
                        if (caveAction3a == "run")
                        {
                            Console.WriteLine("With overwhelming fear, Unn turns around and runs as far as he can from the cave. He runs and runs for longer than he can remember. Time loses all meaning to Unn as he bolts through distant lands never to be seen again. ");
                        }
                        else if (caveAction3a == "attack")
                        {
                            Console.WriteLine("With rejuvenated vigor, Unn clobbers the dragon with extreme force blowing the beast back into the cave. Feeling accomplished with life, Unn walks triumphantly into the distance. ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Feeling confused over what to do, Unn stands at the enterance. Suddenly, a dragon emerges from the cave. Unn wonders how to react, should he attack or run?");
                        string caveAction4a = Console.ReadLine();
                        if (caveAction4a == "run")
                        {
                            Console.WriteLine("With overwhelming fear, Unn turns around and runs as far as he can from the cave. He runs and runs for longer than he can remember. Time loses all meaning to Unn as he bolts through distant lands never to be seen again. ");
                        }
                        else if (caveAction4a == "attack")
                        {
                            Console.WriteLine("Unn attempts to strike the beast with all his might. However, due to the confusion from earlier lingering in his mind, Unn holds back only for the dragon to slap him with such tremendous force that he flies into the sky never to be seen again. ");
                        }
                        else
                        {
                            Console.WriteLine("Overwhelmed with even more confusion rattling his head, Unn loses control and dissapears into the darkness. ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Unn, confuzzled over the task at hand, waits at the cave pondering what to do. He sits and thinks hard for ages until the cave finally collapses. ");
                }
            }
            else if (initialDirection == "little shack")
            {  
                Console.WriteLine("Unn continues towards the little shack he saw in the distance. Upon reaching the house, he peers through a window and sees no one, should he enter the house or knock?");
                string shackAction1 = Console.ReadLine();
                if (shackAction1 == "enter the house")
                {
                    Console.WriteLine("Without a second thought, Unn breaks down the door to get in. Inside, he finds an abandoned interior with everything in sight covered in a thick layer of dust and cobwebs. Should he investigate or leave?");
                    string shackAction2a = Console.ReadLine();
                    if (shackAction2a == "investigate")
                    {
                        Console.WriteLine("Snooping around the shack, Unn finds a small trapdoor with a bright glow eminating from the cracks. Should Unn continue or stay?");
                        string shackAction3a = Console.ReadLine(); 
                        if (shackAction3a == "continue")
                        {
                            Console.WriteLine("Continuing through the trapdoor, the light engulfs Unn as he proceeds. At the end of a long cooridor, Unn finds a [Find out what happens next in the sequal, UnnAdventureGame3: The Return of the Unn!]");
                        }
                        else if (shackAction3a == "stay")
                        {
                            Console.WriteLine("Unn decides against going further, \"Who knows what may lie ahead?\", he thinks. Instead, Unn chooses to remain in the run down shack giving the abandoned home a new squatter. ");
                        }
                        else
                        {
                            Console.WriteLine("Puzzled over the sight of the mysterious trapdoor, Unn steps back in confusion racing over what he should do. Much time goes by without a decision being made, ultimately, the light vanishes leaving Unn alone in the darkness"); 
                        }

                    }
                    else if (shackAction2a == "leave")
                    {
                        Console.WriteLine("Fed up with the poorly maintained house, Unn stomps away too upset to continue"); 
                    }
                    else
                    {
                        Console.WriteLine("Lost in the mesmerizing collection of dirty accessories and furniture, Unn forgets about what to do opting to simply take in the view indefinitely. ");
                    }
                }
                else if (shackAction1 == "knock")
                {
                    Console.WriteLine("With confidence, Unn boldly knocks on the door. After a long wait, a short wizard answers the door. \"What? Don't you see I'm busy!?\" the wizard asks, with some deliberation, Unn responds, \"I am here to reach you about your car's extended warrant-\" only to be interrupted by a furiously slammed door. Unn walks away defeated. "); 
                }
                else
                {
                    Console.WriteLine("Unn sits down on the porch and thinks very heavily about what to do about this prediciment. With no answer, Unn walks away too let down to continue. "); 
                }
            }
            else
            {
                Console.WriteLine("In a bout of confusion, Unn lays down going nowhere. Months and years go by as Unn loses track of time. Unn begins seeing the trees wither as the world around him erodes away until nothing but him is left. ");
            }
            Console.ReadLine();
        }
    }
}

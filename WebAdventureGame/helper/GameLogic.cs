using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdventureGame.helper
{
    public class GameLogic
    {
        public static string FirstQuestion = "Unn wakes up in the middle of a familiar forest, looking around, he sees a cave and a little shack in opposite directions. Which way will he travel?";
        public static string LastQuestion = "Game over";

        public static string SetNextQuestion(string text)
        {
            return text;
        }

        public static List<GameItem> _GameItems = new List<GameItem>();

        public static List<GameItem> GameItems
        {
            get { 
                if (_GameItems.Count == 0)
                {
                    _GameItems.Add(new GameItem(1, "Unn wakes up in the middle of a familiar forest, looking around, he sees a cave and a little shack in opposite directions. Which way will he travel?", "", null));
                    _GameItems.Add(new GameItem(2, "Unn walks over to a dark cave with vines wrapped around the edges. Suddenly, Unn gets startled by a deep groan. Should Unn continue silently or call to the voice?", "cave", 1));
                    _GameItems.Add(new GameItem(3, "Unn continues towards the little shack he saw in the distance. Upon reaching the house, he peers through a window and sees no one, should he enter the house or knock?", "little shack", 1));
                    _GameItems.Add(new GameItem(4, "In a bout of confusion, Unn lays down going nowhere. Months and years go by as Unn loses track of time. Unn begins seeing the trees wither as the world around him erodes away until nothing but him is left...", "x", 1));

                    _GameItems.Add(new GameItem(5, "Unn begins silently walking into the cave with such extreme sneakiness that not even he hears a sound or sees for that matter. Lost in the pitch black, silent cave, Unn wanders with no success.", "continue silently", 2));
                    _GameItems.Add(new GameItem(6, "Unn shouts back, \"Hey, you there! Come hither!\", slowly, Unn hears stomping approaching that makes the ground quake. Unn wonders, should he run or stand his ground?", "call to the voice", 2));
                    _GameItems.Add(new GameItem(7, "Feeling confused over what to do, Unn stands at the enterance. Suddenly, a dragon emerges from the cave. Unn wonders how to react, should he attack or run?", "x", 2));

                    _GameItems.Add(new GameItem(9, "Without a second thought, Unn breaks down the door to get in. Inside, he finds an abandoned interior with everything in sight covered in a thick layer of dust and cobwebs. Should he investigate or leave?", "enter the house", 3));
                    _GameItems.Add(new GameItem(10, "With confidence, Unn boldly knocks on the door. After a long wait, a short wizard answers the door. \"What? Don't you see I'm busy!?\" the wizard asks, with some deliberation, Unn responds, \"I am here to, umm, uhh-\" only to be interrupted by a furiously slammed door. Unn walks away defeated.", "knock", 3));
                    _GameItems.Add(new GameItem(11, "Unn sits down on the porch and thinks very heavily about what to do about this prediciment. With no answer, Unn walks away too let down to continue.", "x", 3));

                    _GameItems.Add(new GameItem(12, "Rethinking his boldness, Unn decides it would be better to play it safe as he runs from the cave. However, curiosity still lingers, \"What was that stomping?\" he thinks to himself.", "run", 6));
                    _GameItems.Add(new GameItem(13, "Unn stands his ground at the entrance ready to attack at a moments notice. Suddenly, a dragon emerges from the cave. Unn wonders how to react, should he attack or run?", "stand his ground", 6));
                    _GameItems.Add(new GameItem(14, "Feeling confused over what to do, Unn stands at the enterance. Suddenly, a dragon emerges from the cave. Unn wonders how to react, should he attack or run?", "x", 6));

                    _GameItems.Add(new GameItem(15, "Snooping around the shack, Unn finds a small trapdoor with a bright glow eminating from the cracks. Should Unn continue or stay?", "investigate", 9));
                    _GameItems.Add(new GameItem(16, "Fed up with the poorly maintained house, Unn stomps away too upset to continue. \"Even thy lawn is a travesty, the HOA will love to hear of this!\" Unn snarks in the distance.", "leave", 9));
                    _GameItems.Add(new GameItem(17, "Lost in the mesmerizing collection of dirty accessories and furniture, Unn forgets about what to do opting to make the quiant shack his home. Years go by as Unn grows old taking care of the little, once abandoned looking house. Unn embraced the poor home never regretting avoiding the trapdoor those many years ago.", "x", 9));

                    _GameItems.Add(new GameItem(18, "With overwhelming fear, Unn turns around and runs as far as he can from the cave. He runs and runs for longer than he can remember. Time loses all meaning to Unn as he bolts through distant lands never to be seen again.", "run", 13));
                    _GameItems.Add(new GameItem(19, "With rejuvenated vigor, Unn clobbers the dragon with extreme force blowing the beast back into the cave. Feeling accomplished with life, Unn walks triumphantly into the distance.", "attack", 13));
                    _GameItems.Add(new GameItem(20, "Suddenly overwhelmed with a sense of confusion, Unn does nothing only to be ignored by the giant dragon towering over him.", "x", 13));

                    _GameItems.Add(new GameItem(21, "With overwhelming fear of confusion, Unn turns around and runs as far as he can from the cave. He runs and runs for longer than he can remember. Time loses all meaning to Unn as he bolts through distant lands never to be seen again.", "run", 14));
                    _GameItems.Add(new GameItem(22, "Unn attempts to strike the beast with all his might. However, due to the confusion from earlier lingering in his mind, Unn holds back only for the dragon to slap him with such tremendous force that he flies into the sky never to be seen again.", "attack", 14));
                    _GameItems.Add(new GameItem(23, "Overwhelmed with even more confusion rattling his head, Unn loses control and dissapears into the darkness.", "x", 14));

                    _GameItems.Add(new GameItem(24, "Continuing through the trapdoor, the light engulfs Unn as he proceeds. At the end of a long cooridor, Unn finds a [Find out what happens next in the sequal, AdventureGame2: The Return of the Unn!]", "continue", 15));
                    _GameItems.Add(new GameItem(25, "Unn decides against going further, \"Who knows what may lie ahead?\", he thinks. Instead, Unn chooses to remain in the run down shack giving the abandoned home a new squatter.", "stay", 15));
                    _GameItems.Add(new GameItem(26, "Puzzled over the sight of the mysterious trapdoor, Unn steps back in confusion racing over what he should do. Much time goes by without a decision being made, ultimately, the light vanishes leaving Unn alone in the darkness once more.", "x", 15));


                }
                return _GameItems; 
            }
        }

        public static GameItem GetNextQuestion(int? locationId, string answer)
        {
            var item = GameItems.Where(x => x.answer == answer && x.parentId == locationId).FirstOrDefault();
            if (item == null)
                item = GameItems.Where(x => x.answer == "x" && x.parentId == locationId).FirstOrDefault();
            return item;
/*            string nextQuestion = FirstQuestion;




            string initialDirection = answer;
            if (initialDirection == "cave")
            {
                nextQuestion = SetNextQuestion("Unn walks over to a dark cave with vines wrapped around the edges. Suddenly, Unn gets startled by a deep groan. Should Unn continue silently or call to the voice?");
                string caveAction1 = answer;
                if (caveAction1 == "continue silently")
                {
                    nextQuestion = SetNextQuestion("Unn begins silently walking into the cave with such extreme sneakiness that not even he hears a sound or sees for that matter. Lost in the pitch black, silent cave, Unn wanders with no success. ");
                }
                else if (caveAction1 == "call to the voice")
                {
                    nextQuestion = SetNextQuestion("Unn shouts back, \"Hey, you there! Come hither!\", slowly, Unn hears stomping approaching that makes the ground quake. Unn wonders, should he run or stand his ground?");
                    string caveAction2a = answer;
                    if (caveAction2a == "run")
                    {
                        nextQuestion = SetNextQuestion("With overwhelming fear, Unn turns around and runs as far as he can from the cave. He runs and runs for longer than he can remember. Time loses all meaning to Unn as he bolts through distant lands never to be seen again. ");
                    }
                    else if (caveAction2a == "stand his ground")
                    {
                        nextQuestion = SetNextQuestion("Unn stands his ground at the entrance ready to attack at a moments notice. Suddenly, a dragon emerges from the cave. Unn wonders how to react, should he attack or run?");
                        string caveAction3a = answer;
                        if (caveAction3a == "run")
                        {
                            nextQuestion = SetNextQuestion("With overwhelming fear, Unn turns around and runs as far as he can from the cave. He runs and runs for longer than he can remember. Time loses all meaning to Unn as he bolts through distant lands never to be seen again. ");
                        }
                        else if (caveAction3a == "attack")
                        {
                            nextQuestion = SetNextQuestion("With rejuvenated vigor, Unn clobbers the dragon with extreme force blowing the beast back into the cave. Feeling accomplished with life, Unn walks triumphantly into the distance. ");
                        }
                    }
                    else
                    {
                        nextQuestion = SetNextQuestion("Feeling confused over what to do, Unn stands at the enterance. Suddenly, a dragon emerges from the cave. Unn wonders how to react, should he attack or run?");
                        string caveAction4a = answer;
                        if (caveAction4a == "run")
                        {
                            nextQuestion = SetNextQuestion("With overwhelming fear, Unn turns around and runs as far as he can from the cave. He runs and runs for longer than he can remember. Time loses all meaning to Unn as he bolts through distant lands never to be seen again. ");
                        }
                        else if (caveAction4a == "attack")
                        {
                            nextQuestion = SetNextQuestion("Unn attempts to strike the beast with all his might. However, due to the confusion from earlier lingering in his mind, Unn holds back only for the dragon to slap him with such tremendous force that he flies into the sky never to be seen again. ");
                        }
                        else
                        {
                            nextQuestion = SetNextQuestion("Overwhelmed with even more confusion rattling his head, Unn loses control and dissapears into the darkness. ");
                        }
                    }
                }
                else
                {
                    nextQuestion = SetNextQuestion("Unn, confuzzled over the task at hand, waits at the cave pondering what to do. He sits and thinks hard for ages until the cave finally collapses. ");
                }
            }
            else if (initialDirection == "little shack")
            {
                nextQuestion = SetNextQuestion("Unn continues towards the little shack he saw in the distance. Upon reaching the house, he peers through a window and sees no one, should he enter the house or knock?");
                string shackAction1 = answer;
                if (shackAction1 == "enter the house")
                {
                    nextQuestion = SetNextQuestion("Without a second thought, Unn breaks down the door to get in. Inside, he finds an abandoned interior with everything in sight covered in a thick layer of dust and cobwebs. Should he investigate or leave?");
                    string shackAction2a = answer;
                    if (shackAction2a == "investigate")
                    {
                        nextQuestion = SetNextQuestion("Snooping around the shack, Unn finds a small trapdoor with a bright glow eminating from the cracks. Should Unn continue or stay?");
                        string shackAction3a = answer;
                        if (shackAction3a == "continue")
                        {
                            nextQuestion = SetNextQuestion("Continuing through the trapdoor, the light engulfs Unn as he proceeds. At the end of a long cooridor, Unn finds a [Find out what happens next in the sequal, UnnAdventureGame3: The Return of the Unn!]");
                        }
                        else if (shackAction3a == "stay")
                        {
                            nextQuestion = SetNextQuestion("Unn decides against going further, \"Who knows what may lie ahead?\", he thinks. Instead, Unn chooses to remain in the run down shack giving the abandoned home a new squatter. ");
                        }
                        else
                        {
                            nextQuestion = SetNextQuestion("Puzzled over the sight of the mysterious trapdoor, Unn steps back in confusion racing over what he should do. Much time goes by without a decision being made, ultimately, the light vanishes leaving Unn alone in the darkness");
                        }

                    }
                    else if (shackAction2a == "leave")
                    {
                        nextQuestion = SetNextQuestion("Fed up with the poorly maintained house, Unn stomps away too upset to continue");
                    }
                    else
                    {
                        nextQuestion = SetNextQuestion("Lost in the mesmerizing collection of dirty accessories and furniture, Unn forgets about what to do opting to simply take in the view indefinitely. ");
                    }
                }
                else if (shackAction1 == "knock")
                {
                    nextQuestion = SetNextQuestion("With confidence, Unn boldly knocks on the door. After a long wait, a short wizard answers the door. \"What? Don't you see I'm busy!?\" the wizard asks, with some deliberation, Unn responds, \"I am here to reach you about your car's extended warrant-\" only to be interrupted by a furiously slammed door. Unn walks away defeated. ");
                }
                else
                {
                    nextQuestion = SetNextQuestion("Unn sits down on the porch and thinks very heavily about what to do about this prediciment. With no answer, Unn walks away too let down to continue. ");
                }
            }
            else
            {
                nextQuestion = SetNextQuestion("In a bout of confusion, Unn lays down going nowhere. Months and years go by as Unn loses track of time. Unn begins seeing the trees wither as the world around him erodes away until nothing but him is left. ");
            }


            //if (question == FirstQuestion && answer == "good")
            //{
            //    nextQuestion = LastQuestion;
            //}

            return nextQuestion;*/
        }
    }
}
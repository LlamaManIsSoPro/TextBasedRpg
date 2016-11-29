using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Base_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:

            List<string> inv = new List<string>();
            int lifePoints = 10;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You look around and see someone you do not recongize");
                Console.WriteLine("He is a young man riding a llama wearing a cowboy outfit");
                Console.WriteLine("\"Get on my llama the british are coming\" the man says");
                Console.WriteLine("Do you get on the llama? (Y or N)");
                string llamaAnswer = "A";
                while (true)
                {
                    try
                    {
                        llamaAnswer = Console.ReadLine();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Thats not an answer");
                        continue;
                    }
                    break;
                }
                if (llamaAnswer == "Y") //question 1
                {
                    Console.WriteLine("\"We are the Llama Federation\"");
                    Console.WriteLine("\"When we get back to the Llama Village I'll tell you more");
                    Console.WriteLine("/\"You can get sleep when we get back, for now here is a Llama-Federation Hat\"");
                    Console.WriteLine("+1 Hat");
                    Console.WriteLine("You wake up in a bed the next day");
                    inv.Add("Hat");                   
                }
                else
                {
                    Console.WriteLine("The Britsh Empire trampel you on with their Alpaca army");
                    lifePoints -= 2;
                    Console.WriteLine("-2 HP. Your new HP is " + lifePoints);
                    Console.WriteLine("You were retrived by the Llama-Federation and slowly wake up in your bed");
                }
                Console.WriteLine("");

                foreach (string item in inv)
                {
                    Console.WriteLine("Inventory");
                    Console.WriteLine("-------");
                    Console.WriteLine(item);
                    Console.WriteLine("-------");
                }

                System.Threading.Thread.Sleep(1500);

                Console.WriteLine("So who are you?");
                string name = Console.ReadLine();
                Console.WriteLine("Your name is " + name);
                Console.WriteLine("Is this correct? (Y or N)");
                string nameAnswer = Console.ReadLine();
                while (nameAnswer == "N")
                {
                    Console.WriteLine("So who are you?");
                    name = Console.ReadLine();
                    Console.WriteLine("Your name is " + name);
                    Console.WriteLine("\"Well my name is Roger, I'll be your partner\"");
                    Console.WriteLine("Is this correct? (Y or N)");
                    nameAnswer = Console.ReadLine();
                }
                Console.WriteLine("Hello, " + name + " Welcome to the Llama-Federation. I have a few questions to see how you fit in our army");
                Console.WriteLine("So, " + name + ", do you enjoy llamas? (Y or N)");
                string likeLlamas = Console.ReadLine();
                if (likeLlamas == "Y" || likeLlamas == "y")
                {
                    Console.WriteLine("\"Well, welcome to the Llama-Federation where we will remove the Bristish Alpaca Army from our land\"");
                }                
                else
                {
                    Console.WriteLine("\"WOW, what an IMBECILE. For now I'll beat you up and you WILL join our army\"");
                    lifePoints -= 2;
                    Console.WriteLine("-2 HP. Your new HP is " + lifePoints);
                }
                Console.WriteLine("Now do you like Alpacas? (Y or N");
                string alpacaAnswer = Console.ReadLine();
                if (alpacaAnswer == "Y")
                {
                    Console.WriteLine("\"Wow, Your even worse than I thought you scum\"");
                    Console.WriteLine("\"But you will still JOIN our army\"");
                }
                else
                {
                    Console.WriteLine("Well that's one good thing about you");
                }
                
                Console.WriteLine("\"Well now that your on our side one way or another where would you like your first battle to take place?\"");
                Console.WriteLine("1. Rescue captured soliders at the Old Mountain Correctional Facility");
                Console.WriteLine("2. Re-Take the Sanctuary Of Mending");
                int adventureLocation;
                while (true)
                {
                    try
                    {
                        adventureLocation = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("thats not a number");
                        continue;
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("number too large");
                        continue;
                    }
                    break;
                }
                //Reminder to add death from alpaca army  Console.WriteLine("/" \"");
                while (true)
                {
                    if (adventureLocation == 1)
                    {
                        Console.WriteLine("\"Lets rescuse our captured ones...\"");
                        System.Threading.Thread.Sleep(2500);
                        Console.Clear();
                        Console.WriteLine("\"Lets go on llamaback to the prison\"");
                        Console.WriteLine("You get on your brand new store bought Llama and ride into the sunset towards your new captured comrardes.");
                        Console.WriteLine("It's going to take a day or two so lets pack up and go");
                        System.Threading.Thread.Sleep(3500);
                        Console.Clear();
                        Console.WriteLine("\"We are here! Do you want to go in stealthy or loud?\"");
                        Console.WriteLine("1. Like a Ninja");
                        Console.WriteLine("2. Loud and Proud");
                        int typeAnswer;
                        while (true)
                        {
                            try
                            {
                                typeAnswer = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine("thats not a number");
                                continue;
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine("number too large");
                                continue;
                            }
                            break;
                        }
                        if (typeAnswer == 1)
                        {
                            Console.WriteLine("\"Well lets go sneaky beaky like\"");
                            Console.WriteLine("You and your partner go up the hill to scout out the area");
                            Console.WriteLine("You see your comrades in a prison yard being beat by the Evil British Alpaca Army");
                            Console.WriteLine("You look over and see an enmey behind your partner with a knife");
                            Console.WriteLine("What do you do?");
                            Console.WriteLine("1. Scream \"It's the Evil British Man\"");
                            Console.WriteLine("2. Shield the knife");
                            Console.WriteLine("3. Let him die");
                            int knifeAnswer;
                            while (true)
                            {
                                try
                                {
                                    knifeAnswer = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException ex)
                                {
                                    Console.WriteLine("thats not a number");
                                    continue;
                                }
                                catch (OverflowException ex)
                                {
                                    Console.WriteLine("number too large");
                                    continue;
                                }
                                break;
                            }
                            if (knifeAnswer == 1)
                            {
                                Console.WriteLine("You scream and your partner notices the man. The man is killed but other guards are alerted of this action");
                                Console.WriteLine("Other enemy Brish people run towards you");
                                Console.WriteLine("What next?");
                                Console.WriteLine("1. Take out your Llama-Verified machine gun");
                                Console.WriteLine("2. Run and leave your comrades to die");
                                string nextAnswer = Console.ReadLine();
                                if (nextAnswer == "1")
                                {
                                    Console.WriteLine("You take out your machine gun and kill the notified enemies. You are harmed by the enmey and lose some health");
                                    // Inserted Loss of Life
                                    lifePoints -= 4;
                                    Console.WriteLine("-4 HP. Your new HP is " + lifePoints);
                                    if (lifePoints <= 0)
                                    {
                                        Console.WriteLine("You Died");
                                        break;        
                                    }
                                    //End of Life Men
                                    Console.WriteLine("\"Well thanks for the help. Have some epic shoes\"");
                                    Console.WriteLine("your Partner gives you some nice shoes");
                                    Console.WriteLine("");
                                    inv.Add("Shoes");
                                    foreach (string item in inv)
                                    {
                                        Console.WriteLine("Inventory");
                                        Console.WriteLine("-------");
                                        Console.WriteLine(item);
                                        Console.WriteLine("-------");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You try to run but your partner stabs you in the bacak making sure you die");
                                    // Inserted Loss of Life
                                    lifePoints -= 10;
                                    Console.WriteLine("-10 HP. Your new HP is " + lifePoints);
                                    if (lifePoints <= 0)
                                    {
                                        Console.WriteLine("You Died");
                                        break;
                                    }
                                    //End of Life Men                                   
                                }
                            } 
                            else if (knifeAnswer == 2)
                            {
                                Console.WriteLine("You shieed your partner from the evil Alpaca Lovers");
                                Console.WriteLine("Your partner quickly takes out his own knife and kills the enmey");
                                // Inserted Loss of Life
                                lifePoints -= 6;
                                Console.WriteLine("-6 HP. Your new HP is " + lifePoints);
                                if (lifePoints <= 0)
                                {
                                    Console.WriteLine("You Died");
                                    break;                                   
                                }
                                //End of Life Men 

                                Console.WriteLine("\"Well thanks for the help. Have some epic shoes\"");
                                Console.WriteLine("your Partner gives you some nice shoes");
                                inv.Add("Shoes");
                                foreach (string item in inv)
                                {
                                    Console.WriteLine("Inventory");
                                    Console.WriteLine("-------");
                                    Console.WriteLine(item);
                                    Console.WriteLine("-------");
                                }
                                Console.WriteLine("\"Lets go rescue our comrades one!\"");
                                Console.WriteLine("Do you want to go through the vents or over the wall?");
                                Console.WriteLine("1. Vents");
                                Console.WriteLine("2. Over the Trump Wall");
                                string sneakyAnswer = Console.ReadLine();
                                if (sneakyAnswer == "1")
                                {
                                    Console.WriteLine("Lets go through the vents!");
                                    Console.WriteLine("You smell some weird gas and lose some health");
                                    // Inserted Loss of Life
                                    lifePoints -= 2;
                                    Console.WriteLine("-2 HP. Your new HP is " + lifePoints);
                                    if (lifePoints <= 0)
                                    {
                                        Console.WriteLine("You Died");
                                        break;
                                    }
                                    //End of Life Men
                                }
                                else
                                {
                                    Console.WriteLine("You jummp over the wall without detection");
                                }
                                Console.WriteLine("You see your comrades and help them boosts over the wall to escape");
                                Console.WriteLine("You Win!");
                                break;
                            }
                            else 
                            {
                                Console.WriteLine("You can either escape now or try to avenge your partner");
                                Console.WriteLine("1. Escape");
                                Console.WriteLine("2. Avenge your partner");
                                string avengeAnswer = Console.ReadLine();
                                if (avengeAnswer == "1")
                                {
                                    Console.WriteLine("You escaped these weird people");
                                    Console.WriteLine("What kind of victory dance do you do?");
                                    Console.WriteLine("1. The Robot");
                                    Console.WriteLine("2. The Penguin");
                                    string danceAnswer = Console.ReadLine();
                                    if (danceAnswer =="1")
                                    {
                                        Console.WriteLine("Beep Boop Bop");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You do the Penguin Dance");
                                    }
                                    Console.WriteLine("You win Congrats");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You go in and attempt to avenge your parnter");
                                    Console.WriteLine("You can either take a knife out or try to fist fight him");
                                    Console.WriteLine("1. Knife");
                                    Console.WriteLine("2. Fist Fight");
                                    int fightAnswer;
                                    while (true)
                                    {
                                        try
                                        {
                                            fightAnswer = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch (FormatException ex)
                                        {
                                            Console.WriteLine("thats not a number");
                                            continue;
                                        }
                                        catch (OverflowException ex)
                                        {
                                            Console.WriteLine("number too large");
                                            continue;
                                        }
                                        break;
                                    }
                                    if (fightAnswer == 1)
                                    {
                                        Console.WriteLine("You take out your knife but in the time you take it out get stabbed and die");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You quickly beat the other guy up but your partner is dead");
                                        Console.WriteLine("You win since you can escape these crazy people");
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\"Lets go in loud\"");
                            Console.WriteLine("\"Why would you go in loud? Are you stupid? Too many enemies\"");
                            Console.WriteLine("\"We can at least try\"");
                            Console.WriteLine("What is your weapon of choice?");
                            Console.WriteLine("1. Llama-Federation Verifieid machine gun");
                            Console.WriteLine("2. Smuggled Sniper Rifle");
                            string weaponAnswer = Console.ReadLine();
                            if (weaponAnswer == "1")
                            {
                                Console.WriteLine("The Llama-Federation verified machine gun");
                                Console.WriteLine("\"Here is a Rito Games Approved Riot Shield to go with your machine gun\"");
                                Console.WriteLine("You and your parnter charge in tanking bullets from the enemy");
                                Console.WriteLine("You go in through the entrance killing any Alpaca British Scum in sight");
                                Console.WriteLine("You take a couple of bullets through your legs");
                                // Inserted Loss of Life
                                lifePoints -= 4;
                                Console.WriteLine("-4 HP. Your new HP is " + lifePoints);
                                if (lifePoints <= 0)
                                {
                                    Console.WriteLine("You Died");
                                    break;
                                }
                                //End of Life Men
                                Console.WriteLine("You into the locked down prison. The evil Bristish men have a gun pointed at your partner. You can save your partner or your captured comrades");
                                Console.WriteLine("1. Save your partner");
                                Console.WriteLine("2. Save your captured comrades");
                                string saveAnswer = Console.ReadLine();
                                if (saveAnswer == "1")
                                {
                                    Console.WriteLine("You go to save your parnter. You get shot in the leg");
                                    Console.WriteLine("Your partner escapes but you die");
                                    // Inserted Loss of Life
                                    lifePoints -= 10;
                                    Console.WriteLine("-10 HP. Your new HP is " + lifePoints);
                                    if (lifePoints <= 0)
                                    {
                                        Console.WriteLine("You Died");
                                        break;
                                    }
                                    //End of Life Men
                                }
                                else
                                {
                                    Console.WriteLine("You go full Rambo and kill all the enemies because of the power of friendship");
                                    Console.WriteLine("You win!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                    break;                                   
                                }

                            }
                            else
                            {
                                Console.WriteLine("Your partner says \"NANIIII, THATS NOT LLAMA-VERIFIED\"");
                                Console.WriteLine("\"LET ME KILL YOU NOW\"");
                                // Inserted Loss of Life
                                lifePoints -= 10;
                                Console.WriteLine("-10 HP. Your new HP is " + lifePoints);
                                if (lifePoints <= 0)
                                {
                                    Console.WriteLine("You Died");
                                    break;
                                }
                                //End of Life Men

                            }
                        }                             
                    }
                    else if (adventureLocation == 2)
                    {
                        Console.WriteLine("Please purchase the full game to unlock this content");
                        Console.WriteLine("Do you want to purchase the full game?");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");
                        string fullgameAnswer = Console.ReadLine();
                        if (fullgameAnswer == "1")
                        {
                            while (true) {
                                Console.WriteLine("What is your credit card number?");
                                int creditCard;
                                while (true)
                                {
                                    try
                                    {
                                        creditCard = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch (FormatException ex)
                                    {
                                        Console.WriteLine("CREDIT CARD MUST BE A NUMBER");
                                        continue;
                                    }
                                    catch (OverflowException ex)
                                    {
                                        Console.WriteLine("CREDIT CARD NUMBER 2 LONG");
                                        continue;
                                    }
                                    break;
                                }
                                Console.WriteLine("Please entner your address");
                                string addressAnswer = Console.ReadLine();
                                Console.WriteLine("Your credit card is: " + creditCard);
                                Console.WriteLine("Your address is: " + addressAnswer);
                                Console.WriteLine("Is this correct?");
                                Console.WriteLine("1. Yes");
                                Console.WriteLine("2. No");
                                string correctAnswer = Console.ReadLine();
                                if (correctAnswer == "1")
                                {
                                    Console.WriteLine("Thanks for the purchase. The mailman will be to your house Soon^TM");
                                    break;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Well your not cool");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("What was that?");
                        Console.WriteLine("1. Rescue captured soliders at the Old Mountain Correctional Facility");
                        Console.WriteLine("2. Re-Take the Sanctuary Of Mending");
                        adventureLocation = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                }
                break;
            }
            foreach (string item in inv)
            {
                Console.WriteLine("Inventory");
                Console.WriteLine("-------");
                Console.WriteLine(item);
                Console.WriteLine("-------");
            }
            Console.WriteLine("If you got the shoes and hat you are pretty cool");
            Console.WriteLine("You finished the Llama-Federation Game");
            Console.WriteLine("What do you rate this game?");
            string rate = Console.ReadLine();
            if (Convert.ToInt32(rate) > 8)
            {
                Console.WriteLine("Thanks for the positive rating");
            }
            else
            {
                Console.WriteLine("Wow, rude...");
            }
            Console.WriteLine("Play again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            int playAnswer;
            while (true)
            {
                try
                {
                    playAnswer = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("thats not a number");
                    continue;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("number too large");
                    continue;
                }
                break;
            }
            if (playAnswer == 1)
            {
                goto Start;
            }
        }
    }
}




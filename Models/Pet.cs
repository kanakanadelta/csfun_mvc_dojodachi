using System;

namespace Dojodachi.Models
{
    public class Pet
    {
        public int Happiness { get; set; }
        public int Fullness { get; set; }
        public int Energy { get; set; }
        public int Meals { get; set; }
        public bool Alive { get; set; }

        public string Message {get; set;}

        public Pet()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
            Alive = true;
            Message = "Say hello to your Dojodachi!";
        }

        public Pet(
            int fullness,
            int happiness, 
            int meals,
            int energy
        )
        {
            Happiness = happiness;
            Fullness = fullness;
            Energy = energy;
            Meals = meals;
            Alive = true;
            Message = "";
        }

        // methods //

        public string Feed()
        {
            if(Meals<1)
            {
                return "No meals available.";
            }
            else
            {
                Random r = new Random();
                Meals--;

                if(r.Next(0,4) < 1)
                {
                    return "Your Dojodachi didn't enjoy their food and spat it out.";
                }
                else
                {
                    int amount = r.Next(5, 11);
                    Fullness += amount;
                    if(WinCheck())
                        return "Your Dojodachi's spirit has achieved a state peace and transcended from this mortal realm. Congratulations... they left an egg. Raise it?";
                    return "You fed your Dojodachi. Their fullness went up by" + amount + ".";
                }
            }
        }

        public string Play() 
        {
            // decrease energy by 5
            Energy-=5;
            if(Energy<1)
            {
                Alive = false;
                return "Your Dojodachi has died";
            }
            else
            {
                Random r = new Random();

                if(r.Next(0,4) < 1)
                {
                    return "Your Dojodachi didn't cramped up and ended up hurting themselves. They didn't like that.";
                }
                else{
                    int amount = r.Next(5,11);
                    Happiness+= amount;
                    return "You played with your Dojodachi! They're happy by " + amount + " points.";
                }
            }
        }

        public string Work()
        {
            // decrease energy by 5
            Energy-=5;
            if(Energy<1)
            {
                Alive = false;
                return "Your Dojodachi went to work and worked itself to death. RIP, friend.";
            }
            else
            {
                Random r = new Random();
                int mealGet = r.Next(1,4);
                Meals+= mealGet;
                return "You sent your Dojodachi to work. They earned " + mealGet+ " meals today.";
            }
        }

        public string Sleep()
        {
            Fullness-=5;
            Happiness-=5;
            if(Happiness<1 || Fullness<1)
            {
                Alive = false;
                return "Your Dojodachi died in its sleep. Rest in Pieces, my friend. You will (not) be remembered";
            }
            else
            {
                Energy+=15;
                return "Your Dojodachi feels energized after their nice sleep.";
            }
        }

        public bool WinCheck()
        {
            if(Energy >= 100 && Fullness >= 100 && Happiness >= 100)
            {
                return true;
            }
            else
                return false;
            
        }
    }
}
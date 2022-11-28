using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            //set variables
            string monthAnswer;
            string healthAnswer;
            string relationAnswer;
            //introduce the game
            Console.WriteLine("Welcome to the Mystery Fortune Teller. Before I can tell you your fortune, I need to ask you three things.");
            //gather user input
            Console.WriteLine("First, which month were you born in? ");
            monthAnswer = Console.ReadLine();
            //then convert to Uppercase
            string monthUpper = monthAnswer.ToUpper();
            //process repeats three times
            Console.WriteLine("Next, are you feeling healthy today? Please answer 'yes', or 'no'");
            healthAnswer = Console.ReadLine();
            string healthUpper = healthAnswer.ToUpper();
            Console.WriteLine("Finally, are you in a relationship? Please answer 'yes', or 'no'");
            relationAnswer = Console.ReadLine();
            string relationUpper = relationAnswer.ToUpper();
            //choose fortune based on user input
            //first, choose month case 
            switch(monthUpper)
            {
                case "JANUARY":
                    //then choose health case, if
                    if(healthUpper == "YES")
                    {
                        //then choose relationship case, if
                        if(relationUpper == "YES")
                        {
                            Console.WriteLine("You will find a bear on your doorstep.");
                        }
                        //or else if
                        else if(relationUpper == "NO")
                        {
                            Console.WriteLine("You will fall in love with the first stranger you see.");
                        }
                    }
                    //or else if
                    else if (healthUpper == "NO")
                    {
                        //or the if/else if in this statement
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("On your doorstep, you will find a tower of get well gifts from your neighbors.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will have a very bad temper for a week.");
                        }
                    }
                    break;
                    //44 other cases using same process
                case "FEBRUARY":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will get exactly a thousand kisses from your grandmother every time she sees you.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will become famous in a week.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will have high fever for three days straight.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("Everyone will have a week off from work/school in 3 days.");
                        }
                    }
                    break;
                case "MARCH":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will get a job this evening.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("Your room will be robbed tonight.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will get yourself in trouble with your friend. ");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will fall into a ditch if you don't get a good night's sleep first.");
                        }
                    }
                    break;
                case "APRIL":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will handle your work, finances, home affairs and love life with panache.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will wake up in the clouds tomorrow.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will have spagetti for dinner tomorrow.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will find a mouse in your piano. ");
                        }
                    }
                    break;
                case "MAY":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("Tomorrow will be a terrible, no good, very bad day.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will have a new dad today.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will become addicted to Bach, Beethoven, and Brahms.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will be visited by a lion tomorrow.");
                        }
                    }
                    break;
                case "JUNE":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will have ice cream for dinner.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will have a party today.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will be visited by a certain wizard in two days.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("A dragon will greet you with dragon well tea tomorrow.");
                        }
                    }
                    break;
                case "JULY":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will find yourself in Fairyland tomorrow.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You favorite pet will be missing tomorrow.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will go crazy tomorrow.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will have to clean up your room today.");
                        }
                    }
                    break;
                case "AUGUST":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("Your vegetables will all be ruined by deer.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("Your shoes will stick to the ceiling for a day.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will gain 300 pounds tomorrow.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will have no dreams tonight.");
                        }
                    }
                    break;
                case "SEPTEMBER":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will find something strange in your toothpaste.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("Your favorite book will be nominated 'Best book of the year.'");
                        }  
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("I have nothing to say to you.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("A mysterious entitity will posess your dreams tonight.");
                        }
                    }
                    break;
                case "OCTOBER":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will get a break for a whole month.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("Your house will transform into chocolate tomorrow.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("The flu viruses will all be vanquished tomorrow.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will get out of bed head first tomorrow.");
                        }
                    }
                    break;
                case "NOVEMBER":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will have the ability to fly in 4 days.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("Batman will visit your house tonight.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("From now on, your pet is in very grave danger.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will find your backyard covered with feathers tomorrow.");
                        }
                    }
                    break;
                case "DECEMBER":
                    if (healthUpper == "YES")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will have a green thumb tomorrow.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("Tomorrow will rain elephants and giraffs.");
                        }
                    }
                    else if (healthUpper == "NO")
                    {
                        if (relationUpper == "YES")
                        {
                            Console.WriteLine("You will get a good night's rest finally.");
                        }
                        else if (relationUpper == "NO")
                        {
                            Console.WriteLine("You will have a new sister tomorrow.");
                        }
                    }
                    break;
                    //default in case the user makes an invalid input
                    // (I don't know how to make the program restart, so the program will just continue through the questions, print out this message, and then stop)
                default:
                    {
                        Console.WriteLine("Invalid command. Cannot compute.");
                    }
                    break;
            }
            //using this so the program won't shut down right away
            Console.ReadLine();
        }
    }
}

/*
James M. Jones
03/05/2021
DEV2000-O 02: Introduction to Development II
1.4 Code Exercise 01: Loops Review
*/

using System;

namespace Jones_James_CE01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem #1 - For Loop: Piggy Bank

            //Greet the user and say "Let's see how much money we can save in our piggy bank

            Console.WriteLine("Let's see how much money we can save in our piggy bank!");

            Console.WriteLine("What is the starting amount in our piggy bank?");

            //Create a decimal variable since we are working with money.
            //Next, I want to wait for the user's input.

            string stringStartingAmount = Console.ReadLine();

            //Listen and wait for the user's input. We also want to convert the
            //string datatype to a 'decimal' datatype since we are working with
            //money.

            decimal startingAmount;

            //Now we want to create a validation loop to make sure that the user
            //can only input number values. We also want to check for negative values.
            while(!decimal.TryParse(stringStartingAmount, out startingAmount) || startingAmount !<= 0)
            {
                //Tell the user the problem
                Console.WriteLine("\r\nPlease only type in postive number values.");

                //Restate the question
                Console.WriteLine("\r\nWhat is the starting amount in our piggy bank?");

                //Catch the user's response
                //USE same variable!
                stringStartingAmount = Console.ReadLine();
            }

            //Next, we want the user to input the amount they want to save each
            //month. Using a Console.WriteLine(); statement.
            Console.Write("Please enter the amount you want to save each month.");

            //Listen for the user's decimal value as input for saving monthly.
            string stringMonthlySavings = Console.ReadLine();

            //We need to convert the amount saved montly to a decimal.
            decimal monthlySavings;
            //Additionally, I want to validate monthly savings variables and check for negative values.
            while (!decimal.TryParse(stringMonthlySavings, out monthlySavings) || monthlySavings !< 0)
            {
                //Tell the user the problem
                Console.WriteLine("\r\nPlease only type in a decimal value.");

                //Restate the question
                Console.WriteLine("\r\nPlease enter the amount you want to save each month.");

                //Catch the user's response
                //USE same variable!
                stringMonthlySavings = Console.ReadLine();
            }
            //I decided to use a for loop in order to print out each monthly instance and add the amount saved monthly to the startingAmount variable.
            for (int numMonths = 0; numMonths < 12; numMonths++)
            {
                startingAmount += monthlySavings;
                Console.WriteLine("This month you now have ${0}",startingAmount);
            }

            //Problem #2: For Loop: 3,2,1...Blast Off!

            Console.WriteLine("We are going to launch a rocket ship! Please choose a number to countdown from.");

            //We want to allow to the user to input a whole number to countdown.
            string stringCountDownTimer = Console.ReadLine();

            int countDownTimer;

            //Now, we want to create a validation loop so that user can only input whole numbers.
            //We also want to make sure we cannot allow negative integers. 
            while(!int.TryParse(stringCountDownTimer, out countDownTimer) || countDownTimer !< 0)
            {
                //Tell the user the problem
                Console.WriteLine("\r\nPlease only type in a whole number.");

                //Restate the question
                Console.WriteLine("\r\nWe are going to launch a rocket ship! Please choose a number to countdown from.");

                //Catch the user's response
                //USE same variable!
                stringCountDownTimer = Console.ReadLine();
            }
            //First I want to set the countDown Time
            for(countDownTimer = 7; countDownTimer >= 0; countDownTimer--)
            {
                Console.WriteLine(countDownTimer);
            }
            //Write 'BLAST OFF' to the console when the for loop is finished running!

            Console.WriteLine("Blast Off!");

            //Problem #3 While Loop: Darn Good Donuts

            //First, we want to tell the user that we are going to have some DARN good donuts :)
            //Next, we want to ask the user to input how many donuts in are in the boxes.

            Console.WriteLine("We are going to have some darn good donuts today!");

            Console.WriteLine("Please choose a number of how many donuts are in the box.");

            //Next, let's listen for the user's input. Keep in mind, Console.ReadLine();
            //only accepts string datatypes so we need to convert the variable to a number.

            string stringTotalDonuts = Console.ReadLine();

            //Convert the variable to a number to be used for calculations
            int totalDonuts;

            //Next, we can now allow the user to input the numbers of donuts that will be share with our coworkers!
            while(!(int.TryParse(stringTotalDonuts, out totalDonuts) && totalDonuts > 0))
            {
                //Tell the user the problem
                Console.WriteLine("\r\nPlease only type in a whole number.");

                //Restate the question
                Console.WriteLine("\r\nPlease choose a number of how many donuts are in the box.");

                //Catch the user's response
                //USE same variable!
                stringTotalDonuts = Console.ReadLine();
            }
            //Next, we want to begin accepting requests for how many donuts our coworkers would like to eat.
            while(totalDonuts >= 0)
            {   //Restate the user prompt/question
                Console.WriteLine("\r\nHow many donuts would you like to eat?\r\nYou can only eat a maximum of 3 donuts.");
                //We need a new variable to re-prompt the user to input how many donuts they would like to eat.
                string stringDonutsEaten = Console.ReadLine();

                //Remember, we need a number in order to subtract from the total number of donuts in the box.
                //I recommend introducing a new variable to handle this.
                int donutsEaten;

                //This while loop helps use to make sure the user can only take a max of 3 donuts at at time.
                while(!(int.TryParse(stringDonutsEaten, out donutsEaten) && (donutsEaten >= 0 && donutsEaten <= 3)))
                {
                    Console.WriteLine("\r\nYou can only have a maximum of 3 donuts");
                    Console.WriteLine("\r\nHow many donuts would you like to eat?\r\nYou can only eat a maximum of 3 donuts.");
                    //Listen for the user's input again.
                    stringDonutsEaten = Console.ReadLine();
                }
                //We also want to make sure we are subtracting the number of donuts eaten from the total number of donuts in the box.
                totalDonuts -= donutsEaten;

                Console.WriteLine("There are currently {0} donut(s) left to eat.", totalDonuts);
                //I recommend using an if statement to let the user know when all of the donuts have been eaten.
                if (totalDonuts == 0)
                {
                    Console.WriteLine("Donuts are all gone, hope everyone enjoyed them!");
                }//I recommended using an else if statement if the number of donuts is negative.
                else if (totalDonuts < 0)
                {   //Finally, if the number of donuts left is negative, we output the result of the number of donuts that will be owed the next day.
                    totalDonuts = donutsEaten + totalDonuts;
                    Console.WriteLine("I ran out of donuts, I will have to owe you {0} donut(s) tomorrow.", totalDonuts);
                }
            }
        }
    }
}

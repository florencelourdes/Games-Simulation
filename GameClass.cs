/* Florence Lourdes
 * MAT-231 Math for Computing
 * Dr. Melanie Fraser
 * 03/03/2022
 * Game Class
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Prisoner_s_Dilemma
{
    internal class Probability
    {
        double threshold;
        Double num1;
        Double num2;
        Double num3;
        Double num4;
        bool player1;
        bool player2;
        bool player3;
        bool player4;
        bool release;

        public Probability(double threshold)
        {
            this.threshold = threshold;
        }

        //Function to get a random number 
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }

        public void GenerateRandomNumbers() //Generate a random number for each player.
        {
            num1 = RandomNumber(0, 100);
            num1 = Convert.ToDouble(num1);
            num1 = num1 / 100;

            num2 = RandomNumber(0, 100);
            num2 = Convert.ToDouble(num2);
            num2 = num2 / 100;

            num3 = RandomNumber(0, 100);
            num3 = Convert.ToDouble(num3);
            num3 = num3 / 100;

            num4 = RandomNumber(0, 100);
            num4 = Convert.ToDouble(num4);
            num4 = num4 / 100;
        }

        public void WhoPlays() //Determine if each player's number is above the threshold.
        {
            if (num1 >= threshold)
            {
                player1 = true;
            }
            else
            {
                player1 = false;
            }

            if (num2 >= threshold)
            {
                player2 = true;
            }
            else
            {
                player2 = false;
            }

            if (num3 >= threshold)
            {
                player3 = true;
            }
            else
            {
                player3 = false;
            }

            if (num4 >= threshold)
            {
                player4 = true;
            }
            else
            {
                player4 = false;
            }
        }

        public bool RunGameOne()
        {
            int dice1 = 0;
            int dice2 = 0;
            int dice3 = 0;
            int dice4 = 0;
            int diceSum = 0;

            GenerateRandomNumbers();

            WhoPlays();
         
            //Roll a dice for each player who plays and calculate the dice sum.
            if (player1)
            {
                dice1 = RandomNumber(1, 6);
                diceSum += dice1;
            }
            if (player2)
            {
                dice2 = RandomNumber(1, 6);
                diceSum += dice2;
            }
            if (player2)
            {
                dice3 = RandomNumber(1, 6);
                diceSum += dice3;
            }
            if (player2)
            {
                dice4 = RandomNumber(1, 6);
                diceSum += dice4;
            }
            
            //Determine if the dice sum is equal or above 11.
            if (diceSum >= 11)
            {
                release = true;
            }
            else
            {
                release = false;
            }

            return release;
        }


        public bool RunGameTwo()
        {
            int coin;
            bool coin1 = true;
            bool coin2 = true;
            bool coin3 = true;
            bool coin4 = true;

            GenerateRandomNumbers();

            WhoPlays();

            //Return a false for release if no player plays.
            if (player1 == false && player2 == false && player3 == false && player4 == false)
            {
                release = false;
            }

            //Flip a coin for each player who plays. True for tails and False for heads.
            if (player1)
            {
                coin = RandomNumber(1, 100);
                if (coin <= 50)
                {
                    coin1 = true;
                }
                else
                {
                    coin1 = false;
                }
            }
            if (player2)
            {
                coin = RandomNumber(1, 100);
                if (coin <= 50)
                {
                    coin2 = true;
                }
                else
                {
                    coin2 = false;
                }
            }
            if (player3)
            {
                coin = RandomNumber(1, 100);
                if (coin <= 50)
                {
                    coin3 = true;
                }
                else
                {
                    coin3 = false;
                }
            }
            if (player4)
            {
                coin = RandomNumber(1, 100);
                if (coin <= 50)
                {
                    coin4 = true;
                }
                else
                {
                    coin4 = false;
                }
            }

            //Determine release.
            if (coin1 == false || coin2 == false || coin3 == false || coin4 == false)
            {
                release = false;
            }
            else
            {
                release = true;
            }

            return release;         
        }
        

        public bool RunGameThree()
        {
            int dice1 = 1;
            int dice2 = 1;
            int dice3 = 1;
            int dice4 = 1;

            GenerateRandomNumbers();

            WhoPlays();

            //Roll a dice for each player who plays.
            if (player1)
            {
                dice1 = RandomNumber(1, 6);
            }
            if (player2)
            {
                dice2 = RandomNumber(1, 6);
            }
            if (player2)
            {
                dice3 = RandomNumber(1, 6);
            }
            if (player2)
            {
                dice4 = RandomNumber(1, 6);
            }

            //Determine if the dices are odd or even
            if (dice1 % 2 == 0 || dice2 % 2 == 0 || dice3 % 2 == 0 || dice4 % 2 == 0)
            {
                release = false;
            }
            else
            {
                release = true;
            }

            return release;
        }
    }
}

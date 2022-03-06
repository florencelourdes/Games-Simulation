/* Florence Lourdes
 * MAT-231 Math for Computing
 * Dr. Melanie Fraser
 * 03/03/2022
 * Main Class
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Prisoner_s_Dilemma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double threshold1 = 0;
            Double threshold2 = 0.70;
            Double threshold3 = 0.70;
            String gameChoice;
            bool release;
            int releaseSum = 0;

            Console.WriteLine("Please choose game 1, 2, or 3");
            gameChoice = Console.ReadLine();

            if (gameChoice.Equals("1"))
            {
                Probability game1 = new Probability(threshold1);
                for (int i = 0; i < 100; i++)
                {
                    release = game1.RunGameOne();
                    if (release)
                    {
                        releaseSum += 1;
                    }
                    else
                    {
  
                    }
                }

                Console.WriteLine("Probability of release: " + releaseSum + "%");
            }

            else if (gameChoice.Equals("2"))
            {
                Probability game2 = new Probability(threshold2);
                for (int i = 0; i < 100; i++)
                {
                    release = game2.RunGameTwo();
                    if (release)
                    {
                        releaseSum += 1;
                    }
                    else
                    {

                    }
                }

                Console.WriteLine("Probability of release: " + releaseSum + "%");
            }

            else if (gameChoice.Equals("3"))
            {
                Probability game3 = new Probability(threshold3);
                for (int i = 0; i < 100; i++)
                {
                    release = game3.RunGameThree();
                    if (release)
                    {
                        releaseSum += 1;
                    }
                    else
                    {

                    }
                }

                Console.WriteLine("Probability of release: " + releaseSum + "%");
            }
        

            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }

        }
    }
}

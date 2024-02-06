using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_10._7
{
    internal class DiceBag
    {
        // DATA

        Random roll = new Random();
        int noOfD6 = 0;
        int noOfD10 = 0;

        public int NoOfD6 { get => noOfD6; set => noOfD6 = value; }
        public int NoOfD10 { get => noOfD10; set => noOfD10 = value; }

        // METHODS

        public int RollDice()
        {
            int sum = 0;

            for(int i = 0; i < noOfD6; i++)
            {
                sum += roll.Next(1, 7);
            }

            for (int i = 0; i < noOfD10; i++)
            {
                sum += roll.Next(1, 11);
            }

            return sum;
        }
    }
}

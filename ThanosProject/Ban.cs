using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanosProject
{
    class Ban
    {
        List<string> BanList = new List<string>();
        List<int> RandomNumbers = new List<int>();
        Random random = new Random();
        bool canPass = false;
        int randomNumber = 0;
        public List<string> BalanceUniverse(List<string> namePool)
        {
            int universeSize = namePool.Count;
            int banSize = universeSize / 2;
            string[] universe = new string[universeSize];
            namePool.CopyTo(universe);
            for(int i = 0; i < banSize; i++)
            {
                //ex. this will run 2 times and pick to different people
                while(canPass == false)
                {
                    randomNumber = random.Next(0, universeSize);
                    if (RandomNumbers.Contains(randomNumber))
                    {
                        canPass = false;
                    }
                    else
                    {
                        RandomNumbers.Add(randomNumber);
                        canPass = true;
                    }
                }
                BanList.Add(universe[randomNumber]);
                canPass = false;
            }
            return BanList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
     public class CalculateLikes
    {
        public  void LikeCalculator(int days)
        {
            int peopleCount =5;
            int likeCount = 0;
 
            for (int i = 1; i <= days; i++)
            {
                int todayLikes= peopleCount / 2;
                likeCount += todayLikes;
                peopleCount = todayLikes * 3;
            }
            Console.WriteLine(likeCount); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblerProblem
{
   public  class Gambler
    {
        public void Start()
        {
           // int bet = 0;
            int stake = 100;
            int bet;
            int win = 0;
           // Random random = new Random();
            //int bet = random.Next(0,2);
            
            for (bet = 1; bet<stake; bet++)
            {
                
                bet++;
            }
            Console.WriteLine("The everyday bet is " +bet);
        }
        
    }
}

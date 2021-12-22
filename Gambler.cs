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
            int loss = 0;
            Random random = new Random();
           
            
            for (int i = 1; i<=stake; i++)
            {
                bet = random.Next(0, 2);
                if (bet == 1)
                {
                    win++;
                }
                else if(bet == 0)
                {
                    loss++;
                }
                
                
            }
            Console.WriteLine("the wins bet " +win);
            Console.WriteLine("the loss bet "+loss);
            
        }
        
    }
}

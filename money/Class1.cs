using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    public class Money
    {
        int banktones;
        int count;
        public Money(int b, int c)
        {
            banktones = b;
            count = c;
        }
        void ShowInfoMoney(Money[] purse)
        {
            foreach(Money i in purse)
            {
                Console.WriteLine("Banknote: {0} dol. {1} count", i.banktones, i.count);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Blackjack.Library.ListCards();
            var cardList = x.ListCard();
            var point = cardList[9].Points;
            //test
        }
    }
}

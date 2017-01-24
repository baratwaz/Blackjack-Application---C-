using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Library
{
    public class ListCards
    {
        public List<Card> ListCard()
        {
            var cardList = new List<Card>();

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    var card = new Card(j.ToString(), i); 
                   
                    cardList.Add(card);
                }


            }
            return cardList;
        }
    }
}

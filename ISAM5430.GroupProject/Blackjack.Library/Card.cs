using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Library
{
    public class Card
    {
        private string _faceValue;
        private int _suit;
        private int[] _points;
        public Card(string _faceValue1, int _suit1)
        {

            _faceValue = _faceValue1;
            _suit = _suit1;


        }

        public string FaceValue
        {
            set
            {
                if (_faceValue == "11")
                {

                    _faceValue = "J";
                    
                }

                else if (_faceValue == "12")
                {

                    _faceValue = "Q";
                    
                }
                else if (_faceValue == "13")
                {

                    _faceValue = "K";
                    
                }
                else if (_faceValue == "1")
                {

                    _faceValue = "A";
                   
                }
            }
            get
            {
                return _faceValue;
            }
        }
        public int Suit
        {
            set
            {
                _suit = value;
            }
            get
            {
                return _suit;
            }
        }
        public int[] Points
        {
            set
            {

                if (Convert.ToInt32(_faceValue) >= 2 && Convert.ToInt32(_faceValue) <= 10)
                {
                    _points[0] = Convert.ToInt32(_faceValue);
                }
                else if (_faceValue == "J" || _faceValue == "Q" || _faceValue == "K")
                {
                    _points[0] = 10;
                }
                else if (_faceValue == "A")
                {
                    _points[0] = 1;
                    _points[1] = 11;

                }
            }
            get
            {
             
                return _points;
            }
        }
    }
}

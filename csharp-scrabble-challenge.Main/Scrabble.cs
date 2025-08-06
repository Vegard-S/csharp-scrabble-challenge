using System;

using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {
        private string _word;
        public Scrabble(string word)
        {
            
            //TODO: do something with the word variable
            _word = word.ToUpper();




        }

        public int score()
        {
            //TODO: score calculation code goes here
            //throw new NotImplementedException(); //TODO: Remove this line when the code has been written
            
            if (_word.Length == 0) {  return 0; }
            
            

            char[] _alphabet = { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T', 'D', 'G', 'B', 'C', 'M', 'P', 'F', 'H', 'V', 'W', 'Y', 'K', 'J', 'X', 'Q', 'Z' };

            

            char[] value1 = { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
            char[] value2 = { 'D', 'G' };
            char[] value3 = { 'B', 'C', 'M', 'P' };
            char[] value4 = { 'F', 'H', 'V', 'W', 'Y' };
            char[] value5 = { 'K' };
            char[] value8 = { 'J', 'X' };
            char[] value10 = { 'Q', 'Z' };

            int score = 0;
            int multiplierDoubble = 1;
            int multiplierTrippel = 1;
            int numDouble = 0;
            int numtrippel = 0;

            char[] letters = _word.ToCharArray();
            
            foreach (var item in letters)
            {
                //digit check
                if (char.IsDigit(item)) { return 0; }
                if (char.IsWhiteSpace(item)) { return 0; }

                int value = 0;

                if (numDouble < 0 || numtrippel <0)
                {
                    return 0;
                }

                //double check
                if (item == '{')
                {
                    
                    numDouble++;
                    multiplierDoubble = multiplierDoubble*2;
                
                }
                if (item == '}')
                {
                    
                    
                    numDouble--;
                    multiplierDoubble = multiplierDoubble/2;

                }
                //trippel check
                if (item == '[')
                {
                    
                    numtrippel++;
                    multiplierTrippel = multiplierTrippel*3;

                }
                if (item == ']')
                {
                    
                    
                    numtrippel--;
                    multiplierTrippel = multiplierTrippel/3;
                }
                //letter check and value assign
                if (_alphabet.Contains(item))
                {
                    if (value1.Contains(item))
                    {
                        value = 1;
                    }
                    else if (value2.Contains(item))
                    {
                        value = 2;
                    }
                    else if (value3.Contains(item))
                    {
                        value = 3;
                    }
                    else if (value4.Contains(item))
                    {
                        value = 4;
                    }
                    else if (value5.Contains(item))
                    {
                        value = 5;
                    }
                    else if (value8.Contains(item))
                    {
                        value = 8;
                    }
                    else if (value10.Contains(item))
                    {
                        value = 10;
                    }
                }


                score += value * multiplierDoubble * multiplierTrippel;


                
            }

            if (numDouble != 0 || numtrippel != 0)
            {
                return 0;
            }

            return score;


        }
    }
}




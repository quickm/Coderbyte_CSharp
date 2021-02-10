﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte_CSharp.Easy_Challenges
{
    class AlphabetSorter
    {
        // Have the function AlphabetSoup(str) take the str string parameter being 
        // passed and return the string with the letters in alphabetical order (ie. 
        // hello becomes ehllo). Assume numbers and punctuation symbols will not 
        // be included in the string.

        public String AlphabetSoup( String str)
        {
            String result = String.Empty;

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            result = new string(charArray);

            return result;
        }
    }
}

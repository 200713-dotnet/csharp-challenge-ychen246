using System;

namespace Palindrome.Domain
{
    public class Palindrome
    {
        public void isPalindrome(string s)
        {
            char charArray = s.ToCharArray();  //Discovered method online.
            if ((charArray.Length % 2) == 0) //If Even number of character
            {
                char first, last;
                Boolean match = true;
                int counter = 1;
                int midpoint = charArray.Length / 2;
                
                do{
                    char compare = charArray[charArray[charArray.Length-counter]];
                    if (char.ToLower(c) == char.ToLower(compare))
                    {
                        
                    }
                    else
                    {
                        match = false;
                    }
                } while(match);
            }

        }
    }
}

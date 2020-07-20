using System;

namespace Palindrome.Domain
{
    public class Palindrome
    {
        public void isPalindrome(string s)
        {
            char charArray = s.ToCharArray();  //Discovered method online.
            //Needs to remove spaces for phrases.
            if ((charArray.Length % 2) == 0) //If Even number of character
            {
                char first, last;
                Boolean end = false;
                int counter = 0;
                int midpoint = charArray.Length / 2;
                
                do{
                    first = charArray[counter];
                    last = charArray[charArray.Length - 1 - counter];
                    if (first == last)
                    {
                        counter += 1;
                        if(counter = midpoint-1) 
                        {
                            end = true; //Only need to compare half the array.
                        }
                    }
                    else
                    {
                        end = true;
                    }
                } while(!end);
            }
            else //Odd number of character
            {
                 do{
                    first = charArray[counter];
                    last = charArray[charArray.Length - 1 - counter];
                    if (first == last)
                    {
                        counter += 1;
                        if(counter = midpoint)
                        {
                            match = false; //Only need to compare half the array.
                        }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    internal struct Palindrome
    {
        public int Num1 { get; set; } // public property
        /*public bool Palin() // function to check if palindrome
        {
            string numString = Num1.ToString(); // convert int to string
            for (int i = 0;i<numString.Length;i++) // go through string from 0 to size of string
            {
                int j = numString.Length - 1 - i; // set j to opposite character from i
                if (numString[i] == numString[j]) // compare i and j, if equal it is a palindrome so far
                    continue; // keep looping
                else
                {
                    return false; // if not equal, it is not a palindrome
                }

            }
            return true; // if for loop completes, it is a palindrome

        }*/

        public bool Palin()
        {
            string nums = Num1.ToString();
            for (int i = 0; i < nums.Length / 2; i++)
            {
                for (int j = nums.Length - 1; j >= nums.Length / 2 - 1; j--)
                {
                    if (nums[i] != nums[j])
                        return false;
                    else
                        continue;
                }
            }
            return true;
        }
        public Palindrome(int num1) // constructor that takes 1 int
        {
            this.Num1 = num1;
        }
    }
}

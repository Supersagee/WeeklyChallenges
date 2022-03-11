using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null))
            {
                return false;
            }
            
            var containsWord = false;
            
            if (ignoreCase == false)
            {
                if (words.Contains(word))
                {
                    containsWord = true;
                }
                else
                {
                    containsWord = false;
                }
            }

            if (ignoreCase == true)
            {
                foreach (var wrd in words)
                {
                    if (wrd.ToLower() == word.ToLower())
                    {
                        containsWord = true;

                        if (containsWord == true)
                        {
                            break;
                        }
                    }                   
                    else
                    {
                        containsWord = false;
                    }
                }
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = true;
            
            if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 == 0 || num < 0 || num == 1)
            {
                isPrime = false;
            }
            if (num == 2 || num == 3 || num == 5 || num == 7)
            {
                isPrime = true;
            }
            
            return isPrime; 
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            bool uindex;

            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && i != j)
                    {
                        uindex = false;
                    }
                }
                if (uindex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 1;                      
            var longestCount = 1;

            for (var i = 1; i < numbers.Length; i++)
            {                
                if (numbers[i] != numbers[i - 1])
                {
                    count = 0;
                }

                count++;
                
                if (count > longestCount)
                {
                    longestCount = count;
                }
            }                      
            return longestCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();
            var nullCheck = new double[0];

            if (elements == null)
            {
                return nullCheck;
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }

                if (n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }

            return nthElement.ToArray();
        }
    }
}

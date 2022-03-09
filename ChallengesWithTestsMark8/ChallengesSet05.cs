using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }
            
            var firstList = new List<int>();
            int maxLoop = startNumber * n;
            var numbersDivisbleByN = new int[0];

            for (int i = 0; i < maxLoop; i++)
            {
                if (i > startNumber && i % n == 0)
                {
                    firstList.Add(i);
                }
            }

            firstList.ToArray();
            return firstList[0];
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {            
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
                
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            
            var numSumList = new List<int>();

            for (int i = 1; i < numbers.Length; i++)
            {
                if ( numbers[i - 1] % 2 == 0)
                {
                    numSumList.Add(numbers[i]);
                }
            }
            return numSumList.Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if ( words == null || words.Length == 0 )
            {
                return "";
            }

            var sentence = "";

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }

            if ( sentence.Length == 0)
            {
                return "";
            }

            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var returnList = new List<double>();

            if (elements == null)
            {
                return returnList.ToArray();
            }
            
            for (var i = 3; i < elements.Count; i+= 4)
            {
                returnList.Add(elements[i]);
            }
            return returnList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {            
            for (var i = 0; i < nums.Length; i++)
            {
                var num1 = nums[i];

                for (var j = i + 1; j < nums.Length; j++)
                {
                    var num2 = nums[j];

                    if (num1 + num2 == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

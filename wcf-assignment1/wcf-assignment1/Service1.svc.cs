using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string FindPrime(int num)
        {
            // define flag variable
            bool flag = false;
            if (num > 1)
            {
                //check if the input number has factors other than 1 and itself
                for (int i = 2; i < num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        //if there is a factor, set flag as true
                        flag = true;
                        break;
                    }
                }
            }
            if (flag)
            {
                return "not prime number";
            }
            else
            {
                return "prime number";
            }
        }
        public string SumDigits(string num)
        {
            int sum = 0;

            foreach (char digit in num)
            {
                // convert every digit from string to number and 
                // sum up
                sum += int.Parse(digit.ToString());
            }
            // convert integer number to string
            return sum.ToString();
        }

        public string ReverseString(string str)
        {
            //convert input string into char array
            char[] chars = str.ToCharArray();
            //declare an empty reveredstring
            string reversedString = String.Empty;
            //iterate each character from right to left
            for (int i = str.Length - 1; i >= 0; i--)
            {
                //append the character to reversedstring
                reversedString += char.ToString(chars[i]);
            }
            return reversedString;
        }

        public string PrintHTMLTAG(string tag, string data)
        {

            return "<" + tag + ">" + data + "</" + tag + ">";
        }



        public string SortNumbers(string sortType, string fiveNumbers)
        {
            string sortedNum = "";

            //convert input string to number array
            string[] input = fiveNumbers.Split(',');
            int[] nums = Array.ConvertAll(input, int.Parse);

            if (sortType == "Ascending")
            {
                // sort number in ascending order
                Array.Sort(nums);
            }

            if (sortType == "Descending")
            {
                //sort number in decending order
                Array.Sort(nums);
                Array.Reverse(nums);
            }



            //convert number array to string array
            string[] convertToString = Array.ConvertAll(nums, x => x.ToString());
            //convert string array to string and split with comma
            sortedNum = String.Join(",", convertToString);
            return sortedNum;

        }
    }
}

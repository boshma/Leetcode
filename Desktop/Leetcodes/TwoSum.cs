using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{


    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    //You may assume that each input would have exactly one solution, and you may not use the same element twice.

    //You can return the answer in any order.
    class Program
    {
        static void Main(string[] args)
        {
            Solution boop = new Solution();
            int[] nums = new int[] { 5, 3, 2, 4 };
            int[] answer = boop.TwoSum(nums, 9) ;
            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
            Console.ReadLine();
        }
    }

    //public class Solution
    //{
    //    public int[] TwoSum(int[] nums, int target)
    //    {

    //        for (int i = 0; i < nums.Length; i++)
    //        {
    //            for (int j = i + 1; j < nums.Length; j++)
    //            {
    //                if (nums[i] + nums[j] == target)
    //                {
    //                    return new int[] { i, j };
    //                }
    //            }
    //        }
    //        throw new ArgumentException("bruh");
    //    }
    // }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dmap = new Dictionary<int, int> { };

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dmap.ContainsKey(complement))   //Note the ContainsKey, not ContainsValue
                {
                    return new int[] { i, dmap[complement] }; //dmap[index] references the value of the hashmap
                }                                             //which is the index
                else
                {
                    dmap.Add(nums[i], i);  // key = nums[i], value = index
                }
            }

            throw new ArgumentException("wrongg");
            
        }
    }


}



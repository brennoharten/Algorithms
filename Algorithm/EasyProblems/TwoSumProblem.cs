using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace Algorithm.EasyProblems
{
    public static class TwoSumProblem
    {
        //Given an array of integers nums and an integer target, return the indices of the two numbers such that they add up to target.
        public static int[] TwoSum(int[] array, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                var complement = target - array[i];
                if (map.ContainsKey(complement))
                {
                    return new int[]{map[complement], i};
                }
                map[array[i]]= i;
            }
            return Array.Empty<int>();
        }
    }
}
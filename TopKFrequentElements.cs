//347.Top K Frequent Elements
//Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 

//Example 1:

//Input: nums = [1, 1, 1, 2, 2, 3], k = 2
//Output: [1,2]
//Example 2:

//Input: nums = [1], k = 1
//Output: [1]





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
	public class TopKFrequentElements
	{
		public int[] TopKFrequent(int[] nums, int k)
		{
			int[] count = new int[nums.Length];
			Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();


			foreach (int i in nums)
			{
				if (keyValuePairs.ContainsKey(nums[i]))
				{
					keyValuePairs[i]++;
				}
				else
				{
					keyValuePairs[i] = 1;
				}
			}


			foreach (var item in keyValuePairs)
			{
				if (item.Value >= k)
				{

				}
			}


			return null;
		}


	}
}

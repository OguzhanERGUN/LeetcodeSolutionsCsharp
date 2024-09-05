using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

			Solution solution = new Solution();

			solution.GroupAnagrams(strs);
		}
	}
}

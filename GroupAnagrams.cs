using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
	public class Solution
	{
		public Dictionary<string, IList<string>> anagramGroupsMap = new Dictionary<string, IList<string>>();
		private IList<IList<String>> anagramGroupsList = new List<IList<String>>();


		public IList<IList<string>> GroupAnagrams(string[] strs)
		{
			foreach (string str in strs)
			{
				string orderedstr = sortString(str);
				if (anagramGroupsMap.TryGetValue(orderedstr, out var list))
				{
					list.Add(str);
				}
				else
				{
					IList<string> a = new List<string>
					{
						str
					};
					anagramGroupsMap.Add(orderedstr, a);
				}
			}

			foreach (var str in anagramGroupsMap) 
			{
				anagramGroupsList.Add(str.Value);
			}
			return anagramGroupsList;
		}


		static string sortString(String str)
		{
			string orderedWord = "";
			char[] arr = str.ToCharArray();
			Array.Sort(arr);
			foreach (char c in arr)
			{
				orderedWord += c;
			}
			return orderedWord;
		}


	}
}

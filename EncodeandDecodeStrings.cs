using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
	internal class EncodeandDecodeStrings
	{
		public string Encode(IList<string> strs)
		{
			string result = "";
			foreach (string str in strs)
			{
				result += str.Length.ToString() + "#" + str;
			}
			return result;
		}

		public List<string> Decode(string s)
		{
			List<string> result = new List<string>();

			for (int i = 0; i < s.Length; i++)
			{
				if(int.TryParse(s[i].ToString(),out int numb) && s[i+1] == '#')
				{
					result.Add(s.Substring(i+2, i + 2 + numb));
				}
			}

			return result;

		}
	}
}

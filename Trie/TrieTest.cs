using System;
namespace DataStructures
{
	public class TrieTest {
		static void Main () {
			Trie trie = new Trie ();
			string[] strs = new string[] {"siva", "sivaranjani", "gokul", "ganesh", "g", "balaji", "prem", "sairaj", "raja", "prakash",
				"chinna", "varadan", "sathya", "vignesh", "ram", "vinoth", "siva sah"
			};
			foreach (var v in strs)
				trie.Insert (v);
			trie.Display ();

			trie.Delete (strs[0]);
			trie.Display ();
			trie.Delete (strs[1]);
			trie.Delete (strs[2]);
			trie.Delete (strs[3]);
			trie.Display ();

		}
	}
}


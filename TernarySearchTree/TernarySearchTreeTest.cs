using System;
namespace DataStructures
{
	public class TernarySearchTreeTest {
		static void Main () {
			TernarySearchTree tree = new TernarySearchTree ();
			string[] strs = new string[] {"siva", "gokul", "ganesh", "balaji", "prem", "sairaj", "raja", "prakash",
				"chinna", "varadan", "sathya", "vignesh", "ram", "vinoth", "siva sah"
			};
			foreach (var v in strs)
				tree.Insert (v);
			tree.Display ();
		}
	}
}


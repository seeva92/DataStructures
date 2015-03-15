using System;


namespace DataStructures
{
	public class BinarySearchTreeTest {
		static void Main () {
			BinarySearch<int> tree = new BinarySearch<int> ();
			Random rand = new Random ();
			for (int i = 0; i < 10; i++) {
				tree.Insert (rand.Next (1, 100));
			}
			tree.Display (1);
			Console.WriteLine ();
			tree.Display (2);
			Console.WriteLine ();
			tree.Display (3);
			Console.WriteLine ();
			tree.Display (4);
			Console.WriteLine ();
		}
	}
}


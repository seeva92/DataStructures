using System;


namespace DataStructures
{
	public class BinarySearchTreeTest {
		static void Main () {
			BinarySearch<int> tree = new BinarySearch<int> ();
			Random rand = new Random ();
			int[] a = new int[10];
			for (int i = 0; i < 10; i++) {
				a[i] = rand.Next (1, 100);
				tree.Insert (a[i]);
			}
			tree.Display (1);
//			Console.WriteLine ();
//			tree.Display (2);
//			Console.WriteLine ();
//			tree.Display (3);
//			Console.WriteLine ();
//			tree.Display (4);
//			Console.WriteLine ();

			Console.WriteLine ("Siva");
			for (int i = 0; i < 10; i++)
				tree.Delete (a[i]);
			tree.Display (1);

		}
	}
}


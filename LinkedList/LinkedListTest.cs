using System;
namespace DataStructures
{
	public class LinkedListTest {
		static void Main () {
			LL<int> list = new LL<int> ();
			int[] a = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			foreach (var v in a) {
				list.Add (v);
			}
			list.Display ();

			list.Insert (100, 1);
			list.Insert (200, 1);
			list.Insert (100, 10);
			list.Insert (100, 5);

			Console.WriteLine ();
			list.Display ();

			list.Delete (0);
			list.Delete (0);
			list.Delete (0);
			list.Delete (2);
			list.Delete (list.Count - 1);
			Console.WriteLine ();
			list.Display ();
		}
	}
}


using System;
namespace DataStructures
{
	public class StkTest {
		static void Main () {
			Stack<int> stack = new Stack<int> ();
			int[] a = new int[]{ 1, 2, 3, 4, 5 };
			foreach (int v in a) {
				stack.Push (v);
			}

			Console.WriteLine (stack.Top ());
			foreach (int v in a)
				stack.Pop ();
			Console.WriteLine (stack.Top ());

		}
	}
}


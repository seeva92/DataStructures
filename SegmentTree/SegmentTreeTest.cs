using System;
namespace SegmentTree
{
	public class SegmentTreeTest {
		static void Main () {
			int[] a = new int[]{ 3, 6, 1, 5, 2, 4, 9, 7, 8, 10 };
			SegmentTree segTree = new SegmentTree (a.Length);
			segTree.BuildTree (a);
			Console.WriteLine (segTree.Sum (0, 9, 0, a.Length - 1));
			segTree.Update (0, a.Length - 1, 9, 5);
			Console.WriteLine (segTree.Sum (0, 9, 0, a.Length - 1));

		}
	}
}


using System;
namespace SegmentTree
{
	public class SegmentTree {
		private long[] seg;

		public SegmentTree (int size) {
			seg = new long[4 * size];
		}

		private long BuildTreeUtil (long[]segtree, int[]temp, int s, int e, int index) {
			if (s > e)
				return 0;
			if (s == e) {
				segtree[index] = temp[s];
				return segtree[index];
			}
			segtree[2 * index + 1] = BuildTreeUtil (segtree, temp, s, s + (e - s) / 2, 2 * index + 1);
			segtree[2 * index + 2] = BuildTreeUtil (segtree, temp, (s + (e - s) / 2) + 1, e, 2 * index + 2);
			segtree[index] = segtree[2 * index + 1] + segtree[2 * index + 2];			                              
			return segtree[index];
		}

		/// <summary>
		/// Builds the tree.
		/// </summary>
		/// <param name="temp">Input array.</param>
		public void BuildTree (int[] temp) {
			BuildTreeUtil (seg, temp, 0, temp.Length - 1, 0);
		}

		private long SumUtil (long[]segtree, int l, int r, int s, int e, int index) {
			if (r < s || l > e)
				return 0;
			if (l <= s && e <= r)
				return segtree[index];

			long left = SumUtil (segtree, l, r, s, (s + (e - s) / 2), 2 * index + 1);
			long right = SumUtil (segtree, l, r, (s + (e - s) / 2) + 1, e, 2 * index + 2);
			return left + right;
		}

		/// <summary>
		/// Sum the specified l, r, s and e.
		/// </summary>
		/// <param name="l">left</param>
		/// <param name="r">right</param>
		/// <param name="s">start.</param>
		/// <param name="e">end.</param>
		public long Sum (int l, int r, int s, int e) {
			if (s > e || l > r) return 0;
			return SumUtil (seg, l, r, s, e, 0);
		}
			
		/// <summary>
		/// Display this instance.
		/// </summary>
		public void Display () {
			foreach (long v in seg)
				Console.Write (v);
		}

		private long UpdateUtil (long[]seg, int s, int e, int i, int val, int index) {
			if (s > e)
				return 0;
			if (i < s || i > e)
				return 0;
			if (s == e) {
				seg[index] += val - seg[index];
				return seg[index];
			}
				
			int mid = (s + (e - s) / 2);
			if (i <= mid)
				seg[2 * index + 1] = UpdateUtil (seg, s, mid, i, val, 2 * index + 1);
			else
				seg[2 * index + 2] = UpdateUtil (seg, mid + 1, e, i, val, 2 * index + 2);
			return seg[index] = seg[2 * index + 1] + seg[2 * index + 2];
		}
		/// <summary>
		/// Update the specified s, e and i.
		/// </summary>
		/// <param name="s">Start</param>
		/// <param name="e">End.</param>
		/// <param name="i">The index.</param>
		public void Update (int s, int e, int i, int val) {
			if (s > e)
				return;

			UpdateUtil (seg, s, e, i, val, 0);
		}

	}
}


using System;
namespace Queue
{
	public class QueueTest {
		static void Main () {
			Queue<int> queue = new Queue<int> ();
			int[] a = new int[]{ 1, 2, 3, 4, 5, 6, 7 };
			foreach (var v in a)
				queue.Enqueue (v);
			Console.WriteLine (queue.Front ());
			foreach (var v in a)
				queue.Dequeue (v);
			Console.WriteLine (queue.Front ());
		}
	}
}


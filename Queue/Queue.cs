using System;
using System.Threading.Tasks;


namespace Queue
{
	public class Queue<T> {
		private class Node {
			public T data;
			public Node next;
		}
		private Node front, rear;
		public void Enqueue (T val) {
			if (IsEmpty ()) {
				front = new Node (){ data = val };
				rear = new Node (){ data = val };
			} else {
				rear.next = new Node (){ data = val };
				rear = rear.next;
			}
		}
		public void Dequeue (T val) {
			if (IsEmpty ())
				return;
			front = front.next;
		}

		public T Front () {
			if (IsEmpty ())
				return default(T);
			return front.data;
		}

		public bool IsEmpty () {
			if (front == null)
				return true;
			return false;
		}

	}
}


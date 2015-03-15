using System;

namespace DataStructures
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
				rear = front;
			} else {
				rear.next = new Node (){ data = val };
				rear = rear.next;
			}
		}
		public void Dequeue () {
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

		public void Clear () {
			while (front != null) {
				Node temp = front;
				front = front.next;
				temp = null;
			}
			rear = null;
		}

	}
}


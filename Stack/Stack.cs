using System;

namespace Stack
{
	public class Stack<T> {
		private class Node {
			public T data;
			public Node next;
		}
		private Node head;

		public void Push (T val) {
			if (IsEmpty ()) {
				head = new Node (){ data = val };
			} else {
				Node temp = new Node (){ data = val };
				temp.next = head;
				head = temp;
			}
		}
		public void Pop () {
			if (IsEmpty ())
				return;
			head = head.next;
		}

		public T Top () {
			if (head == null)
				return default(T);
			return head.data;
		}

		public bool IsEmpty () {
			if (head == null)
				return true;
			return false;
		}
	}
}


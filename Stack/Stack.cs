using System;

namespace Stack
{
	public class Stack<T> {
		private class Node<T> {
			public T data;
			public Node<T> next;
		}
		private Node<T> head;

		public void Push (T val) {
			if (head == null) {
				head = new Node<T> (){ data = val };
			} else {
				Node<T> temp = new Node<T> (){ data = val };
				temp.next = head;
				head = temp;
			}
		}
		public void Pop () {
			if (head == null)
				return;
			head = head.next;
		}

		public T Top () {
			if (head == null)
				return default(T);
			return head.data;
		}
	}
}


using System;
namespace LinkedList
{
	public class LL<T> {

		public int Count { get; set; }

		public class Node<T> {
			public Node<T> next;
			public T data;
		}
		Node<T> head;

		public Node<T> Last {

			get {
				Node<T> temp = head;
				while (temp.next != null)
					temp = temp.next;
				return temp;
			}
		}
		public void Add (T val) {
			if (head == null) {
				head = new Node<T> ();
				head.data = val;
			} else {

				Node<T> temp = Last;
				temp.next = new Node<T> ();
				temp.next.data = val;
			}
			Count = Count + 1;
		}

		public void Insert (T val, int Position) {
			if (Position > Count || Position < 0)
				return;

			Node<T> newNode = new Node<T> () {
				data = val
			};

			if (Position == 0) {
				newNode.next = head;
				head = newNode;

			} else if (Position == Count) {
				newNode.data = val;
				Last.next = newNode;
			} else {
				Node<T> temp = head;
				int i = 1;
				while (temp != null && i < Position) {
					temp = temp.next;
					i++;
				}

				newNode.next = temp.next;
				temp.next = newNode;
			}
			Count = Count + 1;
		}

		public void Delete (int Position) {
			if (Position >= Count || Position < 0)
				return;

			if (Position == 0)
				head = head.next;
			else {
				Node<T> temp = head;
				int i = 1;
				while (temp != null && i < Position) {
					temp = temp.next;
					i++;
				}

				temp.next = temp.next.next;
			}
			Count = Count - 1;
		}

		public void Display () {
			Node<T> temp = head;
			while (temp != null) {
				Console.WriteLine (temp.data);
				temp = temp.next;
			}
		}
	}
}


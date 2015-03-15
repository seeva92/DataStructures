using System;
namespace DataStructures
{
	public class LL<T> {

		public int Count { get; set; }

		private class Node {
			public Node next;
			public T data;
		}
		private Node head;

		private Node Last {

			get {
				Node temp = head;
				while (temp.next != null)
					temp = temp.next;
				return temp;
			}
		}
		public bool IsEmpty () {
			if (head == null)
				return true;
			return false;
		}
		public void Add (T val) {
			if (IsEmpty ()) {
				head = new Node ();
				head.data = val;
			} else {

				Node temp = Last;
				temp.next = new Node ();
				temp.next.data = val;
			}
			Count = Count + 1;
		}

		public void Insert (T val, int Position) {
			if (Position > Count || Position < 0)
				return;

			Node newNode = new Node () {
				data = val
			};

			if (Position == 0) {
				newNode.next = head;
				head = newNode;

			} else if (Position == Count) {
				newNode.data = val;
				Last.next = newNode;
			} else {
				Node temp = head;
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
				Node temp = head;
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
			Node temp = head;
			while (temp != null) {
				Console.WriteLine (temp.data);
				temp = temp.next;
			}
		}
	}
}


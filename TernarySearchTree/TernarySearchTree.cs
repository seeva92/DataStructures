using System;


namespace DataStructures
{
	public class TernarySearchTree {
		private class Node {
			public char data;
			public Node left, right, center;
			public bool flag;
		}
		private Node root;
		private Node NewNode (char val) {
			Node temp = new Node ();
			temp.data = val;
			return temp;
		}
		private void InsertUtil (ref Node temp, string word, int i) {
			if (temp == null)
				temp = NewNode (word[i]);

			if (word[i].CompareTo (temp.data) < 0)
				InsertUtil (ref temp.left, word, i);
			else if (word[i].CompareTo (temp.data) > 0)
				InsertUtil (ref temp.right, word, i);
			else {
				if (i + 1 < word.Length)
					InsertUtil (ref temp.center, word, i + 1);
				else {
					temp.flag = true;
				}
			}
		}
		public void Insert (string word) {
			InsertUtil (ref root, word, 0);
		}
		private void DisplayUtil (Node temp, string buffer) {
			if (temp != null) {
				DisplayUtil (temp.left, buffer);
				if (temp.flag) {
					Console.WriteLine (buffer + temp.data);
				}
				DisplayUtil (temp.center, buffer + temp.data);
				DisplayUtil (temp.right, buffer);
			}
		}
		public void Display () {
			DisplayUtil (root, "");
		}
	}
}


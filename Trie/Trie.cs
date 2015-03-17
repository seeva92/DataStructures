using System;
using System.Security.Cryptography;


namespace DataStructures
{

	public class Trie {
		const int Size = 256;
		private class Node {
			public bool end { get; set; }
			public Node[] children = new Node[Size];
		}
		Node root;
		public Trie () {
			root = new Node ();
		}
		private void InsertUtil (Node temp, string word) {
			for (int i = 0; i < word.Length; i++) {
				if (temp.children[(int)word[i]] == null)
					temp.children[(int)word[i]] = new Node ();
				temp = temp.children[(int)word[i]];
			}
			temp.end = true;
		}
		public void Insert (string word) {
			if (String.IsNullOrWhiteSpace (word))
				return;
			InsertUtil (root, word);
		}


		private bool IsEmptyNode (Node temp) {
			for (int i = 0; i < Size; i++)
				if (temp.children[i] != null)
					return false;
			return true;
		}
		private bool DeleteUtil (Node temp, string word, int i) {

			if (temp.end && i == word.Length) {
				temp.end = false;
				return true;
			}

			bool flag = false;
			if (i < word.Length && temp.children[(int)word[i]] != null)
				flag = DeleteUtil (temp.children[(int)word[i]], word, i + 1);

			if (flag) {
				if (IsEmptyNode (temp.children[(int)word[i]]) && !temp.end) {
					temp.children[(int)word[i]] = null;
					return true;
				}
			}
			return false;
		}
		public void Delete (string word) {
			if (String.IsNullOrWhiteSpace (word))
				return;
			DeleteUtil (root, word, 0);
		}

		private void DisplayUtil (Node temp, string buffer) {
			if (temp.end) {
				Console.WriteLine (buffer);
			}
			for (int i = 0; i < Size; i++) {
				if (temp.children[i] == null)
					continue;
				DisplayUtil (temp.children[i], buffer + (char)i);
			}

		}
		public void Display () {
			DisplayUtil (root, "");
		}
	}
}


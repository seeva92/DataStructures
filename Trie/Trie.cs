using System;
using System.Security.Cryptography;


namespace DataStructures {

	public class Trie {
		const int Size = 256;
		private class Node {
			public bool end { get; set; }
			public Node[] children = new Node[Size];
		}
	}
}


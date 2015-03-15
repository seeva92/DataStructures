using System;
using DataStructures;
using System.Collections;

namespace DataStructures
{
	public class BinarySearch<T> where T: IComparable {
		private class Node {
			public T data;
			public Node left, right;
		}
		Node root;

		private Node NewNode (T val) {
			Node temp = new Node (){ data = val };
			return temp;
		}

		private void InsertUtil (ref Node temp, T val) {
			if (temp == null)
				temp = NewNode (val);
			else if (val.CompareTo (temp.data) < 0) {
				InsertUtil (ref temp.left, val);
			} else {
				InsertUtil (ref temp.right, val);
			}
		}

		/// <summary>
		/// Traverses the tree in In Order
		/// </summary>
		/// <param name="temp">Temp.</param>
		private void InOrder (Node temp) {
			if (temp != null) {
				InOrder (temp.left);
				Console.WriteLine (temp.data);
				InOrder (temp.right);
			}
		}
		/// <summary>
		/// Traverses the tree in Pre Order
		/// </summary>
		/// <param name="temp">Temp.</param>
		private void PreOrder (Node temp) {
			if (temp != null) {
				Console.WriteLine (temp.data);
				PreOrder (temp.left);
				PreOrder (temp.right);
			}
		}
		/// <summary>
		/// Traverses the tree in Post Order
		/// </summary>
		/// <param name="temp">Temp.</param>
		private void PostOrder (Node temp) {
			if (temp != null) {
				PostOrder (temp.left);
				PostOrder (temp.right);
				Console.WriteLine (temp.data);
			}
		}
		/// <summary>
		/// Traverses the tree in Level Order
		/// </summary>
		/// <param name="temp">Temp.</param>
		private void LevelOrder (Node temp) {
			if (temp == null)
				return;
			Queue<Node> prev = new Queue<Node> ();
			prev.Enqueue (temp);
			Queue<Node> curr = new Queue<Node> ();
			while (!prev.IsEmpty ()) {
				while (!prev.IsEmpty ()) {
					Console.WriteLine (((Node)prev.Front ()).data);
					if (((Node)prev.Front ()).left != null)
						curr.Enqueue (((Node)prev.Front ()).left); 
					if (((Node)prev.Front ()).right != null)
						curr.Enqueue (((Node)prev.Front ()).right);

					prev.Dequeue ();
				}
				prev = curr;
			}

		}
		public void Insert (T val) {
			InsertUtil (ref root, val);
		}

		/// <summary>
		/// Display the specified c.
		/// 1. Inorder
		/// 2. Preorder
		/// 3. Postorder
		/// 4. Levelorder
		/// </summary>
		/// <param name="c">C.</param>
		public void Display (int c) {
			switch (c) {
			case 1:
				InOrder (root);
				break;
			case 2:
				PreOrder (root);
				break;
			case 3:
				PostOrder (root);
				break;
			case 4:
				LevelOrder (root);
				break;
			default:
				InOrder (root);
				break;			
			}
		}
	}
}


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

		/// <summary>
		/// Swap the specified val1 and val2.
		/// </summary>
		/// <param name="val1">Val1.</param>
		/// <param name="val2">Val2.</param>
		private void Swap (ref T val1, ref T val2) {
			T temp;
			temp = val1;
			val1 = val2;
			val2 = temp;
		}
		/// <summary>
		/// Insert utility.
		/// </summary>
		/// <param name="temp">Temp.</param>
		/// <param name="val">Value.</param>
		private void InsertUtil (ref Node temp, T val) {
			if (temp == null)
				temp = NewNode (val);
			else if (val.CompareTo (temp.data) < 0) {
				InsertUtil (ref temp.left, val);
			} else {
				InsertUtil (ref temp.right, val);
			}
		}

		private void DeleteUtil (ref Node temp, T val) {
			if (temp == null)
				return;

			if (val.CompareTo (temp.data) < 0)
				DeleteUtil (ref temp.left, val);
			else if (val.CompareTo (temp.data) > 0)
				DeleteUtil (ref temp.right, val);
			else {
				if (temp.left == null && temp.right == null)
					temp = null;
				else if (temp.left != null && temp.right == null)
					temp = temp.left;
				else if (temp.left == null && temp.right != null)
					temp = temp.right;
				else {
					Node leftMost = temp.right;
					while (leftMost.left != null)
						leftMost = leftMost.left;
					Swap (ref temp.data, ref leftMost.data);
					DeleteUtil (ref temp.right, val);
				}
					
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

		/// <summary>
		/// Insert the specified val.
		/// </summary>
		/// <param name="val">Value.</param>
		public void Insert (T val) {
			InsertUtil (ref root, val);
		}

		public void Delete (T val) {
			DeleteUtil (ref root, val);
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


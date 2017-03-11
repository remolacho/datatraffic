using System;
using System.Collections;
using System.Collections.Generic;

namespace datatraffic.tree
{
	
	public class BinaryTree
	{
		class Node
		{
			public string info;
			public Node left, right;
		}

		Node root;
		private int count;
		private int height;

		public BinaryTree() 
		{
			root=null;
		}

		public void Add (string info)
		{
			Node newNode;
			newNode = new Node ();
			newNode.info = info;
			newNode.left = null;
			newNode.right = null;
			if (root == null)
				root = newNode;
			else
			{
				Node previous = null, current;
				current = root;
				while (current != null)
				{
					previous = current;
					if (previous.left != null)
						current = current.left;
					else
						current = current.right;
				}
				previous.left = newNode;
				previous.right = newNode;
				Console.WriteLine(previous.info);
				Console.WriteLine(previous.right.info);
				Console.WriteLine(previous.left.info);
			}
		}


		private void PrintPre (Node current)
		{
			if (current != null)
			{
				Console.Write(current.info + " ");
				PrintPre (current.left);
				PrintPre (current.right);
			}
		}

		public void PrintPre ()
		{
			PrintPre (root);
			Console.WriteLine();
		}

		private void PrintIn (Node current)
		{
			if (current != null)
			{    
				PrintIn (current.left);
				Console.Write(current.info + " ");
				PrintIn (current.right);
			}
		}

		public void PrintIn ()
		{
			PrintIn (root);
			Console.WriteLine();
		}


		private void PrintPost (Node current)
		{
			if (current != null)
			{
				PrintPost (current.left);
				PrintPost (current.right);
				Console.Write(current.info + " ");
			}
		}


		public void PrintPost ()
		{
			PrintPost (root);
			Console.WriteLine();
		}

		private void CountNodeSheet(Node current) 
		{
			if (current!=null)
			{
				if (current.left==null && current.right==null)
					count++;
				CountNodeSheet(current.left);
				CountNodeSheet(current.right);
			}
		}

		public int CountNodeSheet()
		{
			count=0;
			CountNodeSheet(root);
			return count;
		}

		private void Height (Node current,int level)    
		{
			if (current != null) 
			{    
				Height(current.left,level+1);
				if (level>height)
					height=level;
				Height (current.right,level+1);
			}
		}

		public int Height ()
		{
			height=0;
			Height (root,1);
			return height;
		}



	}
}


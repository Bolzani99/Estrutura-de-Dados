using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_11___ATV_QUIZ
{
public class BinaryTreeNode<T> : TreeNode<T>
	{
		public BinaryTreeNode()
		{
			Children =
				new List<TreeNode<T>>();
		}
		public BinaryTreeNode<T>? Left
		{
			get { return Children.Count > 0 ? (BinaryTreeNode<T>)Children[0] : null!; }
			set { Children[0] = value!; }
		}
		public BinaryTreeNode<T> Right
		{
			get { return Children.Count > 0 ? (BinaryTreeNode<T>)Children[1] : null!; }
			set { Children[1] = value; }
		}
    }
}
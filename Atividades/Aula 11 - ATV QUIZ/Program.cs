using Aula_11___ATV_QUIZ;

BinaryTree<QuizItem> binaryTree = new();

BinaryTree<QuizItem> tree = binaryTree.GetTree();
BinaryTreeNode<QuizItem> node = tree.Root;
while (node != null)
{
    if (node.Left != null || node.Right != null)
    {
        Console.Write(node.Data.Text);
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Y:
                binaryTree.WriteAnswer(" Yes");
                node = node.Left ?? null!;
                break;
            case ConsoleKey.N:
                binaryTree.WriteAnswer(" No");
                node = node.Right ?? null!;
                break;
        }
    }
    else
    {
        binaryTree.WriteAnswer(node.Data!.Text);
        node = null!;
    }
}
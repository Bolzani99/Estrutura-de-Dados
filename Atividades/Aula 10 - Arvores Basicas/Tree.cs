
namespace Aula_10___Arvores_Basicas
{
    public class Tree<T>
    {
        public Node<T>? Root { get; set; }

        public void PrintTree(Node<T> node)
        {
            int Height = 1;
            Console.WriteLine($"Level:{node.GetHeight()}");
            Console.WriteLine($"Node: {node.Data}");
            Console.WriteLine();

            if(node.Children!.Count() > 0)
            
                foreach(var i in node.Children!)
                
                    PrintTree(i);
            
        }

    }
}
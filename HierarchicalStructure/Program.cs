public class Branch
{
    public int data;
    public Branch left, right, centar;

    public Branch(int item)
    {
        data = item;
        left = right = centar= null;
    }
}

public class BinaryTree
{
    Branch root;

    /* Compute the "maxDepth" of a tree -- the number of
    nodes along the longest path from the root node
    down to the farthest leaf node.*/
    int maxDepth(Branch branch)
    {
        if (branch == null)
            return -1;
        else
        {
            /* compute the depth of each subtree */
            int lDepth = maxDepth(branch.left);
            int rDepth = maxDepth(branch.right);
            int cDepth = maxDepth(branch.centar);

            /* use the larger one */
            if (lDepth > rDepth && lDepth > cDepth)
                return (lDepth + 1);
            else if (rDepth > cDepth) 
                return (rDepth + 1);
            else
                return (cDepth + 1);
        }
    }

    /* Driver code */
    public static void Main(String[] args)
    {
        BinaryTree tree = new BinaryTree();

        tree.root = new Branch(1);
        tree.root.left = new Branch(2);
        tree.root.right = new Branch(3);
        tree.root.left.left = new Branch(4);
        tree.root.right.left = new Branch(5);
        tree.root.right.centar = new Branch(6);
        tree.root.right.right = new Branch(7);
        tree.root.right.left.left = new Branch(8);
        tree.root.right.centar.left = new Branch(9);
        tree.root.right.centar.right = new Branch(10);
        tree.root.right.centar.left.centar = new Branch(11);


        Console.WriteLine("Height of tree is : " +
                                    tree.maxDepth(tree.root));
    }
}
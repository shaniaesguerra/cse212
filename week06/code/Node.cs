public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
            {
                //Check if value is already in the tree
                if (Left.Data != value) 
                    Left.Insert(value);
            }
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
            {
                //Check if value is already in the tree
                if (Right.Data != value)
                    Right.Insert(value);
            }
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        //Search for the value in the tree
        //If the value is found, return true (BASE CASE 1)
        if (value == Data)
            return true;

        else if (value < Data)
        {
            //search left
            if (Left != null)
            {
                //Recursively search the left subtree
                return Left.Contains(value);
            }
        }
        else
        {
            //search right
            if (Right != null)
            {
                //Recursively search the right subtree
                return Right.Contains(value);
            }
        }

        //If value is not found, return false (BASE CASE 2)
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        //Traverse the left and right subtrees to find their heights
        int leftHeight = 0;
        int rightHeight = 0;

        //BASE CASE 1: If the node is null, return 0
        if (this == null)
            return 0;

        if (Left != null) //If left subtree exists, get its height
            //Do recursive call to get the height of the left subtree
            leftHeight = Left.GetHeight();

        if (Right != null) //If right subtree exists, get its height
            //Do recursive call to get the height of the right subtree
            rightHeight = Right.GetHeight();

        //Return the larger of the two heights + 1 (for the current node)
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
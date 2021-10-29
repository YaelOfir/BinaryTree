using System;
namespace BinaryTreesAssignmentForRoy
{
    public class Extensions<T> where T : IComparable
    {
        //Q1
        public static int PrintBranch(BinaryTree<T> bt)
        {
            int numOfBranches = 1;
            if (bt == null) return 0; //if there is no tree, there are 0 branches
            if (bt.left != null) numOfBranches += PrintBranch(bt.left);
            if (bt.right != null) numOfBranches += PrintBranch(bt.right);
            return numOfBranches;
        }
        //Q2
        public static int PrintLeaves(BinaryTree<T> bt)
        {
            int numOfLeaves = 0;
            if (bt.left is null && bt.right is null) return 1; //in the assumption there is no tree 
            if (bt.left != null) numOfLeaves += PrintLeaves(bt.left);
            if (bt.right != null) numOfLeaves += PrintLeaves(bt.right);
            return numOfLeaves;
        }
        //Q3
        public static int PrintOnlyChildOfBranch(BinaryTree<T> bt)
        {
            int numOfBranchWOneChild = 0;
            if (bt == null) return 0; 
            if (bt.left != null) numOfBranchWOneChild += PrintOnlyChildOfBranch(bt.left) + 1; 
            if (bt.right != null) numOfBranchWOneChild += PrintOnlyChildOfBranch(bt.right) + 1;
            if (bt.left != null && bt.right == null || bt.left == null && bt.right != null) return numOfBranchWOneChild + 1; 
            return numOfBranchWOneChild;
        }
        //Q4
        public int PrintHeightOfTree(BinaryTree<T> bt)
        {
            if (bt == null) return 0;
            return Math.Max(PrintHeightOfTree(bt.left), PrintHeightOfTree(bt.right)) + 1;
        }
        //Q5
        public bool PrintWhetherTreeIsSBT(BinaryTree<T> bt)
        {
            // if left or right is null- there is nothing to look for
            // else there is something to look for
            //therefor- the tree is a Search Binary Tree
            if (bt.left != null) 
                if (bt.val.CompareTo(bt.left.val) > 0) { if (!PrintWhetherTreeIsSBT(bt.left)) return false; }
                else return false;
            if (bt.right != null)
                if (bt.val.CompareTo(bt.right.val) <= 0) { if (!PrintWhetherTreeIsSBT(bt.right)) return false; }
                else return false;
            return true;
        }
    }
}

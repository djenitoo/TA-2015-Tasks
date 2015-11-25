using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    @"7
    2 4
    3 2
    5 0
    3 5
    5 6
    5 1
*/
namespace TraverseTreeNodes
{
    class TreeTraversal
    {
        static void Main(string[] args)
        {
            var reader = new StringReader(
@"7
2 4
3 2
5 0
3 5
5 6
5 1");

            Console.SetIn(reader);

            int n = int.Parse(Console.ReadLine());
            var treeNodesCollection = new TreeNode<int>[n];
            for (int i = 0; i < n; i++)
            {
                treeNodesCollection[i] = new TreeNode<int>(i);
            }
            for (int i = 1; i < n; i++)
            {
                string[] currentLinePair = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var parent = int.Parse(currentLinePair[0]);
                var child = int.Parse(currentLinePair[1]);

                treeNodesCollection[parent].AddChild(treeNodesCollection[child]);
                treeNodesCollection[child].hasParent = true;
            }

            var rootNode = FindRoot(treeNodesCollection);

            Console.WriteLine("Root node is: " + rootNode.Value);

            var leafNodes = FindAllLeafNodes(treeNodesCollection);
            Console.WriteLine("Found leaf nodes:");
            foreach (var leaf in leafNodes)
            {
                Console.Write(leaf.Value + " ");
            }
            Console.WriteLine();

            var middleNodes = FindMiddleNodes(treeNodesCollection);
            
            Console.WriteLine("Found middle nodes:");
            foreach (var middleNode in middleNodes)
            {
                Console.Write(middleNode.Value + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Longest path depth is " + (1 + FindLongestPath(FindRoot(treeNodesCollection))));

            int sum = 6;
            Console.WriteLine("Paths with sum equal to {0} are:", sum);
            var paths = AllPathsWithSum(treeNodesCollection, sum);
            foreach (var path in paths)
            {
                for (int i = 0; i < path.Length; i++)
                {
                    Console.Write(path[i].Value + " ");
                }
                Console.WriteLine();
            }

            int subTreeSum = 12;
            var subTrees = AllSubTreesWithSum(treeNodesCollection,subTreeSum);
            Console.WriteLine("Roots of subtrees with sum {0}: {1}", subTreeSum, string.Join(", ", subTrees));

        }

        public static TreeNode<int> FindRoot(TreeNode<int>[] treeNodes)
        {
            foreach (var node in treeNodes)
            {
                if (!node.hasParent)
                {
                    return node;
                }
            }

            return null;
        }

        public static List<TreeNode<int>> FindAllLeafNodes(TreeNode<int>[] treeNodes)
        {
            var foundLeafNodes = new List<TreeNode<int>>();

            foreach (var node in treeNodes)
            {
                if (node.ChildrenCount == 0)
                {
                    foundLeafNodes.Add(node);
                }
            }

            return foundLeafNodes;
        }

        public static List<TreeNode<int>> FindMiddleNodes(TreeNode<int>[] treeNodes)
        {
            var foundMiddleNodes = new List<TreeNode<int>>();

            foreach (var node in treeNodes)
            {
                if (node.hasParent && node.ChildrenCount != 0)
                {
                    foundMiddleNodes.Add(node);
                }
            }

            return foundMiddleNodes;
        }  

        public static int FindLongestPath(TreeNode<int> node)
        {
            if (node.ChildrenCount == 0)
            {
                return 0;
            }

            int depth = 0;

            foreach (var child in node.GetChildren())
            {
                depth = Math.Max(depth,FindLongestPath(child));
            }

            return depth + 1;

        }

        public static void FindAllPaths(TreeNode<int> node, Stack<TreeNode<int>> currentPath,
            List<TreeNode<int>[]> paths)
        {
            currentPath.Push(node);
            paths.Add(currentPath.ToArray());

            foreach (var child in node.GetChildren())
            {
                FindAllPaths(child, currentPath, paths);
            }

            currentPath.Pop();
        }

        public static List<TreeNode<int>[]> AllPathsWithSum(TreeNode<int>[] tree, int sum)
        {
            var paths = new List<TreeNode<int>[]>();

            foreach (var node in tree)
            {
                FindAllPaths(node, new Stack<TreeNode<int>>(), paths);
            }

            return paths.Where(path => path.Sum(node => node.Value) == sum).ToList();
        }

        public static List<TreeNode<int>> AllSubTreesWithSum(TreeNode<int>[] tree, int sum)
        {
            return (from node in tree let subSum = node.GetSubSum() where subSum == sum select node).ToList();
        }
    }
}

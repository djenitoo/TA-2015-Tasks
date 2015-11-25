using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseTreeNodes
{
    public class TreeNode<T>
    {
        private T value;
        public bool hasParent;
        private List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value!");
            }
            this.Value = value;
            this.children = new List<TreeNode<T>>();
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value!");
            }

            if (child.hasParent)
            {
                throw new ArgumentException(
                    "The node already has a parent!");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
        public List<TreeNode<T>> GetChildren()
        {
            return this.children;
        }

        public T GetSubSum()
        {
            dynamic sum = this.value;

            foreach (var childie in this.GetChildren())
            {
                sum += childie.GetSubSum();
            }

            return (T)sum;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}

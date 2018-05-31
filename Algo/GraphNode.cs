using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class GraphNode<T> where T:struct
    {
        private ICollection<GraphNode<T>> _parents;
        private ICollection<GraphNode<T>> _children;
        private bool _isVisited;

        public T data { get; private set; }

        public GraphNode(T d)
        {
            _children = new List<GraphNode<T>>();
            _parents = new List<GraphNode<T>>();
            data = d;
        }

        public void AddChild(GraphNode<T> child) {
            _children.Add(child);
        }

        public void AddParent(GraphNode<T> parent)
        {
            _parents.Add(parent);
        }

        public ICollection<GraphNode<T>> GetChildren() {
            return _children;
        }

        public ICollection<GraphNode<T>> GetParents()
        {
            return _parents;
        }

        public void MarkVisited() {
            _isVisited = true;
        }

        public bool GetIsVisited() {
            return _isVisited;
        }

        public void ResetVisited() {
            _isVisited = false;
        }

    }
}

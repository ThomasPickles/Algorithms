using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Graph
    {

        private Graph()
        {
            _nodes = new Dictionary<int, GraphNode<int>>();
        }

        private IDictionary<int, GraphNode<int>> _nodes;

        public static Graph CreateGraph(IEnumerable<int> nodes, IDictionary<int, int[]>  edges)
        {

            var graph = new Graph();
            graph.AddNodes(nodes);
            graph.AddEdges(edges);

            return graph;

        }

        public GraphNode<int> GetRoot() {

            var list = new List<GraphNode<int>>();

            foreach(var node in _nodes.Values)
            {
                if(node.GetParents().Count == 0)
                {
                    return node;
                }
            }
            return null;
        }

        public IList<int> DFSFromRoot()
        {
            foreach (var node in _nodes.Values) {
                node.ResetVisited();
            }

            var root = GetRoot();
            var list = DFS(root, new List<int>());

            return list;
        }

        public IList<int> DFS(GraphNode<int> node, IList<int> list)
        {
            list.Add(node.data);
            node.MarkVisited();

            var children = node.GetChildren();

            foreach (var child in children) {
                if(!child.GetIsVisited()) DFS(child, list);
            }            

            return list;                     
            
        }

        public GraphNode<int> GetNode(int d)
        {
            GraphNode<int> node;
            var success = _nodes.TryGetValue(d, out node);

            return node;
        }


        private void AddNodes(IEnumerable<int> keys) {

            foreach(var key in keys)
            {
                _nodes.Add(key, new GraphNode<int>(key));
            }

        }
        private void AddEdges(IDictionary<int, int[]> edges) {

            foreach(var sourceNode in edges)
            {
                var sourceKey = sourceNode.Key;
                foreach(var targetKey in sourceNode.Value)
                {
                    _nodes[sourceKey].AddChild(_nodes[targetKey]);
                    _nodes[targetKey].AddParent(_nodes[sourceKey]);

                }

            }
            
        }

    }
}

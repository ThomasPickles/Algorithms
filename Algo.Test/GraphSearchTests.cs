using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections;
using System.Collections.Generic;

namespace Algo.Test
{
    [TestClass]
    public class GraphSearchTests
    {
        [TestMethod]
        public void GraphNode_CreateGraphManually_ShouldReturnGraph()
        {
            var graph = CreateGraph();

            graph.Should().NotBeNull("because it's been instantiated");
            
        }


        [TestMethod]
        public void GraphNode_CreateGraphManually_ShouldContainSingleRoot()
        {
            var graph = CreateGraph();
            var root = graph.GetRoot();

            root.data.Should().Be(5);

        }

        [TestMethod]
        public void GraphNode_DepthFirstSearch_ShouldEnumerateInOrder()
        {
            var graph = CreateGraph();

            IList<int> nodes = graph.DFSFromRoot();

            nodes.Should().Equal(5,1,2,7,3,6,4);

        }



        private Graph CreateGraph()
        {
            //Nodes: 1,2,3,4,5,6,7 (root is 5)
            //Edges: [1,2], [2,7], [3,6], [3,7], [4,6], [5,1], [5,3], [5,4], 

            var nodes = new int[]{ 1,2,3,4,5,6,7};
            var edges = new Dictionary<int, int[]>();
            edges.Add(1, new int[] { 2 });
            edges.Add(2, new int[] { 7 });
            edges.Add(3, new int[] { 6, 7 });
            edges.Add(4, new int[] { 6 });
            edges.Add(5, new int[] { 1, 3, 4 });

            var graph = Graph.CreateGraph(nodes, edges);

            return graph;

        }

        


    }
}

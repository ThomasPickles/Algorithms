using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;

namespace Algo.Test
{
    [TestClass]
    public class BinaryTree
    {
        [TestMethod]
        public void GraphNode_CreateTree_ShouldReturnSortedTree()
        {
            var tree = new BinaryNode(3);
            tree.Add(2);
            tree.Add(5);

            Helpers.Traverse(tree).Should().Equal(new List<int> { 2, 3, 5 });
            
        }
    }
}

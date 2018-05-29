using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;

namespace Algo.Test
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void GraphNode_CreateTreeManually_ShouldReturnSortedTree()
        {
            var tree = new BinaryNode(3);
            tree.Add(2);
            tree.Add(5);

            Helpers.Traverse(tree).Should().Equal(new List<int> { 2, 3, 5 });
            
        }


        [TestMethod]
        public void GraphNode_CreateTree_ShouldReturnSortedTree()
        {
            var arr = new List<int>() { 1, 2, 3, 4, 9, 8, 7, 6, 5 };
            var tree = Helpers.CreateTree(arr);

            Helpers.Traverse(tree).Should().Equal(new List<int> { 1,2,3,4,5,6,7,8,9 });

        }


    }
}

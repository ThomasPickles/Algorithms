using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;
using System.Collections;
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

            var list = tree.InOrderTraverse(new List<int>());

            list.Should().Equal(2, 3, 5);
            
        }



        [TestMethod]
        public void GraphNode_CreateTree_ShouldReturnSortedTree()
        {
            var arr = new int[] { 1, 2, 3, 4, 9, 8, 7, 6, 5 };
            var tree = CreateTree(arr);

            var list = tree.InOrderTraverse(new List<int>());

            list.Should().Equal(1,2,3,4,5,6,7,8,9);

        }

        private BinaryNode CreateTree(IEnumerable<int> arr)
        {
            var root = arr.FirstOrDefault();
            var rest = arr.Skip(1).ToArray();
            var tree = new BinaryNode(root);
            tree.Add(rest);
            return tree;
        }

    }
}

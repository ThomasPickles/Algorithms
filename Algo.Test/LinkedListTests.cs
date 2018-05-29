using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Algo.Test
{
    [TestClass]
    public class LinkedListTests
    {

        [TestMethod]
        public void Node_CreateLinkedList_ShouldReturnList()
        {
            // Act
            var list = new Node<int>(1);
            list.AppendToTail(3);
            list.AppendToTail(5);

            // Assert
            list.ToString().Should().Be("1->3->5->NULL");
            
        }


        [TestMethod]
        public void Node_CreateLinkedListAsArray_ShouldReturnList()
        {
            // Act
            var list = new Node<int>(1);
            list.AppendToTail(new int[] {3, 5, 7, 9, 11});

            // Assert
            list.ToString().Should().Be("1->3->5->7->9->11->NULL");

        }

        [TestMethod]
        public void Node_DeleteMiddleNode_ShouldReturnCorrectNodes()
        {
            // Act
            var list = new Node<int>(1);
            list.AppendToTail(new int[] { 3, 5, 7, 9, 11 });
            var newList = list.Delete(7);

            // Assert
            newList.ToString().Should().Be("1->3->5->9->11->NULL");

        }

        [TestMethod]
        public void Node_DeleteHead_ShouldReturnCorrectNodes()
        {
            // Act
            var list = new Node<int>(1);
            list.AppendToTail(new int[] { 3, 5, 7, 9, 11 });
            var newList = list.Delete(1);

            // Assert
            newList.ToString().Should().Be("3->5->7->9->11->NULL");

        }

        [TestMethod]
        public void Node_DeleteTail_ShouldReturnCorrectNodes()
        {
            // Act
            var list = new Node<int>(1);
            list.AppendToTail(new int[] { 3, 5, 7, 9, 11 });
            var newList = list.Delete(11);

            // Assert
            newList.ToString().Should().Be("1->3->5->7->9->NULL");

        }


        [TestMethod]
        public void Node_DeleteNodeNotInList_ShouldReturnFullList()
        {
            // Act
            var list = new Node<int>(1);
            list.AppendToTail(new int[] { 3, 5, 7, 9, 11 });
            var newList = list.Delete(10);

            // Assert
            newList.ToString().Should().Be("1->3->5->7->9->11->NULL");

        }


    }
}

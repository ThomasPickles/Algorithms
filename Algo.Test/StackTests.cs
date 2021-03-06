﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FluentAssertions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algo;

namespace Algo.Test
{

    [TestClass]
    public class StackTests
    {

        [TestMethod]
        public void Stack_CreateStack_ShouldBeLIFO()
        {
            // Act
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);

            var list = new List<object>();
            list.Add(stack.Pop());
            list.Add(stack.Pop());

            // Assert
            list.Should().Equal(5,3);
            
        }

        [TestMethod]
        public void Stack_PopMultipleTimes_ShouldNotError()
        {
            // Act
            var stack = new Stack<int>();

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // Assert
            stack.Should().NotBeNull();

        }

        private List<T> CreateList<T>(params T[] values)
        {
            return new List<T>(values);
        }

    }
}

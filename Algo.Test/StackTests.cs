using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var stack = new Algo.Stack(1);
            stack.Add(3);
            stack.Add(5);

            var list = new List<int?>();
            list.Add(stack.Pop());
            list.Add(stack.Pop());

            // Assert
            list.Should().Equal(new List<int> { 5, 3 });

        }

        [TestMethod]
        public void Stack_PopMultipleTimes_ShouldNotError()
        {
            // Act
            var stack = new Algo.Stack(1);

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // Assert
            stack.Should().NotBeNull();

        }

    }
}

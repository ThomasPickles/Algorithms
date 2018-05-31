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
    public class QueueTests
    {

        [TestMethod]
        public void Queue_CreateStack_ShouldBeFIFO()
        {
            // Act
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(5);

            var list = new List<object>();
            list.Add(queue.Dequeue());
            list.Add(queue.Dequeue());

            // Assert
            list.Should().Equal(1,3);
            
        }

        [TestMethod]
        public void Queue_PopMultipleTimes_ShouldNotError()
        {
            // Act
            var queue = new Queue<int>();

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            // Assert
            queue.Should().NotBeNull();

        }

        private List<T> CreateList<T>(params T[] values)
        {
            return new List<T>(values);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Stack : IQueue
    {
        private Node<int> top;

        public Stack(int d)
        {
            top = new Node<int>(d);
        }

        public void Add(int item)
        {            
            var next = top;
            top = new Node<int>(item);
            top.next = next;
        }

        public int? Pop()
        {
            if (top != null)
            {
                var lastIn = top;
                top = top.Delete(top.data);

                return lastIn.data;
            }
            return null;
        }

      

    }
}

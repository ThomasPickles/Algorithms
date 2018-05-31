using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Stack<T> where T: struct
    {
        private Node<T> top;

        public void Push(T item)
        {            
            var next = top;
            top = new Node<T>(item);
            top.next = next;
        }

        public T? Pop()
        {
            if (top != null)
            {
                var poppedItem = top;
                top = top.Delete(top.data);

                return poppedItem.data;
            }
            return null;
        }

      

    }
}

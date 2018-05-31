using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Queue<T> where T : struct
    {
        private Node<T> front;
        //private Node<object> last;

        // Add item to queue
        public void Enqueue(T item)
        {
            if(front == null)
            {
                front = new Node<T>(item);
            }
            else
            {
                front.AppendToTail(item);
            }

        }

        // Remove from queue
        public T? Dequeue()
        {
            if (front != null) {
                var item = front.data;
                front = front.next;
                return item;
            }
            return null;
        }
    }
}

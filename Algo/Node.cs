using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{

    // a change
    public class Node<T> where T : struct
    {
        public T data;
        public Node<T> next;

        private Node() {
        }

        public Node(T d)
        {
            data = d;
        }

        public void AppendToTail(T d) {

            var end = new Node<T>(d);
            var n = this;

            while(n.next != null) { n = n.next; }

            n.next = end;
            
        }

        public void AppendToTail(IEnumerable<T> arr)
        {
            foreach(var d in arr)
            {
                AppendToTail(d);
            }

        }

        public Node<T> Delete(T d)
        {
            var n = this;
                        
            if (n.data.Equals(d))
            {
                n = n.next; // moved head
                return n;
            }
            while (n.next != null)
            {                
                if (n.next.data.Equals(d))
                {
                    n.next = n.next.next;
                    break; // head didn't change
                }
                n = n.next;
            }
            return this;
        }


        public override string ToString() {

            var n = this;
            string output = n.data.ToString();

            while(n != null)
            {
                output += "->";
                output += n.next != null ? n.next.data.ToString() : "NULL";
                n = n.next;
            }
            return output;

        }

    }

    

}

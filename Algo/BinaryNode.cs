using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class BinaryNode
    {
        public int data;
        public BinaryNode L;
        public BinaryNode R;
        
        public BinaryNode(int d)
        {
            data = d;
        }

        public void Add(int d)
        {
            var n = this;

            while(n != null)
            {
                if (d < n.data)
                {
                    if (n.L != null) {
                        n = n.L;
                    } else {
                        n.L = new BinaryNode(d);
                        break;
                    }
                    
                }
                else
                {
                    if (n.R != null)
                    {
                        n = n.R;
                    }
                    else
                    {
                        n.R = new BinaryNode(d);
                        break;
                    }
                }
            }

        }

        


    }
}

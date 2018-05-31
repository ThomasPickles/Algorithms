using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public static class BinaryNodeExtensions
    {

        public static IList InOrderTraverse(this BinaryNode n, IList list)
        {
            if (n != null)
            {
                n.L.InOrderTraverse(list); // recurse down LHS to bottom
                list.Add(n.data);
                n.R.InOrderTraverse(list);
            }
            return list;

        }

    }
}

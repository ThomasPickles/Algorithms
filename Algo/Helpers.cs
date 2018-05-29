using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public static class Helpers
    {

        public static IList Traverse(BinaryNode n)
        {
            return Traverse(n, new List<int>() { });
        }

        public static IList Traverse(BinaryNode n, IList list)
        {
            if(n != null)
            {
                Traverse(n.L, list); // recurse down LHS to bottom
                list.Add(n.data);
                Traverse(n.R, list);                
            }
            return list;
      
        }

        public static BinaryNode CreateTree(IEnumerable<int> arr)
        {
            var first = arr.FirstOrDefault();
            var rest = arr.Skip(1).ToArray();
            var tree = new BinaryNode(first);
            tree.Add(rest);
            return tree;
        }

    }
}

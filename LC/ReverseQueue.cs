using System.Collections.Generic;
using System.Linq;

namespace LC
{
    public static class Reverse
    {
       public static Queue<int> rev(Queue<int> q)
       {
          Queue<int> result = new Queue<int>();
		      var arr = q.ToArray();
		      for (int i = arr.Length - 1; i >= 0; i--)
		      {
		 	        result.Enqueue(arr[i]);
		      }
    		
        return result;	 
        }
    }
}

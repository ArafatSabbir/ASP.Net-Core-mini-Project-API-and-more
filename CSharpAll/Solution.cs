using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAll
{
    public class Solution
    {
        public int countGoodRectangles(int[][] rectangles)
        {
            int count = 0, maxSide = 0;
            foreach (int[] r in rectangles)
            {
                int side = Math.Min(r[0], r[1]);
                if (side > maxSide)
                {
                    count = 1;
                    maxSide = side;
                }
                else if (side == maxSide)
                {
                    ++count;
                }
            }
            return count;
        }

    }
}


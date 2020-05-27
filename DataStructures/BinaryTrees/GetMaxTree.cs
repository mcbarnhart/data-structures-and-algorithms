﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BinaryTrees
{
    public class GetMaxTree : BinarySearchTree<int>
    {
        private int MinValue = 0;
        public int GetMax(Node Root)
        {
            if (Root == null)
                return MinValue;

            int result = Root.Value;
            int leftResult = GetMax(Root.Left);
            int rightResult = GetMax(Root.Right);

            if (leftResult > result)
                result = leftResult;
            if (rightResult > result)
                result = rightResult;
            return result;
           }
    }
}

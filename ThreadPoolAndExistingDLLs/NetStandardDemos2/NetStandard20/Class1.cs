using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace NetStandard20
{
    public class Class1
    {
        public IEnumerable<int> CreatOneTwoThree()
        {
            return new Bag<int>() { 1, 2, 3 };
        }
    }
}

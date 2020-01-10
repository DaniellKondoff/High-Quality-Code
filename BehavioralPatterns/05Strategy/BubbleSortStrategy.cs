using System;
using System.Collections.Generic;

namespace _05Strategy
{
    class BubbleSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> dataset)
        {
            Console.WriteLine("Sorting using Bubble Sort !");
            return dataset;
        }
    }
}

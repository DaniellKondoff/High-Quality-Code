using System;
using System.Collections.Generic;

namespace _05Strategy
{
    class QuickSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> dataset)
        {
            Console.WriteLine("Sorting using Quick Sort !");
            return dataset;
        }
    }
}

using System.Collections.Generic;

namespace _05Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var unSortedList = new List<int> { 1, 10, 2, 16, 19 };

            var sorter = new Sorter(new BubbleSortStrategy());
            sorter.Sort(unSortedList); // // Output : Sorting using Bubble Sort !

            sorter = new Sorter(new QuickSortStrategy());
            sorter.Sort(unSortedList); // // Output : Sorting using Quick Sort !
        }
    }
}

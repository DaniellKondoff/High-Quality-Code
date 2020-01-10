using System.Collections.Generic;

namespace _05Strategy
{
    public interface ISortStrategy
    {
        List<int> Sort(List<int> dataset);
    }
}

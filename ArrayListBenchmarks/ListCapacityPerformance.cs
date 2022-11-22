using BenchmarkDotNet.Attributes;

namespace ArrayListBenchmarks
{
    [MemoryDiagnoser]
    public class ListCapacityPerformance
    {
        [Params(20, 80, 300, 800)]
        public int capacity;

        [Benchmark]
        public List<int> DynamicCapacity()
        {
            List<int> squidList = new List<int>();
            for (int i = 0; i < capacity; i++)
            {
                squidList.Add(i);
            }
            return squidList;
        }

        [Benchmark]
        public List<int> SetCapacity()
        {
            List<int> squidList = new List<int>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                squidList.Add(i);
            }
            return squidList;
        }
    }
}

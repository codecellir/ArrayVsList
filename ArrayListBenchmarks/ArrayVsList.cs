using BenchmarkDotNet.Attributes;

namespace ArrayListBenchmarks
{
    [MemoryDiagnoser]
    public class ArrayVsList
    {
        [Params(20, 80, 300, 800)]
        public int capacity;

        [Benchmark]
        public int[] ArraySquidlist()
        {
            var playerArray = new int[capacity];
            for (var i = 0; i < capacity; i++)
            {
                playerArray[i] = i;
            }
            return playerArray;
        }

        [Benchmark]
        public List<int> ListSquidlist()
        {
            List<int> playerList = new List<int>(capacity);
            for (var i = 0; i < capacity; i++)
            {
                playerList.Add(i);
            }
            return playerList;
        }
    }
}

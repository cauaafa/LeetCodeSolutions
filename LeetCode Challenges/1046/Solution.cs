public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        foreach (int v in stones) {
            heap.Enqueue(v, 1000 - v);
        }

        while (heap.Count > 1)
        {
            heap.TryDequeue(out int y, out int _);
            heap.TryDequeue(out int x, out int _);

            if (x != y) {
                int c = y - x;
                heap.Enqueue(c, 1000 - c);
            }
        }

        heap.TryDequeue(out int res, out int _);

        return res;
    }
}

public class Solution {
    public int[][] Merge(int[][] intervals) {

        if(intervals.Length <= 1){ return intervals; }

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> res = new List<int[]>();

        res.Add(intervals[0]);

        for(int i = 1; i < intervals.Length; i++){
            int[] interval = intervals[i];
            
            if(res.Last()[1] < interval[0]) {
                res.Add(interval);
            } else {
                res.Last()[1] = Math.Max(res.Last()[1], interval[1]);
            }
        }

        return res.ToArray();
    }
}
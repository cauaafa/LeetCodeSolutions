public class DetectSquares {
    private HashSet<int>[] xIds;
    private HashSet<int>[] yIds;
    private Dictionary<(int, int), int> freq = new();
    
    public DetectSquares() {
        xIds = new HashSet<int>[1001];
        yIds = new HashSet<int>[1001];
        for(int i = 0; i < 1001; i++)
        {
            xIds[i] = new HashSet<int>();
            yIds[i] = new HashSet<int>();
        }
    }
    
    public void Add(int[] point) {
        int x = point[0], y = point[1];
        xIds[x].Add(y);
        yIds[y].Add(x);
        freq.TryAdd((x,y), 0);
        freq[(x,y)]++;
    }
    
    public int Count(int[] point) {
        int x1 = point[0], y1 = point[1];
        if(freq.Count < 3)
            return 0;

        int res = 0;
        foreach(var kvp in freq)
        {
            (int x2, int y2) = kvp.Key;
            if(x2 == x1 || y2 == y1)
                continue;

            if(Math.Abs(x2-x1) != Math.Abs(y2-y1))
                continue;

            if(!xIds[x1].Contains(y2) || !yIds[y1].Contains(x2))
                continue;

            res += freq[(x1, y2)]*freq[(x2,y1)]*freq[(x2,y2)];
        }

        return res;
    }

}

/**
 * Your DetectSquares object will be instantiated and called as such:
 * DetectSquares obj = new DetectSquares();
 * obj.Add(point);
 * int param_2 = obj.Count(point);
 */

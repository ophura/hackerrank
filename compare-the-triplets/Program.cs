(int, int) Rate(IReadOnlyList<int> x, IReadOnlyList<int> y)
{
    (int z, int w) rating = default;
    for (var i = 0; i < x.Count; i++)
        if(x[i] > y[i]) rating.z++;
        else if (y[i] > x[i]) rating.w++;
    return (rating.z, rating.w);
}

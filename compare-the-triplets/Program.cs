(int, int) Rate(int[] x, int[] y)
{
    (int z, int w) rating = default;
    for (var i = 0; i < x.Length; i++)
        if(x[i] > y[i]) rating.z++;
        else if (y[i] > x[i]) rating.w++;
    return (rating.z, rating.w);
}

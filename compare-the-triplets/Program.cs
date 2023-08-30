(int, int) Rate(int[] x, int[] y)
{
    int z = 0, w = 0;
    for (var i = 0; i < x.Length; i++)
        if(x[i] > y[i]) z++;
        else if (y[i] > x[i]) w++;
    return (z, w);
}

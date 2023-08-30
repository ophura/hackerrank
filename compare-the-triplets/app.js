const rate = (x, y) => {
    let z = 0, w = 0;
    for (var i = 0; i < x.length; i++)
        if (x[i] > y[i]) z++;
        else if (y[i] > x[i]) w++;
    return [z, w];
}

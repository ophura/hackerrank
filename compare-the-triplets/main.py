def rate(x: list[int], y: list[int]):
    z, w = 0, 0
    for i in range(len(x)):
        if x[i] > y[i]: z += 1
        elif y[i] > x[i]: w += 1
    return (z, w)

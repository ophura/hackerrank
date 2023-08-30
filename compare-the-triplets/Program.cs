static List<int> Rate(IReadOnlyList<int> bobScores, IReadOnlyList<int> aliceScores)
{
    (int alice, int bob) rating = default;

    var length = Math.Min(bobScores.Count, aliceScores.Count);

    for (var i = 0; i < length; i++)
    {
        if (aliceScores[i] > bobScores[i]) rating.alice++;
        else if (bobScores[i] > aliceScores[i]) rating.bob++;
    }
    
    return flip(rating.alice, rating.bob);

    static List<int> flip(int x, int y) => new(2) { y, x };
}

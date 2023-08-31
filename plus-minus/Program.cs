void PlusMinus(IReadOnlyList<int> list)
{
    double positives = list.Where(x => x > 0).Count();
    double negatives = list.Where(x => x < 0).Count();
    double neutrals = list.Where(x => x == 0).Count();

    Console.WriteLine(positives / list.Count);
    Console.WriteLine(negatives / list.Count);
    Console.WriteLine(neutrals / list.Count);
}

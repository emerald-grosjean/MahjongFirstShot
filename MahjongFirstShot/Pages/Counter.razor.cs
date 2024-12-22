namespace MahjongFirstShot.Pages;

partial class Counter
{
    private readonly List<int> Items = [];

    public Counter()
    {
        Items.AddRange(Enumerable.Range(1, 34 * 4));
    }

    private IEnumerable<int> ShuffleItems()
    {
        var random = new Random();

        return Items.OrderBy(x => random.Next());
    }
}

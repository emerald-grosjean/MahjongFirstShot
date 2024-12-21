namespace MahjongFirstShot.Pages;

partial class Counter
{
    private readonly List<int> Items = [];

    public Counter()
    {
        for (int i = 1; i <= 4; i++)
        {
            Items.AddRange(Enumerable.Range(1, 27));
        }
    }

    private IEnumerable<int> ShuffleItems()
    {
        var random = new Random();

        return Items.OrderBy(x => random.Next());
    }
}

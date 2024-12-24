namespace MahjongFirstShot.Pages;

partial class Counter
{
    private readonly IReadOnlyList<int> Items = Enumerable.Range(1, 34 * 4).ToList().AsReadOnly();

    private IEnumerable<int> ShuffleItems()
    {
        var random = new Random();

        return Items.OrderBy(x => random.Next());
    }
}

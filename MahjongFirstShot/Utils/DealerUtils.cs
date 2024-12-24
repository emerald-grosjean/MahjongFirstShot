namespace MahjongFirstShot.Utils;

public static class DealerUtils
{
    private static readonly IReadOnlyList<int> TileIds = Enumerable.Range(1, 34 * 4).ToList().AsReadOnly();

    public static IEnumerable<int> ShuffleTileIds()
    {
        var random = new Random();

        return TileIds.OrderBy(x => random.Next());
    }
}

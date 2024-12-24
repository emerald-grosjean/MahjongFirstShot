using MahjongFirstShot.Utils;

namespace MahjongFirstShot.Models;

public class Wall
{
    public readonly IReadOnlyList<int> TileIds = DealerUtils.ShuffleTileIds().ToList().AsReadOnly();

    public Wall()
    {
        WallTileIds.AddRange(TileIds.Take(122));
        DeadWallTileIds.AddRange(TileIds.TakeLast(14));
    }

    public List<int> WallTileIds { get; set; } = [];

    public List<int> DeadWallTileIds { get; set; } = [];
}

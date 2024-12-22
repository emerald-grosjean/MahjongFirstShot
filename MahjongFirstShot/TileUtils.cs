using MahjongFirstShot.Enums;

namespace MahjongFirstShot;

public static class TileUtils
{
    public static string FileName(Tile tile)
    {
        return $"{tile.Suit.FileName()}{tile.Rank}{(tile.IsAka() ? "-aka" : string.Empty)}";
    }

    public static string FileName(this Suit suit)
    {
        return suit switch
        {
            Suit.Manzu => "man",
            Suit.Pinzu => "pin",
            Suit.Souzu => "sou",
            Suit.Zihai => "zi",
            _ => throw new NotImplementedException(),
        };
    }
}

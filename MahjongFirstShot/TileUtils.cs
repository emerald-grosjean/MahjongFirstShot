using MahjongFirstShot.Enums;

namespace MahjongFirstShot;

public static class TileUtils
{
    public static Tile GetTile(int tileId)
    {
        var suit = (Suit)(Math.Ceiling((double)tileId / 9) - 1);
        var number = tileId % 9;

        return new()
        {
            Suit = suit,
            Rank = number == 0 ? 9 : number,
        };
    }

    public static string FileName(Tile tile)
    {
        return $"{tile.Suit.FileName()}{tile.Rank}";
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

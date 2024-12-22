using MahjongFirstShot.Enums;

namespace MahjongFirstShot;

public class Tile
{
    public Tile(int id)
    {
        var suit = (Suit)(Math.Ceiling((double)id / 36) - 1);
        var number = (int)Math.Ceiling((double)id / 4) % 9;

        Id = id;
        Suit = suit;
        Rank = number == 0 ? 9 : number;
    }

    public int Id { get; private set; }

    public Suit Suit { get; private set; }

    public int Rank { get; private set; }

    public bool IsAka() => Id is 17 or 53 or 89;
}

using MahjongFirstShot.Enums;

namespace MahjongFirstShot.Tests;

[TestClass()]
public class TileTests
{
    [TestMethod()]
    [DataRow(1, Suit.Manzu, 1)]
    [DataRow(4, Suit.Manzu, 1)]
    [DataRow(5, Suit.Manzu, 2)]
    [DataRow(36, Suit.Manzu, 9)]
    [DataRow(37, Suit.Pinzu, 1)]
    [DataRow(72, Suit.Pinzu, 9)]
    [DataRow(73, Suit.Souzu, 1)]
    [DataRow(108, Suit.Souzu, 9)]
    [DataRow(109, Suit.Zihai, 1)]
    [DataRow(136, Suit.Zihai, 7)]
    public void TileTest(int id, Suit suit, int rank)
    {
        var tile = new Tile(id);

        Assert.AreEqual(suit, tile.Suit);
        Assert.AreEqual(rank, tile.Rank);
    }

    [TestMethod()]
    public void AkaTileTest()
    {
        for (int id = 1; id <= 136; id++)
        {
            var tile = new Tile(id);

            Assert.AreEqual(id is 17 or 53 or 89, tile.IsAka());
        }
    }
}

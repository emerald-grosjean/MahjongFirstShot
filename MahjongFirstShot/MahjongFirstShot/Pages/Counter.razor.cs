namespace MahjongFirstShot.Pages;

partial class Counter
{
    private readonly List<string> BaseItems = [];

    private readonly List<string> Items = [];

    public Counter()
    {
        BaseItems.Add("一");
        BaseItems.Add("二");
        BaseItems.Add("三");
        BaseItems.Add("四");
        BaseItems.Add("五");
        BaseItems.Add("六");
        BaseItems.Add("七");
        BaseItems.Add("八");
        BaseItems.Add("九");

        BaseItems.Add("①");
        BaseItems.Add("②");
        BaseItems.Add("③");
        BaseItems.Add("④");
        BaseItems.Add("⑤");
        BaseItems.Add("⑥");
        BaseItems.Add("⑦");
        BaseItems.Add("⑧");
        BaseItems.Add("⑨");

        BaseItems.Add("１");
        BaseItems.Add("２");
        BaseItems.Add("３");
        BaseItems.Add("４");
        BaseItems.Add("５");
        BaseItems.Add("６");
        BaseItems.Add("７");
        BaseItems.Add("８");
        BaseItems.Add("９");

        for (int i = 1; i <= 4; i++)
        {
            foreach (var item in BaseItems)
            {
                Items.Add(item);
            }
        }
    }

    private List<string> ShuffleItems()
    {
        var random = new Random();

        var shuffledItems = Items.OrderBy(x => random.Next()).ToList();

        return shuffledItems;
    }
}

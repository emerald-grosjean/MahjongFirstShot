namespace MahjongFirstShot;

public static class Utils
{
    public static string DisplayName(int tileId)
    {
        switch (tileId)
        {
            case 1:
                return "一";
            case 2:
                return "二";
            case 3:
                return "三";
            case 4:
                return "四";
            case 5:
                return "五";
            case 6:
                return "六";
            case 7:
                return "七";
            case 8:
                return "八";
            case 9:
                return "九";

            case 10:
                return "①";
            case 11:
                return "②";
            case 12:
                return "③";
            case 13:
                return "④";
            case 14:
                return "⑤";
            case 15:
                return "⑥";
            case 16:
                return "⑦";
            case 17:
                return "⑧";
            case 18:
                return "⑨";

            case 19:
                return "１";
            case 20:
                return "２";
            case 21:
                return "３";
            case 22:
                return "４";
            case 23:
                return "５";
            case 24:
                return "６";
            case 25:
                return "７";
            case 26:
                return "８";
            case 27:
                return "９";

            default:
                throw new NotFiniteNumberException();
        }
    }
}

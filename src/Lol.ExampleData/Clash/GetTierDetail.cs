using Lol.Data.Clash;
using System.Collections.Generic;
namespace Lol.ExampleData.Clash
{
    public partial class ExamClash
    {
        public static List<TierDetailModel> GetTierDetail()
        {
            // TODO: [James] 임시 리소스 정리
            static string imgResource(int name) => $"/Lol.Resources;component/Images/WinIcons/{name}.png";

            List<TierDetailModel> source = new()
            {
                new TierDetailModel(0, 0, "격전의신", "CEX", "28:57", imgResource(1)),
                new TierDetailModel(1, 0, "평경1짱", "SBM", "28:57", imgResource(2)),
                new TierDetailModel(2, 0, "수박먹고싶다", "asd", "28:57", imgResource(3)),
                new TierDetailModel(3, 0, "주지훈", "GOD", "28:57", imgResource(4)),
                new TierDetailModel(4, 0, "korea", "KOR", "28:57", imgResource(5)),
                new TierDetailModel(5, 0, "wOw", "WoW", "28:57", imgResource(6)),
                new TierDetailModel(6, 0, "캐치형 기릿", "OTL", "28:57", imgResource(7)),
                new TierDetailModel(7, 0, "니가 생각하는 그것", "MH", "28:57", imgResource(8)),
                new TierDetailModel(8, 0, "격임버지의 새로운 시도", "LIM", "28:57", imgResource(9)),
                new TierDetailModel(9, 0, "하이루", "ENF", "28:57", imgResource(10)),
                new TierDetailModel(10, 0, "찡긋찡긋", "WEE", "28:57", imgResource(11)),
                new TierDetailModel(11, 0, "존고게이밍", "JGG", "28:57", imgResource(12)),
                new TierDetailModel(12, 0, "1티어", "mTE", "28:57", imgResource(13)),
                new TierDetailModel(13, 0, "서화", "zcv", "28:57", imgResource(14)),
                new TierDetailModel(14, 0, "격전", "OEO", "28:57", imgResource(15)),
                new TierDetailModel(15, 0, "치오띠", "WKU", "28:57", imgResource(16)),

                new TierDetailModel(0, 1, "격전의신", "CEX", "28:57", imgResource(17)),
                new TierDetailModel(1, 1, "평경1짱", "SBM", "28:57", imgResource(18)),
                new TierDetailModel(2, 1, "수박먹고싶다", "asd", "28:57", imgResource(19)),
                new TierDetailModel(3, 1, "주지훈", "GOD", "28:57", imgResource(20)),
                new TierDetailModel(4, 1, "korea", "KOR", "28:57", imgResource(21)),
                new TierDetailModel(5, 1, "wOw", "WoW", "28:57", imgResource(22)),
                new TierDetailModel(6, 1, "캐치형 기릿", "OTL", "28:57", imgResource(23)),
                new TierDetailModel(7, 1, "니가 생각하는 그것", "MH", "28:57", imgResource(24)),
                new TierDetailModel(8, 1, "격임버지의 새로운 시도", "LIM", "28:57", imgResource(25)),
                new TierDetailModel(9, 1, "하이루", "ENF", "28:57", imgResource(26)),
                new TierDetailModel(10, 1, "찡긋찡긋", "WEE", "28:57", imgResource(27)),
                new TierDetailModel(11, 1, "존고게이밍", "JGG", "28:57", imgResource(28)),
                new TierDetailModel(12, 1, "1티어", "mTE", "28:57", imgResource(29)),
                new TierDetailModel(13, 1, "서화", "zcv", "28:57", imgResource(30)),
                new TierDetailModel(14, 1, "격전", "OEO", "28:57", imgResource(31)),
                new TierDetailModel(15, 1, "치오띠", "WKU", "28:57", imgResource(32)),

                new TierDetailModel(0, 2, "격전의신", "CEX", "28:57", imgResource(33)),
                new TierDetailModel(1, 2, "평경1짱", "SBM", "28:57", imgResource(34)),
                new TierDetailModel(2, 2, "수박먹고싶다", "asd", "28:57", imgResource(35)),
                new TierDetailModel(3, 2, "주지훈", "GOD", "28:57", imgResource(36)),
                new TierDetailModel(4, 2, "korea", "KOR", "28:57", imgResource(37)),
                new TierDetailModel(5, 2, "wOw", "WoW", "28:57", imgResource(38)),
                new TierDetailModel(6, 2, "캐치형 기릿", "OTL", "28:57", imgResource(39)),
                new TierDetailModel(7, 2, "니가 생각하는 그것", "MH", "28:57", imgResource(40)),
                new TierDetailModel(8, 2, "격임버지의 새로운 시도", "LIM", "28:57", imgResource(41)),
                new TierDetailModel(9, 2, "하이루", "ENF", "28:57", imgResource(42)),
                new TierDetailModel(10, 2, "찡긋찡긋", "WEE", "28:57", imgResource(43)),
                new TierDetailModel(11, 2, "존고게이밍", "JGG", "28:57", imgResource(44)),
                new TierDetailModel(12, 2, "1티어", "mTE", "28:57", imgResource(45)),
                new TierDetailModel(13, 2, "서화", "zcv", "28:57", imgResource(46)),
                new TierDetailModel(14, 2, "격전", "OEO", "28:57", imgResource(47)),
                new TierDetailModel(15, 2, "치오띠", "WKU", "28:57", imgResource(48))
            };
            return source;
        }
    }
}

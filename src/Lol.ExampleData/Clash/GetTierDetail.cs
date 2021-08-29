using Lol.Data.Clash;
using System.Collections.Generic;

namespace Lol.ExampleData.Clash
{
	public partial class ExamClash
	{
		public static List<TierDetailModel> GetTierDetail()
		{
			List<TierDetailModel> source = new()
			{
				new TierDetailModel(0, "격전의신", "CEX", "28:57", "/Lol.Resources;component/Images/WinningIcons/1.png"),
				new TierDetailModel(1, "평경1짱", "SBM", "28:57", "/Lol.Resources;component/Images/WinningIcons/2.png"),
				new TierDetailModel(2, "수박먹고싶다", "asd", "28:57", "/Lol.Resources;component/Images/WinningIcons/3.png"),
				new TierDetailModel(3, "주지훈", "GOD", "28:57", "/Lol.Resources;component/Images/WinningIcons/4.png"),
				new TierDetailModel(4, "korea", "KOR", "28:57", "/Lol.Resources;component/Images/WinningIcons/5.png"),
				new TierDetailModel(5, "wOw", "WoW", "28:57", "/Lol.Resources;component/Images/WinningIcons/6.png"),
				new TierDetailModel(6, "캐치형 기릿", "OTL", "28:57", "/Lol.Resources;component/Images/WinningIcons/7.png"),
				new TierDetailModel(7, "니가 생각하는 그것", "MH", "28:57", "/Lol.Resources;component/Images/WinningIcons/8.png"),
				new TierDetailModel(8, "격임버지의 새로운 시도", "LIM", "28:57", "/Lol.Resources;component/Images/WinningIcons/9.png"),
				new TierDetailModel(9, "하이루", "ENF", "28:57", "/Lol.Resources;component/Images/WinningIcons/10.png"),
				new TierDetailModel(10, "찡긋찡긋", "WEE", "28:57", "/Lol.Resources;component/Images/WinningIcons/11.png"),
				new TierDetailModel(11, "존고게이밍", "JGG", "28:57", "/Lol.Resources;component/Images/WinningIcons/12.png"),
				new TierDetailModel(12, "1티어", "mTE", "28:57", "/Lol.Resources;component/Images/WinningIcons/13.png"),
				new TierDetailModel(13, "서화", "zcv", "28:57", "/Lol.Resources;component/Images/WinningIcons/14.png"),
				new TierDetailModel(14, "격전", "OEO", "28:57", "/Lol.Resources;component/Images/WinningIcons/15.png"),
				new TierDetailModel(15, "치오띠", "WKU", "28:57", "/Lol.Resources;component/Images/WinningIcons/16.png"),
			};

			return source;
		}
	}
}

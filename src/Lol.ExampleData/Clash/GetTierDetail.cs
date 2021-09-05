using Lol.Data.Clash;
using System.Collections.Generic;
namespace Lol.ExampleData.Clash
{
	public partial class ExamClash
	{
		public static List<TierDetailModel> GetTierDetail()
		{
			// TODO: [James] 임시 리소스 정리
			string imgResource(int name) => $"/Lol.Resources;component/Images/WinIcons/{name}.png";

			List<TierDetailModel> source = new()
			{
				new TierDetailModel(0,  0, "격전의신", "CEX", "28:57", imgResource(1)),
				new TierDetailModel(1,  0, "평경1짱", "SBM", "28:57", imgResource(2)),
				new TierDetailModel(2,  0, "수박먹고싶다", "asd", "28:57", imgResource(3)),
				new TierDetailModel(3,  0, "주지훈", "GOD", "28:57", "/Lol.Resources;component/Images/WinIcons/4.png"),
				new TierDetailModel(4,  0, "korea", "KOR", "28:57", "/Lol.Resources;component/Images/WinIcons/5.png"),
				new TierDetailModel(5,  0, "wOw", "WoW", "28:57", "/Lol.Resources;component/Images/WinIcons/6.png"),
				new TierDetailModel(6,  0, "캐치형 기릿", "OTL", "28:57", "/Lol.Resources;component/Images/WinIcons/7.png"),
				new TierDetailModel(7,  0, "니가 생각하는 그것", "MH", "28:57", "/Lol.Resources;component/Images/WinIcons/8.png"),
				new TierDetailModel(8,  0, "격임버지의 새로운 시도", "LIM", "28:57", "/Lol.Resources;component/Images/WinIcons/9.png"),
				new TierDetailModel(9,  0, "하이루", "ENF", "28:57", "/Lol.Resources;component/Images/WinIcons/10.png"),
				new TierDetailModel(10, 0, "찡긋찡긋", "WEE", "28:57", "/Lol.Resources;component/Images/WinIcons/11.png"),
				new TierDetailModel(11, 0, "존고게이밍", "JGG", "28:57", "/Lol.Resources;component/Images/WinIcons/12.png"),
				new TierDetailModel(12, 0, "1티어", "mTE", "28:57", "/Lol.Resources;component/Images/WinIcons/13.png"),
				new TierDetailModel(13, 0, "서화", "zcv", "28:57", "/Lol.Resources;component/Images/WinIcons/14.png"),
				new TierDetailModel(14, 0, "격전", "OEO", "28:57", "/Lol.Resources;component/Images/WinIcons/15.png"),
				new TierDetailModel(15, 0, "치오띠", "WKU", "28:57", "/Lol.Resources;component/Images/WinIcons/16.png"),

				new TierDetailModel(0, 1, "격전의신", "CEX", "28:57", "/Lol.Resources;component/Images/WinIcons/17.png"),
				new TierDetailModel(1, 1, "평경1짱", "SBM", "28:57", "/Lol.Resources;component/Images/WinIcons/18.png"),
				new TierDetailModel(2, 1, "수박먹고싶다", "asd", "28:57", "/Lol.Resources;component/Images/WinIcons/19.png"),
				new TierDetailModel(3, 1, "주지훈", "GOD", "28:57", "/Lol.Resources;component/Images/WinIcons/20.png"),
				new TierDetailModel(4, 1, "korea", "KOR", "28:57", "/Lol.Resources;component/Images/WinIcons/21.png"),
				new TierDetailModel(5, 1, "wOw", "WoW", "28:57", "/Lol.Resources;component/Images/WinIcons/22.png"),
				new TierDetailModel(6, 1, "캐치형 기릿", "OTL", "28:57", "/Lol.Resources;component/Images/WinIcons/23.png"),
				new TierDetailModel(7, 1, "니가 생각하는 그것", "MH", "28:57", "/Lol.Resources;component/Images/WinIcons/24.png"),
				new TierDetailModel(8, 1, "격임버지의 새로운 시도", "LIM", "28:57", "/Lol.Resources;component/Images/WinIcons/25.png"),
				new TierDetailModel(9, 1, "하이루", "ENF", "28:57", "/Lol.Resources;component/Images/WinIcons/26.png"),
				new TierDetailModel(10, 1, "찡긋찡긋", "WEE", "28:57", "/Lol.Resources;component/Images/WinIcons/27.png"),
				new TierDetailModel(11, 1, "존고게이밍", "JGG", "28:57", "/Lol.Resources;component/Images/WinIcons/28.png"),
				new TierDetailModel(12, 1, "1티어", "mTE", "28:57", "/Lol.Resources;component/Images/WinIcons/29.png"),
				new TierDetailModel(13, 1, "서화", "zcv", "28:57", "/Lol.Resources;component/Images/WinIcons/30.png"),
				new TierDetailModel(14, 1, "격전", "OEO", "28:57", "/Lol.Resources;component/Images/WinIcons/31.png"),
				new TierDetailModel(15, 1, "치오띠", "WKU", "28:57", "/Lol.Resources;component/Images/WinIcons/32.png"),

				new TierDetailModel(0, 2, "격전의신", "CEX", "28:57", "/Lol.Resources;component/Images/WinIcons/33.png"),
				new TierDetailModel(1, 2, "평경1짱", "SBM", "28:57", "/Lol.Resources;component/Images/WinIcons/34.png"),
				new TierDetailModel(2, 2, "수박먹고싶다", "asd", "28:57", "/Lol.Resources;component/Images/WinIcons/35.png"),
				new TierDetailModel(3, 2, "주지훈", "GOD", "28:57", "/Lol.Resources;component/Images/WinIcons/36.png"),
				new TierDetailModel(4, 2, "korea", "KOR", "28:57", "/Lol.Resources;component/Images/WinIcons/37.png"),
				new TierDetailModel(5, 2, "wOw", "WoW", "28:57", "/Lol.Resources;component/Images/WinIcons/38.png"),
				new TierDetailModel(6, 2, "캐치형 기릿", "OTL", "28:57", "/Lol.Resources;component/Images/WinIcons/39.png"),
				new TierDetailModel(7, 2, "니가 생각하는 그것", "MH", "28:57", "/Lol.Resources;component/Images/WinIcons/40.png"),
				new TierDetailModel(8, 2, "격임버지의 새로운 시도", "LIM", "28:57", "/Lol.Resources;component/Images/WinIcons/41.png"),
				new TierDetailModel(9, 2, "하이루", "ENF", "28:57", "/Lol.Resources;component/Images/WinIcons/42.png"),
				new TierDetailModel(10, 2, "찡긋찡긋", "WEE", "28:57", "/Lol.Resources;component/Images/WinIcons/43.png"),
				new TierDetailModel(11, 2, "존고게이밍", "JGG", "28:57", "/Lol.Resources;component/Images/WinIcons/44.png"),
				new TierDetailModel(12, 2, "1티어", "mTE", "28:57", "/Lol.Resources;component/Images/WinIcons/45.png"),
				new TierDetailModel(13, 2, "서화", "zcv", "28:57", "/Lol.Resources;component/Images/WinIcons/46.png"),
				new TierDetailModel(14, 2, "격전", "OEO", "28:57", "/Lol.Resources;component/Images/WinIcons/47.png"),
				new TierDetailModel(15, 2, "치오띠", "WKU", "28:57", "/Lol.Resources;component/Images/WinIcons/48.png"),
			};
			return source;
		}
	}
}
